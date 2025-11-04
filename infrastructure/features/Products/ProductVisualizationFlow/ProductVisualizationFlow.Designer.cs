namespace Kiosco_La_esquina.infrastructure.features.Products.ProductVisualizationFlow
{
    partial class ProductVisualizationFlow
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
            dataGridViewProducts = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnIdentifier = new DataGridViewTextBoxColumn();
            ColumnMail = new DataGridViewTextBoxColumn();
            ColumnRole = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnSalary = new DataGridViewTextBoxColumn();
            buttonExportProducts = new Button();
            searchTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { FirstName, ColumnLastName, ColumnIdentifier, ColumnMail, ColumnRole, ColumnDate, ColumnSalary });
            dataGridViewProducts.Location = new Point(13, 116);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(777, 324);
            dataGridViewProducts.TabIndex = 14;
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
            // buttonExportProducts
            // 
            buttonExportProducts.Location = new Point(670, 56);
            buttonExportProducts.Name = "buttonExportProducts";
            buttonExportProducts.Size = new Size(120, 35);
            buttonExportProducts.TabIndex = 13;
            buttonExportProducts.Text = "Exportar";
            buttonExportProducts.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(13, 68);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(242, 23);
            searchTextBox.TabIndex = 12;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 50);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 11;
            label2.Text = "Buscar";
            // 
            // label1
            // 
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(745, 39);
            label1.TabIndex = 10;
            label1.Text = "Use este formulario para consultar los productos existentes en el sistema.\nUtilice el campo de búsqueda para filtrar por nombre o descripción, o presione ‘Exportar’ para guardar la lista actual";
            // 
            // ProductVisualizationFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewProducts);
            Controls.Add(buttonExportProducts);
            Controls.Add(searchTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductVisualizationFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de productos registrados";
            Load += ProductVisualizationFlow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnIdentifier;
        private DataGridViewTextBoxColumn ColumnMail;
        private DataGridViewTextBoxColumn ColumnRole;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnSalary;
        private Button buttonExportProducts;
        private TextBox searchTextBox;
        private Label label2;
        private Label label1;
    }
}