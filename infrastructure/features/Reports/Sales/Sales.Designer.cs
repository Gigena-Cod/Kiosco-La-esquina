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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.filtersPanel = new Panel();
            this.filtersTable = new TableLayoutPanel();
            this.lblFrom = new Label();
            this.dtpFrom = new DateTimePicker();
            this.lblTo = new Label();
            this.dtpTo = new DateTimePicker();
            this.lblEmployee = new Label();
            this.cboEmployee = new ComboBox();
            this.lblProduct = new Label();
            this.cboProduct = new ComboBox();
            this.actionsPanel = new FlowLayoutPanel();
            this.btnApplyFilters = new Button();
            this.btnClearFilters = new Button();
            this.salesByDateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesByEmployeeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.topProductsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.filtersPanel.SuspendLayout();
            this.filtersTable.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesByDateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByEmployeeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topProductsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // filtersPanel
            // 
            this.filtersPanel.Controls.Add(this.filtersTable);
            this.filtersPanel.Controls.Add(this.actionsPanel);
            this.filtersPanel.Dock = DockStyle.Top;
            this.filtersPanel.Location = new Point(0, 0);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new Size(1258, 90);
            this.filtersPanel.TabIndex = 0;
            // 
            // filtersTable
            // 
            this.filtersTable.ColumnCount = 4;
            this.filtersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.filtersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.filtersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.filtersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.filtersTable.Controls.Add(this.lblFrom, 0, 0);
            this.filtersTable.Controls.Add(this.dtpFrom, 1, 0);
            this.filtersTable.Controls.Add(this.lblTo, 2, 0);
            this.filtersTable.Controls.Add(this.dtpTo, 3, 0);
            this.filtersTable.Controls.Add(this.lblEmployee, 0, 1);
            this.filtersTable.Controls.Add(this.cboEmployee, 1, 1);
            this.filtersTable.Controls.Add(this.lblProduct, 2, 1);
            this.filtersTable.Controls.Add(this.cboProduct, 3, 1);
            this.filtersTable.Dock = DockStyle.Fill;
            this.filtersTable.Location = new Point(0, 0);
            this.filtersTable.Name = "filtersTable";
            this.filtersTable.RowCount = 2;
            this.filtersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.filtersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.filtersTable.Size = new Size(1038, 90);
            this.filtersTable.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = AnchorStyles.Left;
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new Point(3, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new Size(73, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Fecha desde";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.dtpFrom.Format = DateTimePickerFormat.Short;
            this.dtpFrom.Location = new Point(262, 11);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new Size(253, 23);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = AnchorStyles.Left;
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new Point(521, 15);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new Size(67, 15);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Fecha hasta";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.dtpTo.Format = DateTimePickerFormat.Short;
            this.dtpTo.Location = new Point(780, 11);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new Size(255, 23);
            this.dtpTo.TabIndex = 3;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = AnchorStyles.Left;
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new Point(3, 57);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new Size(60, 15);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "Empleado";
            // 
            // cboEmployee
            // 
            this.cboEmployee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.cboEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new Point(262, 53);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new Size(253, 23);
            this.cboEmployee.TabIndex = 5;
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = AnchorStyles.Left;
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new Point(521, 57);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new Size(57, 15);
            this.lblProduct.TabIndex = 6;
            this.lblProduct.Text = "Producto";
            // 
            // cboProduct
            // 
            this.cboProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new Point(780, 53);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new Size(255, 23);
            this.cboProduct.TabIndex = 7;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.btnApplyFilters);
            this.actionsPanel.Controls.Add(this.btnClearFilters);
            this.actionsPanel.Dock = DockStyle.Right;
            this.actionsPanel.FlowDirection = FlowDirection.RightToLeft;
            this.actionsPanel.Location = new Point(1038, 0);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Padding = new Padding(5, 15, 5, 5);
            this.actionsPanel.Size = new Size(220, 90);
            this.actionsPanel.TabIndex = 1;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Location = new Point(112, 18);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new Size(100, 30);
            this.btnApplyFilters.TabIndex = 0;
            this.btnApplyFilters.Text = "Aplicar filtros";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new Point(6, 18);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new Size(100, 30);
            this.btnClearFilters.TabIndex = 1;
            this.btnClearFilters.Text = "Limpiar";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // salesByDateChart
            // 
            chartArea4.Name = "ChartArea1";
            this.salesByDateChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.salesByDateChart.Legends.Add(legend4);
            this.salesByDateChart.Location = new Point(12, 220);
            this.salesByDateChart.Name = "salesByDateChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.salesByDateChart.Series.Add(series4);
            this.salesByDateChart.Size = new Size(377, 300);
            this.salesByDateChart.TabIndex = 1;
            this.salesByDateChart.Text = "salesByDateChart";
            // 
            // salesByEmployeeChart
            // 
            chartArea5.Name = "ChartArea1";
            this.salesByEmployeeChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.salesByEmployeeChart.Legends.Add(legend5);
            this.salesByEmployeeChart.Location = new Point(438, 220);
            this.salesByEmployeeChart.Name = "salesByEmployeeChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.salesByEmployeeChart.Series.Add(series5);
            this.salesByEmployeeChart.Size = new Size(377, 300);
            this.salesByEmployeeChart.TabIndex = 2;
            this.salesByEmployeeChart.Text = "salesByEmployeeChart";
            // 
            // topProductsChart
            // 
            chartArea6.Name = "ChartArea1";
            this.topProductsChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.topProductsChart.Legends.Add(legend6);
            this.topProductsChart.Location = new Point(863, 220);
            this.topProductsChart.Name = "topProductsChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.topProductsChart.Series.Add(series6);
            this.topProductsChart.Size = new Size(377, 300);
            this.topProductsChart.TabIndex = 3;
            this.topProductsChart.Text = "topProductsChart";
            // 
            // labels títulos/descripciones
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new Size(112, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evolución de ventas";
            // 
            this.label2.Location = new Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new Size(398, 64);
            this.label2.TabIndex = 5;
            this.label2.Text = "Muestra cómo varían las ventas dentro del rango de fechas seleccionado.\nIdeal para identificar tendencias, picos y caídas de facturación";
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(438, 110);
            this.label4.Name = "label4";
            this.label4.Size = new Size(118, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ventas por empleado";
            // 
            this.label3.Location = new Point(438, 136);
            this.label3.Name = "label3";
            this.label3.Size = new Size(398, 64);
            this.label3.TabIndex = 7;
            this.label3.Text = "Compara cuánto vende cada miembro del equipo en el período elegido.\nÚtil para medir rendimiento individual y detectar diferencias marcadas";
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(863, 110);
            this.label6.Name = "label6";
            this.label6.Size = new Size(175, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Top 10 productos más vendidos";
            // 
            this.label5.Location = new Point(863, 136);
            this.label5.Name = "label5";
            this.label5.Size = new Size(398, 64);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destaca los productos con mayor rotación según la cantidad vendida.\nAyuda a decidir compras, reposición y estrategias comerciales";
            // 
            // Sales form
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1258, 568);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topProductsChart);
            this.Controls.Add(this.salesByEmployeeChart);
            this.Controls.Add(this.salesByDateChart);
            this.Controls.Add(this.filtersPanel);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.filtersPanel.ResumeLayout(false);
            this.filtersTable.ResumeLayout(false);
            this.filtersTable.PerformLayout();
            this.actionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesByDateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByEmployeeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topProductsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Panel filtersPanel;
        private TableLayoutPanel filtersTable;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Label lblEmployee;
        private ComboBox cboEmployee;
        private Label lblProduct;
        private ComboBox cboProduct;
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
