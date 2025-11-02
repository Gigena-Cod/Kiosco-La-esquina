namespace Kiosco_La_esquina.infrastructure.features.Employees
{
    partial class EmployeeUpdateFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUpdateFlow));
            buttonCancel = new Button();
            buttonCreate = new Button();
            groupBox2 = new GroupBox();
            hireDatePicker = new DateTimePicker();
            roleComboBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            salaryTextBox = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            emailTextBox = new TextBox();
            identifierTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            title = new Label();
            comboBoxEmpleado = new ComboBox();
            label5 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(120, 430);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 35);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(242, 430);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(109, 35);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Actualizar";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hireDatePicker);
            groupBox2.Controls.Add(roleComboBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(salaryTextBox);
            groupBox2.Location = new Point(12, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 138);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos laborales";
            // 
            // hireDatePicker
            // 
            hireDatePicker.Location = new Point(230, 44);
            hireDatePicker.Name = "hireDatePicker";
            hireDatePicker.Size = new Size(211, 23);
            hireDatePicker.TabIndex = 3;
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(6, 44);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(211, 23);
            roleComboBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 76);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 14;
            label6.Text = "Salario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 26);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 13;
            label7.Text = "Fecha de ingreso";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 26);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 12;
            label8.Text = "Cargo";
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(6, 94);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(211, 23);
            salaryTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(identifierTextBox);
            groupBox1.Controls.Add(lastNameTextBox);
            groupBox1.Controls.Add(firstNameTextBox);
            groupBox1.Location = new Point(12, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 136);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos personales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 74);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "Dni";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 24);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(230, 92);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(211, 23);
            emailTextBox.TabIndex = 3;
            // 
            // identifierTextBox
            // 
            identifierTextBox.Enabled = false;
            identifierTextBox.Location = new Point(6, 92);
            identifierTextBox.Name = "identifierTextBox";
            identifierTextBox.Size = new Size(211, 23);
            identifierTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(230, 42);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(211, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(6, 42);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(211, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // title
            // 
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(454, 50);
            title.TabIndex = 5;
            title.Text = resources.GetString("title.Text");
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(18, 82);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(223, 23);
            comboBoxEmpleado.TabIndex = 11;
            comboBoxEmpleado.SelectedIndexChanged += comboBoxEmpleado_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 64);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "Empleado";
            // 
            // EmployeeUpdateFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 491);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(label5);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(title);
            Name = "EmployeeUpdateFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar empleado";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonCreate;
        private GroupBox groupBox2;
        private DateTimePicker hireDatePicker;
        private ComboBox roleComboBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox salaryTextBox;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox emailTextBox;
        private TextBox identifierTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label title;
        private ComboBox comboBoxEmpleado;
        private Label label5;
    }
}