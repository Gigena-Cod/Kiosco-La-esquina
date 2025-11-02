namespace Kiosco_La_esquina.infrastructure.features.Supplier.SupplierVisualizationFlow
{
    partial class SupplierVisualizationFlow
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
            dataGridViewSuppliers = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnIdentifier = new DataGridViewTextBoxColumn();
            ColumnMail = new DataGridViewTextBoxColumn();
            ColumnRole = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnSalary = new DataGridViewTextBoxColumn();
            buttonExportSupplier = new Button();
            searchTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Columns.AddRange(new DataGridViewColumn[] { FirstName, ColumnLastName, ColumnIdentifier, ColumnMail, ColumnRole, ColumnDate, ColumnSalary });
            dataGridViewSuppliers.Location = new Point(13, 116);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.Size = new Size(777, 324);
            dataGridViewSuppliers.TabIndex = 9;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Nombre";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // ColumnLastName
            // 
            ColumnLastName.HeaderText = "Apellido";
            ColumnLastName.Name = "ColumnLastName";
            ColumnLastName.ReadOnly = true;
            // 
            // ColumnIdentifier
            // 
            ColumnIdentifier.HeaderText = "Dni";
            ColumnIdentifier.Name = "ColumnIdentifier";
            // 
            // ColumnMail
            // 
            ColumnMail.HeaderText = "Email";
            ColumnMail.Name = "ColumnMail";
            ColumnMail.ReadOnly = true;
            // 
            // ColumnRole
            // 
            ColumnRole.HeaderText = "Cargo";
            ColumnRole.Name = "ColumnRole";
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Fecha de ingreso";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnSalary
            // 
            ColumnSalary.HeaderText = "Salario";
            ColumnSalary.Name = "ColumnSalary";
            ColumnSalary.ReadOnly = true;
            // 
            // buttonExportSupplier
            // 
            buttonExportSupplier.Location = new Point(670, 56);
            buttonExportSupplier.Name = "buttonExportSupplier";
            buttonExportSupplier.Size = new Size(120, 35);
            buttonExportSupplier.TabIndex = 8;
            buttonExportSupplier.Text = "Exportar";
            buttonExportSupplier.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(13, 68);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(242, 23);
            searchTextBox.TabIndex = 7;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 50);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Buscar";
            // 
            // label1
            // 
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(745, 39);
            label1.TabIndex = 5;
            label1.Text = "Lista de proveedores registrados. Use los filtros o la búsqueda para encontrar un proveedor rápidamente";
            label1.Click += label1_Click;
            // 
            // SupplierVisualizationFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSuppliers);
            Controls.Add(buttonExportSupplier);
            Controls.Add(searchTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SupplierVisualizationFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de proveedores";
            Load += SupplierVisualizationFlow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSuppliers;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnIdentifier;
        private DataGridViewTextBoxColumn ColumnMail;
        private DataGridViewTextBoxColumn ColumnRole;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnSalary;
        private Button buttonExportSupplier;
        private TextBox searchTextBox;
        private Label label2;
        private Label label1;
    }
}