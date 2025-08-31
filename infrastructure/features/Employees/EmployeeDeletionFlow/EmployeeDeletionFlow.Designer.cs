namespace Kiosco_La_esquina.infrastructure.features.Employees.EmployeeDeletionFlow
{
    partial class EmployeeDeletionFlow
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
            comboBoxEmpleado = new ComboBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            buttonEliminar = new Button();
            buttonCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(458, 36);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el empleado que desea eliminar del sistema. Esta acción no se puede deshacer. Confirme antes de proceder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleado";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(12, 78);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(223, 23);
            comboBoxEmpleado.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(10, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 145);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del empleado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 85);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(235, 103);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(219, 23);
            textBox3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 85);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 8;
            label6.Text = "Dni";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 103);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(219, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 27);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellido";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(235, 45);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 27);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 45);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(245, 280);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(109, 35);
            buttonEliminar.TabIndex = 5;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(126, 280);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(109, 35);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // EmployeeDeletionFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 330);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEliminar);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EmployeeDeletionFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar empleado";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxEmpleado;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Button buttonEliminar;
        private Button buttonCancelar;
    }
}