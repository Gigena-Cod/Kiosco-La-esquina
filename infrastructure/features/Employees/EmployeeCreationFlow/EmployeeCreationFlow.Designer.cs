namespace Kiosco_La_esquina.infrastructure.features
{
    partial class EmployeeCreationFlow
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
            title = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxEmail = new TextBox();
            textBoxIdentifier = new TextBox();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            groupBox2 = new GroupBox();
            dateTimePickerDate = new DateTimePicker();
            comboBoxRole = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxSalary = new TextBox();
            buttonCreate = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(454, 39);
            title.TabIndex = 0;
            title.Text = "Use este formulario para registrar nuevos empleados en el sistema. Complete todos los campos obligatorios y presione 'Agregar Empleado' para añadirlos a la lista";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxIdentifier);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 136);
            groupBox1.TabIndex = 1;
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
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(230, 92);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(211, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxIdentifier
            // 
            textBoxIdentifier.Location = new Point(6, 92);
            textBoxIdentifier.Name = "textBoxIdentifier";
            textBoxIdentifier.Size = new Size(211, 23);
            textBoxIdentifier.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(230, 42);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(211, 23);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(6, 42);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(211, 23);
            textBoxName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePickerDate);
            groupBox2.Controls.Add(comboBoxRole);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxSalary);
            groupBox2.Location = new Point(12, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 138);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos laborales";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(230, 44);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(211, 23);
            dateTimePickerDate.TabIndex = 3;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(6, 44);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(211, 23);
            comboBoxRole.TabIndex = 3;
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
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(6, 94);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(211, 23);
            textBoxSalary.TabIndex = 10;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(242, 371);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(109, 35);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Crear";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(120, 371);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 35);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // EmployeeCreationFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 418);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(title);
            Name = "EmployeeCreationFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar empleado";
            Load += EmployeeCreationFlow_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private GroupBox groupBox1;
        private TextBox textBoxEmail;
        private TextBox textBoxIdentifier;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePickerDate;
        private ComboBox comboBoxRole;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxSalary;
        private Button buttonCreate;
        private Button buttonCancel;
    }
}