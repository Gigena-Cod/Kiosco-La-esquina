using System;
using System.Collections.Generic;
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

        private bool _initialized;
        private List<Sale> _sales = new();
        private List<Employee> _employees = new();

        public SalesVisualizationFlow()
        {
            InitializeComponent();
            _saleService = new SaleService();
            _employeeService = new EmployeeService();
        }

        private void SalesVisualizationFlow_Load(object sender, EventArgs e)
        {
            ConfigureDataGrid();

            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "dd-MM-yyyy";
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-7);

            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "dd-MM-yyyy";
            dateTimePickerTo.Value = DateTime.Today;

            // Filtro automático
            dateTimePickerFrom.ValueChanged += DatePickers_ValueChanged;
            dateTimePickerTo.ValueChanged += DatePickers_ValueChanged;

            LoadEmployeesCombo();
            LoadSales(dateTimePickerFrom.Value, dateTimePickerTo.Value, null);

            _initialized = true;
        }

        private void ConfigureDataGrid()
        {
            dataGridViewSales.AutoGenerateColumns = false;
            dataGridViewSales.ReadOnly = true;
            dataGridViewSales.AllowUserToAddRows = false;
            dataGridViewSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // que ocupe todo el ancho
            dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewSales.Columns.Clear();
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
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

        private void LoadSales(DateTime? from, DateTime? to, int? employeeId)
        {
            _sales = _saleService.GetSales(from, to, employeeId);
            dataGridViewSales.DataSource = null;
            dataGridViewSales.DataSource = _sales;
        }

        private void buttonFilter_Click(object sender, EventArgs e) => ApplyFilters();

        // Aplica filtro automático al cambiar fechas
        private void DatePickers_ValueChanged(object? sender, EventArgs e)
        {
            if (!_initialized) return;

            // Normaliza rango
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
                int.TryParse(comboBoxEmployee.SelectedValue.ToString(), out var id) &&
                id > 0)
            {
                employeeId = id;
            }

            LoadSales(from, to, employeeId);
        }


       

    }
}
