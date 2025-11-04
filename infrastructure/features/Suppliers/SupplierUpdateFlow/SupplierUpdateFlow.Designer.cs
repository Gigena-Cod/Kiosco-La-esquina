namespace Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierUpdateFlow
{
    partial class SupplierUpdateFlow
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
            buttonCancel = new Button();
            buttonUpdate = new Button();
            groupBox1 = new GroupBox();
            label = new Label();
            addressTextBox = new TextBox();
            phoneLabel = new Label();
            phoneTextBox = new TextBox();
            label4 = new Label();
            contactNameTextBox = new TextBox();
            label3 = new Label();
            nameTextBox = new TextBox();
            comboBoxSuppliers = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(126, 280);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 35);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(245, 280);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(109, 35);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Actualizar";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(phoneLabel);
            groupBox1.Controls.Add(phoneTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(contactNameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Location = new Point(10, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 145);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del empleado";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(231, 85);
            label.Name = "label";
            label.Size = new Size(57, 15);
            label.TabIndex = 10;
            label.Text = "Direccion";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(235, 103);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(219, 23);
            addressTextBox.TabIndex = 9;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(6, 85);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(53, 15);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Telefono";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(6, 103);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(219, 23);
            phoneTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 27);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre de contacto";
            // 
            // contactNameTextBox
            // 
            contactNameTextBox.Location = new Point(235, 45);
            contactNameTextBox.Name = "contactNameTextBox";
            contactNameTextBox.Size = new Size(219, 23);
            contactNameTextBox.TabIndex = 5;
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
            // nameTextBox
            // 
            nameTextBox.Location = new Point(6, 45);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(219, 23);
            nameTextBox.TabIndex = 0;
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Location = new Point(12, 78);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(223, 23);
            comboBoxSuppliers.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 60);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 14;
            label2.Text = "Proveedores";
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(458, 51);
            label1.TabIndex = 13;
            label1.Text = "Modifique los datos del proveedor seleccionado y presione ‘Actualizar’ para guardar los cambios.\nAsegúrese de revisar todos los campos antes de confirmar la actualización";
            // 
            // SupplierUpdateFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 322);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxSuppliers);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SupplierUpdateFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualización de proveedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonUpdate;
        private GroupBox groupBox1;
        private Label label;
        private TextBox addressTextBox;
        private Label phoneLabel;
        private TextBox phoneTextBox;
        private Label label4;
        private TextBox contactNameTextBox;
        private Label label3;
        private TextBox nameTextBox;
        private ComboBox comboBoxSuppliers;
        private Label label2;
        private Label label1;
    }
}