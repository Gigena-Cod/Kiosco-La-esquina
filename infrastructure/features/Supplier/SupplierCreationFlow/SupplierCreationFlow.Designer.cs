namespace Kiosco_La_esquina.infrastructure.features.Supplier.SupplierCreationFlow
{
    partial class SupplierCreationFlow
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
            buttonCreate = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            phoneTextBox = new Label();
            contactNameTextBox = new Label();
            nameTextBox = new Label();
            textBoxEmail = new TextBox();
            textBoxIdentifier = new TextBox();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            title = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(120, 214);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 35);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(242, 214);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(109, 35);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Crear";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(phoneTextBox);
            groupBox1.Controls.Add(contactNameTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxIdentifier);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Location = new Point(12, 61);
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
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // phoneTextBox
            // 
            phoneTextBox.AutoSize = true;
            phoneTextBox.Location = new Point(6, 74);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(53, 15);
            phoneTextBox.TabIndex = 6;
            phoneTextBox.Text = "Telefono";
            // 
            // contactNameTextBox
            // 
            contactNameTextBox.AutoSize = true;
            contactNameTextBox.Location = new Point(230, 24);
            contactNameTextBox.Name = "contactNameTextBox";
            contactNameTextBox.Size = new Size(117, 15);
            contactNameTextBox.TabIndex = 5;
            contactNameTextBox.Text = "Nombre de contacto";
            // 
            // nameTextBox
            // 
            nameTextBox.AutoSize = true;
            nameTextBox.Location = new Point(6, 24);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(51, 15);
            nameTextBox.TabIndex = 4;
            nameTextBox.Text = "Nombre";
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
            // title
            // 
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(454, 39);
            title.TabIndex = 5;
            title.Text = "Use este formulario para registrar nuevos proveedores en el sistema. Complete todos los campos obligatorios y presione 'Agregar Proveedor' para añadirlos a la lista";
            // 
            // SupplierCreationFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 265);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(groupBox1);
            Controls.Add(title);
            Name = "SupplierCreationFlow";
            Text = "SupplierCreationFlow";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancel;
        private Button buttonCreate;
        private GroupBox groupBox1;
        private Label label4;
        private Label phoneTextBox;
        private Label contactNameTextBox;
        private Label nameTextBox;
        private TextBox textBoxEmail;
        private TextBox textBoxIdentifier;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private Label title;
    }
}