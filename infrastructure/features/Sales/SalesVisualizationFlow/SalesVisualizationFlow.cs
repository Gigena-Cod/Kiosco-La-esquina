using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;

namespace Kiosco_La_esquina.infrastructure.features.Sales.SalesVisualizationFlow
{
    public partial class SalesVisualizationFlow : Form
    {
        private readonly SaleService _saleService;
        private readonly EmployeeService _employeeService;
        private readonly SaleDetailService _detailService;
        private readonly ProductService _productService;

        private bool _initialized;
        private List<Sale> _sales = new();
        private List<Employee> _employees = new();

        // cache productos: ID -> Nombre
        private Dictionary<int, string> _productNames = new();

        public SalesVisualizationFlow()
        {
            InitializeComponent();
            _saleService = new SaleService();
            _employeeService = new EmployeeService();
            _detailService = new SaleDetailService();
            _productService = new ProductService();
        }

        private void SalesVisualizationFlow_Load(object sender, EventArgs e)
        {
            ConfigureSalesGrid();
            ConfigureSaleDetailsGrid();

            // cache productos para usar en los detalles
            _productNames = _productService
                .GetAllProducts()
                .ToDictionary(p => p.ID, p => p.Name ?? string.Empty);

            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "dd-MM-yyyy";
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-7);

            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "dd-MM-yyyy";
            dateTimePickerTo.Value = DateTime.Today;

            dateTimePickerFrom.ValueChanged += DatePickers_ValueChanged;
            dateTimePickerTo.ValueChanged += DatePickers_ValueChanged;

            LoadEmployeesCombo();
            LoadSales(dateTimePickerFrom.Value, dateTimePickerTo.Value, null, null);

            // cuando cambia la selección de ventas, cargamos detalle
            dataGridViewSales.SelectionChanged += DataGridViewSales_SelectionChanged;

            _initialized = true;
        }

        // =================== GRID IZQUIERDO (VENTAS) ===================

