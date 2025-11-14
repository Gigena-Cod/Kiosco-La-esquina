namespace Kiosco_La_esquina.infrastructure.features.Reports.Sales
{
    partial class Sales
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            filtersPanel = new Panel();
            filtersTable = new TableLayoutPanel();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            actionsPanel = new FlowLayoutPanel();
            btnApplyFilters = new Button();
            btnClearFilters = new Button();
            salesByDateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            salesByEmployeeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            topProductsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            filtersPanel.SuspendLayout();
            filtersTable.SuspendLayout();
            actionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesByDateChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesByEmployeeChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topProductsChart).BeginInit();
            SuspendLayout();
            // 
            // filtersPanel
            // 
            filtersPanel.Controls.Add(filtersTable);
            filtersPanel.Controls.Add(actionsPanel);
            filtersPanel.Dock = DockStyle.Top;
            filtersPanel.Location = new Point(0, 0);
            filtersPanel.Name = "filtersPanel";
            filtersPanel.Size = new Size(1258, 90);
            filtersPanel.TabIndex = 0;
            // 
            // filtersTable
            // 
            filtersTable.ColumnCount = 4;
            filtersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            filtersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            filtersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            filtersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            filtersTable.Controls.Add(lblFrom, 0, 0);
            filtersTable.Controls.Add(dtpFrom, 1, 0);
            filtersTable.Controls.Add(lblTo, 2, 0);
            filtersTable.Controls.Add(dtpTo, 3, 0);
            filtersTable.Dock = DockStyle.Fill;
            filtersTable.Location = new Point(0, 0);
            filtersTable.Name = "filtersTable";
            filtersTable.RowCount = 2;
            filtersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            filtersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            filtersTable.Size = new Size(1038, 90);
            filtersTable.TabIndex = 0;
            // 
            // lblFrom
            // 
            lblFrom.Anchor = AnchorStyles.Left;
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(3, 15);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(72, 15);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "Fecha desde";
            // 
            // dtpFrom
            // 
            dtpFrom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(262, 11);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(253, 23);
            dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            lblTo.Anchor = AnchorStyles.Left;
            lblTo.AutoSize = true;
            lblTo.Location = new Point(521, 15);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(69, 15);
            lblTo.TabIndex = 2;
            lblTo.Text = "Fecha hasta";
            // 
            // dtpTo
            // 
            dtpTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(780, 11);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(255, 23);
            dtpTo.TabIndex = 3;
            // 
            // actionsPanel
            // 
            actionsPanel.Controls.Add(btnApplyFilters);
            actionsPanel.Controls.Add(btnClearFilters);
            actionsPanel.Dock = DockStyle.Right;
            actionsPanel.FlowDirection = FlowDirection.RightToLeft;
            actionsPanel.Location = new Point(1038, 0);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Padding = new Padding(5, 15, 5, 5);
            actionsPanel.Size = new Size(220, 90);
            actionsPanel.TabIndex = 1;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Location = new Point(107, 18);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(100, 30);
            btnApplyFilters.TabIndex = 0;
            btnApplyFilters.Text = "Aplicar filtros";
            btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // btnClearFilters
            // 
            btnClearFilters.Location = new Point(107, 54);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(100, 30);
            btnClearFilters.TabIndex = 1;
            btnClearFilters.Text = "Limpiar";
            btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // salesByDateChart
            // 
            chartArea1.Name = "ChartArea1";
            salesByDateChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            salesByDateChart.Legends.Add(legend1);
            salesByDateChart.Location = new Point(12, 220);
            salesByDateChart.Name = "salesByDateChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            salesByDateChart.Series.Add(series1);
            salesByDateChart.Size = new Size(377, 300);
            salesByDateChart.TabIndex = 1;
            salesByDateChart.Text = "salesByDateChart";
            // 
            // salesByEmployeeChart
            // 
            chartArea2.Name = "ChartArea1";
            salesByEmployeeChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            salesByEmployeeChart.Legends.Add(legend2);
            salesByEmployeeChart.Location = new Point(438, 220);
            salesByEmployeeChart.Name = "salesByEmployeeChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            salesByEmployeeChart.Series.Add(series2);
            salesByEmployeeChart.Size = new Size(377, 300);
            salesByEmployeeChart.TabIndex = 2;
            salesByEmployeeChart.Text = "salesByEmployeeChart";
            // 
            // topProductsChart
            // 
            chartArea3.Name = "ChartArea1";
            topProductsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            topProductsChart.Legends.Add(legend3);
            topProductsChart.Location = new Point(863, 220);
            topProductsChart.Name = "topProductsChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            topProductsChart.Series.Add(series3);
            topProductsChart.Size = new Size(377, 300);
            topProductsChart.TabIndex = 3;
            topProductsChart.Text = "topProductsChart";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 4;
            label1.Text = "Evolución de ventas";
            // 
            // label2
            // 
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(398, 64);
            label2.TabIndex = 5;
            label2.Text = "Muestra cómo varían las ventas dentro del rango de fechas seleccionado.\nIdeal para identificar tendencias, picos y caídas de facturación";
            // 
            // label3
            // 
            label3.Location = new Point(438, 136);
            label3.Name = "label3";
            label3.Size = new Size(398, 64);
            label3.TabIndex = 7;
            label3.Text = "Compara cuánto vende cada miembro del equipo en el período elegido.\nÚtil para medir rendimiento individual y detectar diferencias marcadas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 110);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 6;
            label4.Text = "Ventas por empleado";
            // 
            // label5
            // 
            label5.Location = new Point(863, 136);
            label5.Name = "label5";
            label5.Size = new Size(398, 64);
            label5.TabIndex = 9;
            label5.Text = "Destaca los productos con mayor rotación según la cantidad vendida.\nAyuda a decidir compras, reposición y estrategias comerciales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(863, 110);
            label6.Name = "label6";
            label6.Size = new Size(175, 15);
            label6.TabIndex = 8;
            label6.Text = "Top 10 productos más vendidos";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 568);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(topProductsChart);
            Controls.Add(salesByEmployeeChart);
            Controls.Add(salesByDateChart);
            Controls.Add(filtersPanel);
            Name = "Sales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            Load += Sales_Load;
            filtersPanel.ResumeLayout(false);
            filtersTable.ResumeLayout(false);
            filtersTable.PerformLayout();
            actionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)salesByDateChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesByEmployeeChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)topProductsChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel filtersPanel;
        private TableLayoutPanel filtersTable;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private FlowLayoutPanel actionsPanel;
        private Button btnApplyFilters;
        private Button btnClearFilters;

        private System.Windows.Forms.DataVisualization.Charting.Chart salesByDateChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesByEmployeeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart topProductsChart;
        private Label label1;
        public Label label2;
        public Label label3;
        private Label label4;
        public Label label5;
        private Label label6;
    }
}
