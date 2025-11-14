using System.Windows.Forms.DataVisualization.Charting;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;

namespace Kiosco_La_esquina.infrastructure.features.Reports.Sales
{
    public partial class Sales : Form
    {
        private readonly SaleService _saleService = new();
        private readonly SaleDetailService _detailService = new();
        private readonly ProductService _productService = new();

        // cache de productos: ID -> Nombre
        private Dictionary<int, string> _productNames = new();

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

            // cargamos todos los productos una sola vez
            _productNames = _productService
                .GetAllProducts()
                .ToDictionary(p => p.ID, p => p.Name ?? string.Empty);

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
                .Take(5)
                .ToList();

            topProductsChart.Series.Clear();
            topProductsChart.Legends.Clear(); // quitamos las previas

            if (grouped.Count == 0)
                return;

            // serie principal
            var series = topProductsChart.Series.Add("TopProductos");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.IsXValueIndexed = true;
            series.IsVisibleInLegend = false;

            // paleta de colores fija
            var colors = new[]
            {
        Color.SteelBlue,
        Color.Orange,
        Color.MediumSeaGreen,
        Color.MediumPurple,
        Color.IndianRed
    };

            // leyenda personalizada al costado
            var legend = new Legend("Productos");
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;
            legend.Font = new Font("Segoe UI", 9);
            topProductsChart.Legends.Add(legend);

            for (int i = 0; i < grouped.Count; i++)
            {
                var item = grouped[i];

                string label = _productNames.TryGetValue(item.ProductId, out var name)
                    ? name
                    : $"Producto {item.ProductId}";

                // agregamos barra
                int idx = series.Points.AddY(item.Quantity);
                series.Points[idx].Color = colors[i % colors.Length];

                // el eje X queda vacío
                series.Points[idx].AxisLabel = "";

                // agregamos entrada a leyenda
                var legendItem = new LegendItem
                {
                    Name = label,
                    Color = colors[i % colors.Length],
                    BorderColor = Color.Black
                };

                legend.CustomItems.Add(legendItem);
            }

            // configuración visual
            var area = topProductsChart.ChartAreas[0];
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            // sacamos texto del eje X
            area.AxisX.LabelStyle.Enabled = false;

            series["PointWidth"] = "0.6";
        }


    }
}
