namespace Kiosco_La_esquina.infrastructure.features.Sales.SalesVisualizationFlow
{
    partial class SalesVisualizationFlow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesVisualizationFlow));
            groupBox1 = new GroupBox();
            label7 = new Label();
            comboBoxEmployee = new ComboBox();
            dateTimePickerTo = new DateTimePicker();
            button4 = new Button();
            buttonFilter = new Button();
            label6 = new Label();
            label5 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            dataGridViewSales = new DataGridView();
            saleCode = new DataGridViewTextBoxColumn();
            saleDate = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            saleTotal = new DataGridViewTextBoxColumn();
            searchTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            productName = new DataGridViewTextBoxColumn();
            productQuantity = new DataGridViewTextBoxColumn();
            productPrice = new DataGridViewTextBoxColumn();
            productSubtotal = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBoxEmployee);
            groupBox1.Controls.Add(dateTimePickerTo);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(buttonFilter);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePickerFrom);
            groupBox1.Controls.Add(dataGridViewSales);
            groupBox1.Controls.Add(searchTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(838, 588);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de ventas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 72);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 23;
            label7.Text = "Empleado";
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(130, 93);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(212, 23);
            comboBoxEmployee.TabIndex = 22;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(482, 93);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(107, 23);
            dateTimePickerTo.TabIndex = 21;
            // 
            // button4
            // 
            button4.Location = new Point(721, 83);
            button4.Name = "button4";
            button4.Size = new Size(108, 35);
            button4.TabIndex = 20;
            button4.Text = "Limpiar ";
            button4.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(607, 83);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(108, 35);
            buttonFilter.TabIndex = 17;
            buttonFilter.Text = "Buscar";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(482, 72);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 18;
            label6.Text = "Hasta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 72);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 16;
            label5.Text = "Desde";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(359, 93);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(107, 23);
            dateTimePickerFrom.TabIndex = 15;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Columns.AddRange(new DataGridViewColumn[] { saleCode, saleDate, EmployeeName, saleTotal });
            dataGridViewSales.Location = new Point(9, 138);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.Size = new Size(821, 429);
            dataGridViewSales.TabIndex = 14;
            // 
            // saleCode
            // 
            saleCode.HeaderText = "N° de Venta";
            saleCode.Name = "saleCode";
            // 
            // saleDate
            // 
            saleDate.HeaderText = "Fecha";
            saleDate.Name = "saleDate";
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "Empleado";
            EmployeeName.Name = "EmployeeName";
            // 
            // saleTotal
            // 
            saleTotal.HeaderText = "Total";
            saleTotal.Name = "saleTotal";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(8, 93);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(107, 23);
            searchTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 72);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 11;
            label2.Text = "N° Venta ";
            // 
            // label1
            // 
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(562, 24);
            label1.TabIndex = 10;
            label1.Text = "Filtrá las ventas por fecha o cliente y seleccioná una para ver el detalle";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(869, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 588);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de la venta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productName, productQuantity, productPrice, productSubtotal });
            dataGridView1.Location = new Point(8, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(411, 429);
            dataGridView1.TabIndex = 14;
            // 
            // productName
            // 
            productName.HeaderText = "Producto";
            productName.Name = "productName";
            // 
            // productQuantity
            // 
            productQuantity.HeaderText = "Cantidad";
            productQuantity.Name = "productQuantity";
            // 
            // productPrice
            // 
            productPrice.HeaderText = "Precio unitario";
            productPrice.Name = "productPrice";
            // 
            // productSubtotal
            // 
            productSubtotal.HeaderText = "Subtotal";
            productSubtotal.Name = "productSubtotal";
            // 
            // label4
            // 
            label4.Location = new Point(6, 33);
            label4.Name = "label4";
            label4.Size = new Size(361, 36);
            label4.TabIndex = 10;
            label4.Text = "Lista de proveedores registrados. Use los filtros o la búsqueda para encontrar un proveedor rápidamente";
            // 
            // label3
            // 
            label3.Location = new Point(20, 12);
            label3.Name = "label3";
            label3.Size = new Size(731, 61);
            label3.TabIndex = 15;
            label3.Text = resources.GetString("label3.Text");
            // 
            // button1
            // 
            button1.Location = new Point(812, 12);
            button1.Name = "button1";
            button1.Size = new Size(162, 35);
            button1.TabIndex = 15;
            button1.Text = "Registrar nueva venta";
            button1.UseVisualStyleBackColor = true;
            // 
            // SalesVisualizationFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 694);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SalesVisualizationFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualización de ventas";
            Load += SalesVisualizationFlow_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewSales;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button button4;
        private Button buttonFilter;
        private Label label7;
        private ComboBox comboBoxEmployee;
        private TextBox searchTextBox;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productQuantity;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewTextBoxColumn productSubtotal;
        private DataGridViewTextBoxColumn saleCode;
        private DataGridViewTextBoxColumn saleDate;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn saleTotal;
    }
}