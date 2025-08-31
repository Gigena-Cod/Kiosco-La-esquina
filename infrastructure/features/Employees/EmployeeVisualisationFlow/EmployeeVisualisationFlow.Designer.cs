namespace Kiosco_La_esquina.infrastructure.features.Employees.EmployeeVisualisationFlow
{
    partial class EmployeeVisualisationFlow
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridViewEmployees = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnIdentifier = new DataGridViewTextBoxColumn();
            ColumnMail = new DataGridViewTextBoxColumn();
            ColumnRole = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnSalary = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(745, 39);
            label1.TabIndex = 0;
            label1.Text = "Lista de empleados registrados. Use los filtros o la búsqueda para encontrar un empleado rápidamente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 48);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(671, 54);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 3;
            button1.Text = "Exportar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { FirstName, ColumnLastName, ColumnIdentifier, ColumnMail, ColumnRole, ColumnDate, ColumnSalary });
            dataGridViewEmployees.Location = new Point(14, 114);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.Size = new Size(777, 324);
            dataGridViewEmployees.TabIndex = 4;
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
            // EmployeeVisualisationFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EmployeeVisualisationFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de empleados";
            Load += EmployeeVisualisationFlow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridViewEmployees;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnIdentifier;
        private DataGridViewTextBoxColumn ColumnMail;
        private DataGridViewTextBoxColumn ColumnRole;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnSalary;
    }
}