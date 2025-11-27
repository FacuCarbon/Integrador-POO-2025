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
            listado_productos = new Integrador.UI.ListadoBase();
            tab_vendedores = new TabPage();
            listado_vendedores = new Integrador.UI.ListadoBase();
            tab_clientes = new TabPage();
            listado_clientes = new Integrador.UI.ListadoBase();
            tab_empresas = new TabPage();
            listado_empresas = new Integrador.UI.ListadoBase();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            tab_principal.SuspendLayout();
            tab_productos.SuspendLayout();
            tab_vendedores.SuspendLayout();
            tab_clientes.SuspendLayout();
            tab_empresas.SuspendLayout();
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
            MenuItem_archivo.Size = new Size(12, 20);
            // 
            // MenuItem_salir
            // 
            MenuItem_salir.Name = "MenuItem_salir";
            MenuItem_salir.ShortcutKeys = Keys.Alt | Keys.F4;
            MenuItem_salir.Size = new Size(180, 22);
            MenuItem_salir.Text = "Salir";
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
            tab_productos.BackgroundImageLayout = ImageLayout.Stretch;
            tab_productos.Controls.Add(listado_productos);
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
            // listado_productos
            // 
            listado_productos.BackColor = Color.MidnightBlue;
            listado_productos.Dock = DockStyle.Fill;
            listado_productos.Location = new Point(3, 3);
            listado_productos.Name = "listado_productos";
            listado_productos.Size = new Size(1040, 392);
            listado_productos.TabIndex = 0;
            listado_productos.TextoBusqueda = "";
            listado_productos.Titulo = "";
            listado_productos.Click += ListadoProductos_BotonCrearClick;
            // 
            // tab_vendedores
            // 
            tab_vendedores.Controls.Add(listado_vendedores);
            tab_vendedores.ImageKey = "Vendedores.ico";
            tab_vendedores.Location = new Point(4, 24);
            tab_vendedores.Name = "tab_vendedores";
            tab_vendedores.Padding = new Padding(3);
            tab_vendedores.Size = new Size(1046, 398);
            tab_vendedores.TabIndex = 1;
            tab_vendedores.Text = "Vendedores";
            tab_vendedores.UseVisualStyleBackColor = true;
            // 
            // listado_vendedores
            // 
            listado_vendedores.BackColor = Color.MidnightBlue;
            listado_vendedores.Dock = DockStyle.Fill;
            listado_vendedores.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            listado_vendedores.Location = new Point(3, 3);
            listado_vendedores.Name = "listado_vendedores";
            listado_vendedores.Size = new Size(1040, 392);
            listado_vendedores.TabIndex = 0;
            listado_vendedores.TextoBusqueda = "";
            listado_vendedores.Titulo = "";
            // 
            // tab_clientes
            // 
            tab_clientes.Controls.Add(listado_clientes);
            tab_clientes.ImageKey = "Clientes.ico";
            tab_clientes.Location = new Point(4, 24);
            tab_clientes.Name = "tab_clientes";
            tab_clientes.Padding = new Padding(3);
            tab_clientes.Size = new Size(1046, 398);
            tab_clientes.TabIndex = 2;
            tab_clientes.Text = "Clientes";
            tab_clientes.UseVisualStyleBackColor = true;
            // 
            // listado_clientes
            // 
            listado_clientes.BackColor = Color.MidnightBlue;
            listado_clientes.Dock = DockStyle.Fill;
            listado_clientes.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            listado_clientes.Location = new Point(3, 3);
            listado_clientes.Name = "listado_clientes";
            listado_clientes.Size = new Size(1040, 392);
            listado_clientes.TabIndex = 0;
            listado_clientes.TextoBusqueda = "";
            listado_clientes.Titulo = "";
            // 
            // tab_empresas
            // 
            tab_empresas.Controls.Add(listado_empresas);
            tab_empresas.ImageKey = "Empresas.ico";
            tab_empresas.Location = new Point(4, 24);
            tab_empresas.Name = "tab_empresas";
            tab_empresas.Padding = new Padding(3);
            tab_empresas.Size = new Size(1046, 398);
            tab_empresas.TabIndex = 3;
            tab_empresas.Text = "Empresas";
            tab_empresas.UseVisualStyleBackColor = true;
            // 
            // listado_empresas
            // 
            listado_empresas.BackColor = Color.MidnightBlue;
            listado_empresas.Dock = DockStyle.Fill;
            listado_empresas.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            listado_empresas.Location = new Point(3, 3);
            listado_empresas.Name = "listado_empresas";
            listado_empresas.Size = new Size(1040, 392);
            listado_empresas.TabIndex = 0;
            listado_empresas.TextoBusqueda = "";
            listado_empresas.Titulo = "";
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Form_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insumos de computación";
            WindowState = FormWindowState.Maximized;
            Load += Form_principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tab_principal.ResumeLayout(false);
            tab_productos.ResumeLayout(false);
            tab_vendedores.ResumeLayout(false);
            tab_clientes.ResumeLayout(false);
            tab_empresas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItem_archivo;
        private ToolStripMenuItem MenuItem_salir;
        private TabControl tab_principal;
        private TabPage tab_clientes;
        private TabPage tab_empresas;
        private ImageList imageList1;
        private TabPage tab_productos;
        private UI.ListadoBase listado_productos;
        private TabPage tab_vendedores;
        private UI.ListadoBase listado_vendedores;
        private UI.ListadoBase listado_clientes;
        private UI.ListadoBase listado_empresas;
    }
}