        private void ConfigureSalesGrid()
        {
            dataGridViewSales.AutoGenerateColumns = false;
            dataGridViewSales.ReadOnly = true;
            dataGridViewSales.AllowUserToAddRows = false;
            dataGridViewSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewSales.Columns.Clear();
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "N° de Venta",
                DataPropertyName = nameof(Sale.ID),
                FillWeight = 12
            });
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha",
                DataPropertyName = nameof(Sale.Date),
                DefaultCellStyle = { Format = "dd/MM/yyyy HH:mm" },
                FillWeight = 28
            });
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Empleado",
                DataPropertyName = nameof(Sale.EmployeeName),
                FillWeight = 38
            });
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total ($)",
                DataPropertyName = nameof(Sale.TotalAmount),
                DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight },
                FillWeight = 22
            });
        }

        // =================== GRID DERECHO (DETALLE) ===================

        private void ConfigureSaleDetailsGrid()
        {
            // ajustá el nombre si tu grid se llama distinto
            dataGridViewSaleDetails.AutoGenerateColumns = false;
            dataGridViewSaleDetails.ReadOnly = true;
            dataGridViewSaleDetails.AllowUserToAddRows = false;
            dataGridViewSaleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewSaleDetails.Columns.Clear();
            dataGridViewSaleDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = "Product",
                FillWeight = 50
            });
            dataGridViewSaleDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Quantity",
                FillWeight = 15
            });
            dataGridViewSaleDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio unitario",
                DataPropertyName = "UnitPrice",
                DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight },
                FillWeight = 15
            });
            dataGridViewSaleDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal",
                DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight },
                FillWeight = 20
            });
        }

        private void DataGridViewSales_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridViewSales.CurrentRow == null)
            {
                dataGridViewSaleDetails.DataSource = null;
                return;
            }

            if (dataGridViewSales.CurrentRow.DataBoundItem is not Sale sale)
                return;

            LoadSaleDetails(sale.ID);
        }

        private void LoadSaleDetails(int saleId)
        {
            // si tu SaleDetailService ya tiene un método por saleId, podés usarlo acá;
            // si no, tiramos de todos y filtramos
            var allDetails = _detailService.GetSaleDetails();
            var details = allDetails
                .Where(d => d.SaleId == saleId)
                .ToList();

            var view = details
                .Select(d =>
                {
                    var productName = _productNames.TryGetValue(d.ProductId, out var name)
                        ? name
                        : $"Producto {d.ProductId}";

                    return new
                    {
                        Product = productName,
                        Quantity = d.Quantity,
                        UnitPrice = d.UnitPrice,
                        Subtotal = d.Subtotal
                    };
                })
                .ToList();

            dataGridViewSaleDetails.DataSource = null;
            dataGridViewSaleDetails.DataSource = view;
        }

        // =================== RESTO: filtros de ventas ===================

        private void LoadEmployeesCombo()
        {
            _employees = _employeeService.GetAllEmployees();

            var items = _employees
                .Select(e => new { ID = e.ID, FullName = $"{e.FirstName} {e.LastName}".Trim() })
                .OrderBy(x => x.FullName)
                .ToList();

            items.Insert(0, new { ID = 0, FullName = "Todos" });

            comboBoxEmployee.DisplayMember = "FullName";
            comboBoxEmployee.ValueMember = "ID";
            comboBoxEmployee.DataSource = items;

            comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxEmployee.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEmployee.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxEmployee.SelectedIndex = 0;
            comboBoxEmployee.SelectedIndexChanged += (_, __) => ApplyFilters();
        }

        private void LoadSales(DateTime? from, DateTime? to, int? employeeId, int? saleId)
        {
            _sales = _saleService.GetSales(from, to, employeeId, saleId);
            dataGridViewSales.DataSource = null;
            dataGridViewSales.DataSource = _sales;

            // al recargar ventas, limpiar detalle
            dataGridViewSaleDetails.DataSource = null;
        }

        private void buttonFilter_Click(object sender, EventArgs e) => ApplyFilters();

        private void DatePickers_ValueChanged(object? sender, EventArgs e)
        {
            if (!_initialized) return;
            if (dateTimePickerFrom.Value.Date > dateTimePickerTo.Value.Date)
                dateTimePickerTo.Value = dateTimePickerFrom.Value;
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var from = dateTimePickerFrom.Value.Date;
            var to = dateTimePickerTo.Value.Date.AddDays(1).AddTicks(-1);

            if (from > to)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? employeeId = null;
            if (comboBoxEmployee.SelectedValue != null &&
                int.TryParse(comboBoxEmployee.SelectedValue.ToString(), out var eid) &&
                eid > 0)
            {
                employeeId = eid;
            }

            int? saleId = null;
            var raw = saleIdTextBox.Text.Trim(); // TextBox del Nº de venta
            if (!string.IsNullOrEmpty(raw) && int.TryParse(raw, out var sid) && sid > 0)
                saleId = sid;

            LoadSales(from, to, employeeId, saleId);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // evitar que los DateTimePickers disparen ValueChanged
            dateTimePickerFrom.ValueChanged -= DatePickers_ValueChanged;
            dateTimePickerTo.ValueChanged -= DatePickers_ValueChanged;

            saleIdTextBox.Clear();
            comboBoxEmployee.SelectedIndex = 0;

            dateTimePickerFrom.Value = DateTime.Today.AddDays(-7);
            dateTimePickerTo.Value = DateTime.Today;

            // restaurar eventos
            dateTimePickerFrom.ValueChanged += DatePickers_ValueChanged;
            dateTimePickerTo.ValueChanged += DatePickers_ValueChanged;

            ApplyFilters();
        }


        private void saleIdTextBox_TextChanged(object sender, EventArgs e)
        {
            var txt = saleIdTextBox.Text.Trim();
            if (txt.Length == 0 || int.TryParse(txt, out _))
                ApplyFilters();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: registrar nueva venta
        }
    }
}
