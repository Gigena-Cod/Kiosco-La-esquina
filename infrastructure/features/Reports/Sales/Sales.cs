using System.Windows.Forms.DataVisualization.Charting;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;

namespace Kiosco_La_esquina.infrastructure.features.Reports.Sales
{
    public partial class Sales : Form
    {
        private readonly SaleService _saleService = new();
        private readonly SaleDetailService _detailService = new();

        public Sales()
        {
            InitializeComponent();

            btnApplyFilters.Click += BtnApplyFilters_Click;
            btnClearFilters.Click += BtnClearFilters_Click;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            ConfigureCharts();
            InitFilters();
            LoadCharts();
        }

        private void ConfigureCharts()
        {
            // Usamos siempre el nombre que viene del designer: "Series1"
            salesByDateChart.Series["Series1"].ChartType = SeriesChartType.Line;
            salesByDateChart.Series["Series1"].LegendText = "Ventas";

            salesByEmployeeChart.Series["Series1"].ChartType = SeriesChartType.Bar;
            salesByEmployeeChart.Series["Series1"].LegendText = "Total vendido";

            topProductsChart.Series["Series1"].ChartType = SeriesChartType.Column;
            topProductsChart.Series["Series1"].LegendText = "Cantidad vendida";
        }

        private void InitFilters()
        {
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-30);

            cboEmployee.Items.Clear();
            cboEmployee.Items.Add("Todos");
            cboEmployee.SelectedIndex = 0;

            cboProduct.Items.Clear();
            cboProduct.Items.Add("Todos");
            cboProduct.SelectedIndex = 0;
        }

        private void BtnApplyFilters_Click(object? sender, EventArgs e)
        {
            LoadCharts();
        }

        private void BtnClearFilters_Click(object? sender, EventArgs e)
        {
            InitFilters();
            LoadCharts();
        }

        private void LoadCharts()
        {
            var from = dtpFrom.Value.Date;
            var to = dtpTo.Value.Date.AddDays(1).AddTicks(-1);

            // 1) ventas filtradas por fecha
            List<Sale> sales = _saleService.GetSales(from, to);

            // 2) todos los detalles (GetSaleDetails IGNORA from/to)
            List<SaleDetail> allDetails = _detailService.GetSaleDetails();

            // 3) me quedo solo con los detalles de esas ventas
            var saleIds = new HashSet<int>(sales.Select(s => s.ID));
            List<SaleDetail> details = allDetails
                .Where(d => saleIds.Contains(d.SaleId))
                .ToList();

            LoadSalesByDateChart(sales);
            LoadSalesByEmployeeChart(sales);
            LoadTopProductsChart(details);
        }

        private void LoadSalesByDateChart(IEnumerable<Sale> sales)
        {
            var grouped = sales
                .GroupBy(s => s.Date.Date)
                .Select(g => new { Date = g.Key, Total = g.Sum(x => x.TotalAmount) })
                .OrderBy(x => x.Date)
                .ToList();

            salesByDateChart.Series.Clear();

            var series = new Series("Ventas")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                XValueType = ChartValueType.Date,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                IsValueShownAsLabel = true
            };

            salesByDateChart.Series.Add(series);

            foreach (var item in grouped)
            {
                // Agrego fecha REAL, no string
                int idx = series.Points.AddXY(item.Date, (double)item.Total);

                // Formato de la etiqueta X
                series.Points[idx].AxisLabel = item.Date.ToString("dd/MM");
            }

            var area = salesByDateChart.ChartAreas[0];
            area.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
        }




        private void LoadSalesByEmployeeChart(IEnumerable<Sale> sales)
        {
            var grouped = sales
                .GroupBy(s => (s.EmployeeName ?? string.Empty).Trim())
                .Where(g => !string.IsNullOrEmpty(g.Key))
                .Select(g => new
                {
                    Employee = g.Key,
                    Total = g.Sum(x => x.TotalAmount)
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            Console.WriteLine($"Empleados distintos: {grouped.Count}");

            // Reset total del chart
            salesByEmployeeChart.Series.Clear();

            var series = salesByEmployeeChart.Series.Add("Ventas por empleado");
            series.ChartType = SeriesChartType.Column;   // columnas verticales
            series.IsValueShownAsLabel = true;
            series.IsXValueIndexed = true;

            for (int i = 0; i < grouped.Count; i++)
            {
                var item = grouped[i];

                // Reemplaza la línea:
                // int pointIndex = series.Points.Add((double)item.Total);
                // por lo siguiente:
                int pointIndex = series.Points.AddXY(i, (double)item.Total);
                series.Points[i].AxisLabel = item.Employee;

                // Label para el eje X
                series.Points[pointIndex].AxisLabel = item.Employee;
            }

            var area = salesByEmployeeChart.ChartAreas[0];
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            salesByEmployeeChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

        }





        private void LoadTopProductsChart(IEnumerable<SaleDetail> details)
        {
            var grouped = details
                .GroupBy(d => d.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    Quantity = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(x => x.Quantity)
                .Take(10)
                .ToList();

            topProductsChart.Series.Clear();

            if (grouped.Count == 0)
                return;

            var series = topProductsChart.Series.Add("Cantidad vendida");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.IsXValueIndexed = true;

            for (int i = 0; i < grouped.Count; i++)
            {
                var item = grouped[i];
                int idx = series.Points.AddY(item.Quantity);
                series.Points[idx].AxisLabel = item.ProductId.ToString();
            }

            var area = topProductsChart.ChartAreas[0];
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            // nombres inclinados
            area.AxisX.LabelStyle.Angle = -45;
        }


    }
}
