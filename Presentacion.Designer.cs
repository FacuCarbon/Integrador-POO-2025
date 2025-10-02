namespace Integrador
{
    partial class Form_principal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            menuStrip1 = new MenuStrip();
            MenuItem_archivo = new ToolStripMenuItem();
            MenuItem_salir = new ToolStripMenuItem();
            tab_principal = new TabControl();
            tab_productos = new TabPage();
            label1 = new Label();
            boton_crear_producto = new Button();
            title_productos_listado = new Label();
            grid_listado_productos = new DataGridView();
            Columna_producto_nombre = new DataGridViewTextBoxColumn();
            Columna_producto_descripcion = new DataGridViewTextBoxColumn();
            Columna_producto_precioCosto = new DataGridViewTextBoxColumn();
            Columna_producto_precioBruto = new DataGridViewTextBoxColumn();
            Columna_producto_precioVenta = new DataGridViewTextBoxColumn();
            Columna_producto_margen = new DataGridViewTextBoxColumn();
            Columna_producto_iva = new DataGridViewTextBoxColumn();
            Columna_producto_proveedor = new DataGridViewTextBoxColumn();
            Columna_producto_categoria = new DataGridViewTextBoxColumn();
            Columna_producto_subCategoria = new DataGridViewTextBoxColumn();
            tab_vendedores = new TabPage();
            label2 = new Label();
            grid_listado_vendedores = new DataGridView();
            Columna_vendedor_nombre = new DataGridViewTextBoxColumn();
            Columna_vendedor_apellido = new DataGridViewTextBoxColumn();
            Columna_vendedor_dni = new DataGridViewTextBoxColumn();
            Columna_vendedor_cuit = new DataGridViewTextBoxColumn();
            boton_crear_vendedor = new Button();
            title_vendedores_listado = new Label();
            tab_clientes = new TabPage();
            tab_empresas = new TabPage();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            tab_principal.SuspendLayout();
            tab_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_listado_productos).BeginInit();
            tab_vendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_listado_vendedores).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItem_archivo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1054, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem_archivo
            // 
            MenuItem_archivo.DropDownItems.AddRange(new ToolStripItem[] { MenuItem_salir });
            MenuItem_archivo.Name = "MenuItem_archivo";
            MenuItem_archivo.Size = new Size(60, 20);
            MenuItem_archivo.Text = "Archivo";
            // 
            // MenuItem_salir
            // 
            MenuItem_salir.Name = "MenuItem_salir";
            MenuItem_salir.ShortcutKeys = Keys.Alt | Keys.F4;
            MenuItem_salir.Size = new Size(138, 22);
            MenuItem_salir.Text = "Salir";
            MenuItem_salir.Click += Event_menuItem_salir;
            // 
            // tab_principal
            // 
            tab_principal.Controls.Add(tab_productos);
            tab_principal.Controls.Add(tab_vendedores);
            tab_principal.Controls.Add(tab_clientes);
            tab_principal.Controls.Add(tab_empresas);
            tab_principal.Dock = DockStyle.Fill;
            tab_principal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_principal.ImageList = imageList1;
            tab_principal.Location = new Point(0, 24);
            tab_principal.Name = "tab_principal";
            tab_principal.SelectedIndex = 0;
            tab_principal.Size = new Size(1054, 426);
            tab_principal.SizeMode = TabSizeMode.Fixed;
            tab_principal.TabIndex = 1;
            // 
            // tab_productos
            // 
            tab_productos.BackgroundImage = Properties.Resources.Background2;
            tab_productos.BackgroundImageLayout = ImageLayout.Stretch;
            tab_productos.Controls.Add(label1);
            tab_productos.Controls.Add(boton_crear_producto);
            tab_productos.Controls.Add(title_productos_listado);
            tab_productos.Controls.Add(grid_listado_productos);
            tab_productos.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_productos.ImageKey = "Productos.ico";
            tab_productos.Location = new Point(4, 24);
            tab_productos.Name = "tab_productos";
            tab_productos.Padding = new Padding(3);
            tab_productos.Size = new Size(1046, 398);
            tab_productos.TabIndex = 0;
            tab_productos.Text = "Productos";
            tab_productos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(395, 198);
            label1.Name = "label1";
            label1.Size = new Size(288, 16);
            label1.TabIndex = 3;
            label1.Text = "Actualmente no hay productos para mostrar.";
            // 
            // boton_crear_producto
            // 
            boton_crear_producto.BackgroundImageLayout = ImageLayout.None;
            boton_crear_producto.FlatAppearance.BorderSize = 0;
            boton_crear_producto.FlatStyle = FlatStyle.Flat;
            boton_crear_producto.ForeColor = Color.Transparent;
            boton_crear_producto.Image = Properties.Resources.Button_add;
            boton_crear_producto.Location = new Point(943, 11);
            boton_crear_producto.Name = "boton_crear_producto";
            boton_crear_producto.Size = new Size(100, 50);
            boton_crear_producto.TabIndex = 2;
            boton_crear_producto.UseVisualStyleBackColor = true;
            boton_crear_producto.Click += boton_crear_producto_Click;
            // 
            // title_productos_listado
            // 
            title_productos_listado.AutoSize = true;
            title_productos_listado.Font = new Font("Arial Black", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            title_productos_listado.ForeColor = Color.White;
            title_productos_listado.Location = new Point(8, 21);
            title_productos_listado.Name = "title_productos_listado";
            title_productos_listado.Size = new Size(149, 33);
            title_productos_listado.TabIndex = 1;
            title_productos_listado.Text = "Productos";
            // 
            // grid_listado_productos
            // 
            grid_listado_productos.AllowUserToAddRows = false;
            grid_listado_productos.AllowUserToOrderColumns = true;
            grid_listado_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_listado_productos.BackgroundColor = Color.White;
            grid_listado_productos.BorderStyle = BorderStyle.None;
            grid_listado_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_listado_productos.Columns.AddRange(new DataGridViewColumn[] { Columna_producto_nombre, Columna_producto_descripcion, Columna_producto_precioCosto, Columna_producto_precioBruto, Columna_producto_precioVenta, Columna_producto_margen, Columna_producto_iva, Columna_producto_proveedor, Columna_producto_categoria, Columna_producto_subCategoria });
            grid_listado_productos.Location = new Point(3, 67);
            grid_listado_productos.Name = "grid_listado_productos";
            grid_listado_productos.Size = new Size(1043, 328);
            grid_listado_productos.TabIndex = 0;
            // 
            // Columna_producto_nombre
            // 
            Columna_producto_nombre.HeaderText = "Nombre";
            Columna_producto_nombre.Name = "Columna_producto_nombre";
            Columna_producto_nombre.ReadOnly = true;
            // 
            // Columna_producto_descripcion
            // 
            Columna_producto_descripcion.HeaderText = "Descripción";
            Columna_producto_descripcion.Name = "Columna_producto_descripcion";
            // 
            // Columna_producto_precioCosto
            // 
            Columna_producto_precioCosto.HeaderText = "Precio costo";
            Columna_producto_precioCosto.Name = "Columna_producto_precioCosto";
            Columna_producto_precioCosto.ReadOnly = true;
            // 
            // Columna_producto_precioBruto
            // 
            Columna_producto_precioBruto.HeaderText = "Precio bruto";
            Columna_producto_precioBruto.Name = "Columna_producto_precioBruto";
            Columna_producto_precioBruto.ReadOnly = true;
            // 
            // Columna_producto_precioVenta
            // 
            Columna_producto_precioVenta.HeaderText = "Precio venta";
            Columna_producto_precioVenta.Name = "Columna_producto_precioVenta";
            Columna_producto_precioVenta.ReadOnly = true;
            // 
            // Columna_producto_margen
            // 
            Columna_producto_margen.HeaderText = "Margen";
            Columna_producto_margen.Name = "Columna_producto_margen";
            Columna_producto_margen.ReadOnly = true;
            // 
            // Columna_producto_iva
            // 
            Columna_producto_iva.HeaderText = "Iva";
            Columna_producto_iva.Name = "Columna_producto_iva";
            Columna_producto_iva.ReadOnly = true;
            // 
            // Columna_producto_proveedor
            // 
            Columna_producto_proveedor.HeaderText = "Proveedor";
            Columna_producto_proveedor.Name = "Columna_producto_proveedor";
            Columna_producto_proveedor.ReadOnly = true;
            // 
            // Columna_producto_categoria
            // 
            Columna_producto_categoria.HeaderText = "Categoría";
            Columna_producto_categoria.Name = "Columna_producto_categoria";
            Columna_producto_categoria.ReadOnly = true;
            // 
            // Columna_producto_subCategoria
            // 
            Columna_producto_subCategoria.HeaderText = "Subcategoría";
            Columna_producto_subCategoria.Name = "Columna_producto_subCategoria";
            Columna_producto_subCategoria.ReadOnly = true;
            // 
            // tab_vendedores
            // 
            tab_vendedores.BackgroundImage = Properties.Resources.Background2;
            tab_vendedores.Controls.Add(label2);
            tab_vendedores.Controls.Add(grid_listado_vendedores);
            tab_vendedores.Controls.Add(boton_crear_vendedor);
            tab_vendedores.Controls.Add(title_vendedores_listado);
            tab_vendedores.ImageKey = "Vendedores.ico";
            tab_vendedores.Location = new Point(4, 24);
            tab_vendedores.Name = "tab_vendedores";
            tab_vendedores.Padding = new Padding(3);
            tab_vendedores.Size = new Size(1046, 398);
            tab_vendedores.TabIndex = 1;
            tab_vendedores.Text = "Vendedores";
            tab_vendedores.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(378, 199);
            label2.Name = "label2";
            label2.Size = new Size(300, 16);
            label2.TabIndex = 5;
            label2.Text = "Actualmente no hay vendedores para mostrar.";
            // 
            // grid_listado_vendedores
            // 
            grid_listado_vendedores.AllowUserToAddRows = false;
            grid_listado_vendedores.AllowUserToOrderColumns = true;
            grid_listado_vendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_listado_vendedores.BackgroundColor = Color.White;
            grid_listado_vendedores.BorderStyle = BorderStyle.None;
            grid_listado_vendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_listado_vendedores.Columns.AddRange(new DataGridViewColumn[] { Columna_vendedor_nombre, Columna_vendedor_apellido, Columna_vendedor_dni, Columna_vendedor_cuit });
            grid_listado_vendedores.Location = new Point(2, 66);
            grid_listado_vendedores.Name = "grid_listado_vendedores";
            grid_listado_vendedores.Size = new Size(1044, 328);
            grid_listado_vendedores.TabIndex = 4;
            // 
            // Columna_vendedor_nombre
            // 
            Columna_vendedor_nombre.FillWeight = 102.809486F;
            Columna_vendedor_nombre.HeaderText = "Nombre";
            Columna_vendedor_nombre.Name = "Columna_vendedor_nombre";
            Columna_vendedor_nombre.ReadOnly = true;
            // 
            // Columna_vendedor_apellido
            // 
            Columna_vendedor_apellido.FillWeight = 102.809486F;
            Columna_vendedor_apellido.HeaderText = "Apellido";
            Columna_vendedor_apellido.Name = "Columna_vendedor_apellido";
            Columna_vendedor_apellido.ReadOnly = true;
            // 
            // Columna_vendedor_dni
            // 
            Columna_vendedor_dni.FillWeight = 109.475876F;
            Columna_vendedor_dni.HeaderText = "DNI";
            Columna_vendedor_dni.Name = "Columna_vendedor_dni";
            Columna_vendedor_dni.ReadOnly = true;
            // 
            // Columna_vendedor_cuit
            // 
            Columna_vendedor_cuit.FillWeight = 142.677582F;
            Columna_vendedor_cuit.HeaderText = "Cuit";
            Columna_vendedor_cuit.Name = "Columna_vendedor_cuit";
            Columna_vendedor_cuit.ReadOnly = true;
            // 
            // boton_crear_vendedor
            // 
            boton_crear_vendedor.BackgroundImageLayout = ImageLayout.None;
            boton_crear_vendedor.FlatAppearance.BorderSize = 0;
            boton_crear_vendedor.FlatStyle = FlatStyle.Flat;
            boton_crear_vendedor.ForeColor = Color.Transparent;
            boton_crear_vendedor.Image = Properties.Resources.Button_add;
            boton_crear_vendedor.Location = new Point(940, 11);
            boton_crear_vendedor.Name = "boton_crear_vendedor";
            boton_crear_vendedor.Size = new Size(100, 50);
            boton_crear_vendedor.TabIndex = 3;
            boton_crear_vendedor.UseVisualStyleBackColor = true;
            boton_crear_vendedor.Click += boton_crear_vendedor_Click;
            // 
            // title_vendedores_listado
            // 
            title_vendedores_listado.AutoSize = true;
            title_vendedores_listado.Font = new Font("Arial Black", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            title_vendedores_listado.ForeColor = Color.White;
            title_vendedores_listado.Location = new Point(8, 21);
            title_vendedores_listado.Name = "title_vendedores_listado";
            title_vendedores_listado.Size = new Size(171, 33);
            title_vendedores_listado.TabIndex = 2;
            title_vendedores_listado.Text = "Vendedores";
            // 
            // tab_clientes
            // 
            tab_clientes.ImageKey = "Clientes.ico";
            tab_clientes.Location = new Point(4, 24);
            tab_clientes.Name = "tab_clientes";
            tab_clientes.Size = new Size(1046, 398);
            tab_clientes.TabIndex = 2;
            tab_clientes.Text = "Clientes";
            tab_clientes.UseVisualStyleBackColor = true;
            // 
            // tab_empresas
            // 
            tab_empresas.ImageKey = "Empresas.ico";
            tab_empresas.Location = new Point(4, 24);
            tab_empresas.Name = "tab_empresas";
            tab_empresas.Size = new Size(1046, 398);
            tab_empresas.TabIndex = 3;
            tab_empresas.Text = "Empresas";
            tab_empresas.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Productos.ico");
            imageList1.Images.SetKeyName(1, "Vendedores.ico");
            imageList1.Images.SetKeyName(2, "Clientes.ico");
            imageList1.Images.SetKeyName(3, "Empresas.ico");
            // 
            // Form_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1054, 450);
            Controls.Add(tab_principal);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insumos de computación";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tab_principal.ResumeLayout(false);
            tab_productos.ResumeLayout(false);
            tab_productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_listado_productos).EndInit();
            tab_vendedores.ResumeLayout(false);
            tab_vendedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_listado_vendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItem_archivo;
        private ToolStripMenuItem MenuItem_salir;
        private TabControl tab_principal;
        private TabPage tab_productos;
        private TabPage tab_vendedores;
        private TabPage tab_clientes;
        private TabPage tab_empresas;
        private ImageList imageList1;
        private DataGridView grid_listado_productos;
        private DataGridViewTextBoxColumn Columna_producto_nombre;
        private DataGridViewTextBoxColumn Columna_producto_descripcion;
        private DataGridViewTextBoxColumn Columna_producto_precioCosto;
        private DataGridViewTextBoxColumn Columna_producto_precioBruto;
        private DataGridViewTextBoxColumn Columna_producto_precioVenta;
        private DataGridViewTextBoxColumn Columna_producto_margen;
        private DataGridViewTextBoxColumn Columna_producto_iva;
        private DataGridViewTextBoxColumn Columna_producto_proveedor;
        private DataGridViewTextBoxColumn Columna_producto_categoria;
        private DataGridViewTextBoxColumn Columna_producto_subCategoria;
        private Button boton_crear_producto;
        private Label title_productos_listado;
        private DataGridView grid_listado_vendedores;
        private Button boton_crear_vendedor;
        private Label title_vendedores_listado;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Columna_vendedor_nombre;
        private DataGridViewTextBoxColumn Columna_vendedor_apellido;
        private DataGridViewTextBoxColumn Columna_vendedor_dni;
        private DataGridViewTextBoxColumn Columna_vendedor_cuit;
    }
}
