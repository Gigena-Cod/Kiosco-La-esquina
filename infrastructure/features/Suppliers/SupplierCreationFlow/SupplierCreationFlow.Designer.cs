namespace Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierCreationFlow
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
            contactNameLabel = new Label();
            label4 = new Label();
            phoneLabel = new Label();
            nameLabel = new Label();
            addressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            contactNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
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
            groupBox1.Controls.Add(contactNameLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(phoneLabel);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(phoneTextBox);
            groupBox1.Controls.Add(contactNameTextBox);
            groupBox1.Controls.Add(firstNameTextBox);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 136);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos personales";
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new Point(230, 19);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new Size(117, 15);
            contactNameLabel.TabIndex = 8;
            contactNameLabel.Text = "Nombre de contacto";
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
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(6, 74);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(53, 15);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Telefono";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 24);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Nombre";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(230, 92);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(211, 23);
            addressTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(6, 92);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(211, 23);
            phoneTextBox.TabIndex = 2;
            // 
            // contactNameTextBox
            // 
            contactNameTextBox.Location = new Point(230, 42);
            contactNameTextBox.Name = "contactNameTextBox";
            contactNameTextBox.Size = new Size(211, 23);
            contactNameTextBox.TabIndex = 1;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierCreationFlow";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancel;
        private Button buttonCreate;
        private GroupBox groupBox1; 
        private Label nameLabel;
        private TextBox addressTextBox;
        private TextBox phoneTextBox;
        private TextBox textBoxfirstNameTextBoxLastName;
        private TextBox firstNameTextBox;
        private Label title;
        private Label label4;
        private Label phoneLabel;
        private TextBox contactNameTextBox;
        private Label contactNameLabel;
    }
}