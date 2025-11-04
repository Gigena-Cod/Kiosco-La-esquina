namespace Kiosco_La_esquina.infrastructure.features.Products.ProductUpdateFlow
{
    partial class ProductUpdateFlow
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
            groupBox2 = new GroupBox();
            supplierComboBox = new ComboBox();
            categoryComboBox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            stockNumericUpDown = new NumericUpDown();
            priceNumericUpDown = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            descriptionTextBox = new TextBox();
            nameTextBox = new TextBox();
            title = new Label();
            comboBoxProduct = new ComboBox();
            label5 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(120, 376);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 35);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(242, 376);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(109, 35);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Actualizar";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(supplierComboBox);
            groupBox2.Controls.Add(categoryComboBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 269);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 91);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos especificos";
            // 
            // supplierComboBox
            // 
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(230, 44);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(211, 23);
            supplierComboBox.TabIndex = 14;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(6, 44);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(211, 23);
            categoryComboBox.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 26);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 13;
            label7.Text = "Proveedor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 26);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 12;
            label8.Text = "Categoría";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stockNumericUpDown);
            groupBox1.Controls.Add(priceNumericUpDown);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(descriptionTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Location = new Point(12, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 136);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos basicos";
            // 
            // stockNumericUpDown
            // 
            stockNumericUpDown.Location = new Point(230, 93);
            stockNumericUpDown.Name = "stockNumericUpDown";
            stockNumericUpDown.Size = new Size(211, 23);
            stockNumericUpDown.TabIndex = 9;
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.Location = new Point(6, 93);
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(211, 23);
            priceNumericUpDown.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 74);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 24);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Descripcion";
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
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(230, 42);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(211, 23);
            descriptionTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(6, 42);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(211, 23);
            nameTextBox.TabIndex = 0;
            // 
            // title
            // 
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(454, 39);
            title.TabIndex = 10;
            title.Text = "Use este formulario para registrar nuevos productos en el sistema. Complete todos los campos obligatorios y presione ‘Agregar Producto’ para añadirlos a la lista";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(12, 74);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(223, 23);
            comboBoxProduct.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 56);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 15;
            label5.Text = "Producto";
            // 
            // ProductUpdateFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 425);
            Controls.Add(comboBoxProduct);
            Controls.Add(label5);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(title);
            Name = "ProductUpdateFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductUpdateFlow";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonUpdate;
        private GroupBox groupBox2;
        private ComboBox supplierComboBox;
        private ComboBox categoryComboBox;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private NumericUpDown stockNumericUpDown;
        private NumericUpDown priceNumericUpDown;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox descriptionTextBox;
        private TextBox nameTextBox;
        private Label title;
        private ComboBox comboBoxProduct;
        private Label label5;
    }
}