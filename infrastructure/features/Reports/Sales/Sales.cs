using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kiosco_La_esquina.infrastructure.features.Reports.Sales
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // Evolución de ventas -> Line o Column
            salesByDateChart.Series["Series1"].ChartType = SeriesChartType.Line;
            // salesByDateChart.Series["Series1"].ChartType = SeriesChartType.Column;

            // Ventas por empleado -> Bar horizontal
            salesByEmployeeChart.Series["Series1"].ChartType = SeriesChartType.Bar;

            // Top 10 productos más vendidos -> Column
            topProductsChart.Series["Series1"].ChartType = SeriesChartType.Column;
        }

    }
}
