namespace Kiosco_La_esquina
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            nuevaVentaToolStripMenuItem = new ToolStripMenuItem();
            listadoDeVentasDelDíaToolStripMenuItem = new ToolStripMenuItem();
            productoMásVendidoToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            listadoDeProductosToolStripMenuItem = new ToolStripMenuItem();
            agregarProductoToolStripMenuItem = new ToolStripMenuItem();
            modificarProductoToolStripMenuItem = new ToolStripMenuItem();
            eliminarProductoToolStripMenuItem = new ToolStripMenuItem();
            controlDeStockMínimoToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            listadoDeProveedoresToolStripMenuItem = new ToolStripMenuItem();
            agregarProveedorToolStripMenuItem = new ToolStripMenuItem();
            modificarProveedorToolStripMenuItem = new ToolStripMenuItem();
            eliminarProveedorToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            listadoDeEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            agregarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            modificarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            eliminarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            manualDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, stockToolStripMenuItem, proveedoresToolStripMenuItem, empleadosToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaVentaToolStripMenuItem, listadoDeVentasDelDíaToolStripMenuItem, productoMásVendidoToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            nuevaVentaToolStripMenuItem.Size = new Size(203, 22);
            nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            // 
            // listadoDeVentasDelDíaToolStripMenuItem
            // 
            listadoDeVentasDelDíaToolStripMenuItem.Name = "listadoDeVentasDelDíaToolStripMenuItem";
            listadoDeVentasDelDíaToolStripMenuItem.Size = new Size(203, 22);
            listadoDeVentasDelDíaToolStripMenuItem.Text = "Listado de ventas del día";
            listadoDeVentasDelDíaToolStripMenuItem.Click += listadoDeVentasDelDíaToolStripMenuItem_Click;
            // 
            // productoMásVendidoToolStripMenuItem
            // 
            productoMásVendidoToolStripMenuItem.Name = "productoMásVendidoToolStripMenuItem";
            productoMásVendidoToolStripMenuItem.Size = new Size(203, 22);
            productoMásVendidoToolStripMenuItem.Text = "Reportes";
            productoMásVendidoToolStripMenuItem.Click += productoMásVendidoToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoDeProductosToolStripMenuItem, agregarProductoToolStripMenuItem, modificarProductoToolStripMenuItem, eliminarProductoToolStripMenuItem, controlDeStockMínimoToolStripMenuItem });
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(48, 20);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            listadoDeProductosToolStripMenuItem.Size = new Size(206, 22);
            listadoDeProductosToolStripMenuItem.Text = "Listado de productos";
            listadoDeProductosToolStripMenuItem.Click += listadoDeProductosToolStripMenuItem_Click;
            // 
            // agregarProductoToolStripMenuItem
            // 
            agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            agregarProductoToolStripMenuItem.Size = new Size(206, 22);
            agregarProductoToolStripMenuItem.Text = "Agregar producto";
            agregarProductoToolStripMenuItem.Click += agregarProductoToolStripMenuItem_Click;
            // 
            // modificarProductoToolStripMenuItem
            // 
            modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            modificarProductoToolStripMenuItem.Size = new Size(206, 22);
            modificarProductoToolStripMenuItem.Text = "Modificar producto";
            modificarProductoToolStripMenuItem.Click += modificarProductoToolStripMenuItem_Click;
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(206, 22);
            eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            eliminarProductoToolStripMenuItem.Click += eliminarProductoToolStripMenuItem_Click;
            // 
            // controlDeStockMínimoToolStripMenuItem
            // 
            controlDeStockMínimoToolStripMenuItem.Name = "controlDeStockMínimoToolStripMenuItem";
            controlDeStockMínimoToolStripMenuItem.Size = new Size(206, 22);
            controlDeStockMínimoToolStripMenuItem.Text = "Control de stock mínimo";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoDeProveedoresToolStripMenuItem, agregarProveedorToolStripMenuItem, modificarProveedorToolStripMenuItem, eliminarProveedorToolStripMenuItem });
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(84, 20);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // listadoDeProveedoresToolStripMenuItem
            // 
            listadoDeProveedoresToolStripMenuItem.Name = "listadoDeProveedoresToolStripMenuItem";
            listadoDeProveedoresToolStripMenuItem.Size = new Size(196, 22);
            listadoDeProveedoresToolStripMenuItem.Text = "Listado de proveedores";
            listadoDeProveedoresToolStripMenuItem.Click += listadoDeProveedoresToolStripMenuItem_Click;
            // 
            // agregarProveedorToolStripMenuItem
            // 
            agregarProveedorToolStripMenuItem.Name = "agregarProveedorToolStripMenuItem";
            agregarProveedorToolStripMenuItem.Size = new Size(196, 22);
            agregarProveedorToolStripMenuItem.Text = "Agregar proveedor";
            agregarProveedorToolStripMenuItem.Click += agregarProveedorToolStripMenuItem_Click;
            // 
            // modificarProveedorToolStripMenuItem
            // 
            modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
            modificarProveedorToolStripMenuItem.Size = new Size(196, 22);
            modificarProveedorToolStripMenuItem.Text = "Modificar proveedor";
            modificarProveedorToolStripMenuItem.Click += modificarProveedorToolStripMenuItem_Click;
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            eliminarProveedorToolStripMenuItem.Size = new Size(196, 22);
            eliminarProveedorToolStripMenuItem.Text = "Eliminar proveedor";
            eliminarProveedorToolStripMenuItem.Click += eliminarProveedorToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoDeEmpleadosToolStripMenuItem, agregarEmpleadoToolStripMenuItem, modificarEmpleadoToolStripMenuItem, eliminarEmpleadoToolStripMenuItem });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // listadoDeEmpleadosToolStripMenuItem
            // 
            listadoDeEmpleadosToolStripMenuItem.Name = "listadoDeEmpleadosToolStripMenuItem";
            listadoDeEmpleadosToolStripMenuItem.Size = new Size(189, 22);
            listadoDeEmpleadosToolStripMenuItem.Text = "Listado de empleados";
            listadoDeEmpleadosToolStripMenuItem.Click += listadoDeEmpleadosToolStripMenuItem_Click;
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            agregarEmpleadoToolStripMenuItem.Size = new Size(189, 22);
            agregarEmpleadoToolStripMenuItem.Text = "Agregar empleado";
            agregarEmpleadoToolStripMenuItem.Click += agregarEmpleadoToolStripMenuItem_Click;
            // 
            // modificarEmpleadoToolStripMenuItem
            // 
            modificarEmpleadoToolStripMenuItem.Name = "modificarEmpleadoToolStripMenuItem";
            modificarEmpleadoToolStripMenuItem.Size = new Size(189, 22);
            modificarEmpleadoToolStripMenuItem.Text = "Modificar empleado";
            modificarEmpleadoToolStripMenuItem.Click += modificarEmpleadoToolStripMenuItem_Click;
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            eliminarEmpleadoToolStripMenuItem.Size = new Size(189, 22);
            eliminarEmpleadoToolStripMenuItem.Text = "Eliminar empleado";
            eliminarEmpleadoToolStripMenuItem.Click += eliminarEmpleadoToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDeUsuarioToolStripMenuItem, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            manualDeUsuarioToolStripMenuItem.Size = new Size(172, 22);
            manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(172, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiosco | La Esquina";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private ToolStripMenuItem listadoDeVentasDelDíaToolStripMenuItem;
        private ToolStripMenuItem productoMásVendidoToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ToolStripMenuItem modificarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private ToolStripMenuItem controlDeStockMínimoToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem listadoDeProveedoresToolStripMenuItem;
        private ToolStripMenuItem agregarProveedorToolStripMenuItem;
        private ToolStripMenuItem modificarProveedorToolStripMenuItem;
        private ToolStripMenuItem eliminarProveedorToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem listadoDeEmpleadosToolStripMenuItem;
        private ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem modificarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
    }
}
