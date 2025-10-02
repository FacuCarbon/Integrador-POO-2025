namespace Integrador
{
    partial class Form_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_producto));
            label1 = new Label();
            label_producto_nombre = new Label();
            label_producto_descripcion = new Label();
            label_producto_precioCosto = new Label();
            label_producto_margen = new Label();
            label_producto_iva = new Label();
            label_producto_precioBruto = new Label();
            label_producto_precioVenta = new Label();
            label_producto_proveedor = new Label();
            label_producto_categoria = new Label();
            label_producto_subCategoria = new Label();
            input_producto_nombre = new TextBox();
            input_producto_descripcion = new TextBox();
            input_producto_precioCosto = new TextBox();
            input_producto_margen = new TextBox();
            input_producto_iva = new TextBox();
            input_producto_precioBruto = new TextBox();
            input_producto_precioVenta = new TextBox();
            input_producto_proveedor = new TextBox();
            select_producto_categoria = new ComboBox();
            select_producto_subCategoria = new ComboBox();
            image_producto = new PictureBox();
            button_cancelar = new Button();
            button_reset = new Button();
            button_guardar = new Button();
            ((System.ComponentModel.ISupportInitialize)image_producto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 0;
            label1.Text = "Datos del producto";
            // 
            // label_producto_nombre
            // 
            label_producto_nombre.AutoSize = true;
            label_producto_nombre.BackColor = Color.Transparent;
            label_producto_nombre.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_producto_nombre.ForeColor = Color.White;
            label_producto_nombre.Location = new Point(282, 87);
            label_producto_nombre.Name = "label_producto_nombre";
            label_producto_nombre.Size = new Size(75, 22);
            label_producto_nombre.TabIndex = 1;
            label_producto_nombre.Text = "Nombre";
            // 
            // label_producto_descripcion
            // 
            label_producto_descripcion.AutoSize = true;
            label_producto_descripcion.BackColor = Color.Transparent;
            label_producto_descripcion.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_producto_descripcion.ForeColor = Color.White;
            label_producto_descripcion.Location = new Point(20, 243);
            label_producto_descripcion.Name = "label_producto_descripcion";
            label_producto_descripcion.Size = new Size(108, 22);
            label_producto_descripcion.TabIndex = 2;
            label_producto_descripcion.Text = "Descripción";
            // 
            // label_producto_precioCosto
            // 
            label_producto_precioCosto.AutoSize = true;
            label_producto_precioCosto.BackColor = Color.Transparent;
            label_producto_precioCosto.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_producto_precioCosto.ForeColor = Color.White;
            label_producto_precioCosto.Location = new Point(350, 259);
            label_producto_precioCosto.Name = "label_producto_precioCosto";
            label_producto_precioCosto.Size = new Size(114, 22);
            label_producto_precioCosto.TabIndex = 3;
            label_producto_precioCosto.Text = "Precio costo";
            // 
            // label_producto_margen
            // 
            label_producto_margen.AutoSize = true;
            label_producto_margen.BackColor = Color.Transparent;
            label_producto_margen.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_producto_margen.ForeColor = Color.White;
            label_producto_margen.Location = new Point(505, 312);
            label_producto_margen.Name = "label_producto_margen";
            label_producto_margen.Size = new Size(71, 22);
            label_producto_margen.TabIndex = 4;
            label_producto_margen.Text = "Margen";
            // 
            // label_producto_iva
            // 
            label_producto_iva.AutoSize = true;
            label_producto_iva.BackColor = Color.Transparent;
            label_producto_iva.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_producto_iva.ForeColor = Color.White;
            label_producto_iva.Location = new Point(353, 312);
            label_producto_iva.Name = "label_producto_iva";
            label_producto_iva.Size = new Size(39, 22);
            label_producto_iva.TabIndex = 5;
            label_producto_iva.Text = "IVA";
            // 
            // label_producto_precioBruto
            // 
            label_producto_precioBruto.AutoSize = true;
            label_producto_precioBruto.BackColor = Color.Transparent;
            label_producto_precioBruto.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_producto_precioBruto.ForeColor = Color.White;
            label_producto_precioBruto.Location = new Point(505, 259);
            label_producto_precioBruto.Name = "label_producto_precioBruto";
            label_producto_precioBruto.Size = new Size(112, 22);
            label_producto_precioBruto.TabIndex = 6;
            label_producto_precioBruto.Text = "Precio bruto";
            // 
            // label_producto_precioVenta
            // 
            label_producto_precioVenta.AutoSize = true;
            label_producto_precioVenta.BackColor = Color.Transparent;
            label_producto_precioVenta.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_producto_precioVenta.ForeColor = Color.White;
            label_producto_precioVenta.Location = new Point(664, 259);
            label_producto_precioVenta.Name = "label_producto_precioVenta";
            label_producto_precioVenta.Size = new Size(114, 22);
            label_producto_precioVenta.TabIndex = 7;
            label_producto_precioVenta.Text = "Precio venta";
            // 
            // label_producto_proveedor
            // 
            label_producto_proveedor.AutoSize = true;
            label_producto_proveedor.BackColor = Color.Transparent;
            label_producto_proveedor.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_producto_proveedor.ForeColor = Color.White;
            label_producto_proveedor.Location = new Point(284, 154);
            label_producto_proveedor.Name = "label_producto_proveedor";
            label_producto_proveedor.Size = new Size(93, 22);
            label_producto_proveedor.TabIndex = 8;
            label_producto_proveedor.Text = "Proveedor";
            // 
            // label_producto_categoria
            // 
            label_producto_categoria.AutoSize = true;
            label_producto_categoria.BackColor = Color.Transparent;
            label_producto_categoria.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_producto_categoria.ForeColor = Color.White;
            label_producto_categoria.Location = new Point(514, 87);
            label_producto_categoria.Name = "label_producto_categoria";
            label_producto_categoria.Size = new Size(91, 22);
            label_producto_categoria.TabIndex = 9;
            label_producto_categoria.Text = "Categoría";
            // 
            // label_producto_subCategoria
            // 
            label_producto_subCategoria.AutoSize = true;
            label_producto_subCategoria.BackColor = Color.Transparent;
            label_producto_subCategoria.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_producto_subCategoria.ForeColor = Color.White;
            label_producto_subCategoria.Location = new Point(514, 154);
            label_producto_subCategoria.Name = "label_producto_subCategoria";
            label_producto_subCategoria.Size = new Size(120, 22);
            label_producto_subCategoria.TabIndex = 10;
            label_producto_subCategoria.Text = "Subcategoría";
            // 
            // input_producto_nombre
            // 
            input_producto_nombre.Location = new Point(284, 111);
            input_producto_nombre.Margin = new Padding(5);
            input_producto_nombre.Name = "input_producto_nombre";
            input_producto_nombre.PlaceholderText = "Nombre del producto...";
            input_producto_nombre.Size = new Size(186, 23);
            input_producto_nombre.TabIndex = 11;
            // 
            // input_producto_descripcion
            // 
            input_producto_descripcion.Location = new Point(19, 269);
            input_producto_descripcion.Margin = new Padding(5);
            input_producto_descripcion.Multiline = true;
            input_producto_descripcion.Name = "input_producto_descripcion";
            input_producto_descripcion.PlaceholderText = "Ingrese una descripción del producto...";
            input_producto_descripcion.Size = new Size(298, 90);
            input_producto_descripcion.TabIndex = 12;
            // 
            // input_producto_precioCosto
            // 
            input_producto_precioCosto.Location = new Point(352, 281);
            input_producto_precioCosto.Margin = new Padding(5);
            input_producto_precioCosto.Name = "input_producto_precioCosto";
            input_producto_precioCosto.PlaceholderText = "Precio de costo...";
            input_producto_precioCosto.Size = new Size(133, 23);
            input_producto_precioCosto.TabIndex = 13;
            // 
            // input_producto_margen
            // 
            input_producto_margen.Location = new Point(504, 335);
            input_producto_margen.Margin = new Padding(5);
            input_producto_margen.Name = "input_producto_margen";
            input_producto_margen.PlaceholderText = "Margen de ganancia...";
            input_producto_margen.Size = new Size(133, 23);
            input_producto_margen.TabIndex = 14;
            // 
            // input_producto_iva
            // 
            input_producto_iva.Location = new Point(350, 334);
            input_producto_iva.Margin = new Padding(5);
            input_producto_iva.Name = "input_producto_iva";
            input_producto_iva.PlaceholderText = "Porcentaje IVA...";
            input_producto_iva.Size = new Size(133, 23);
            input_producto_iva.TabIndex = 15;
            // 
            // input_producto_precioBruto
            // 
            input_producto_precioBruto.Location = new Point(504, 281);
            input_producto_precioBruto.Margin = new Padding(5);
            input_producto_precioBruto.Name = "input_producto_precioBruto";
            input_producto_precioBruto.PlaceholderText = "Precio bruto...";
            input_producto_precioBruto.Size = new Size(133, 23);
            input_producto_precioBruto.TabIndex = 16;
            // 
            // input_producto_precioVenta
            // 
            input_producto_precioVenta.Location = new Point(656, 281);
            input_producto_precioVenta.Margin = new Padding(5);
            input_producto_precioVenta.Name = "input_producto_precioVenta";
            input_producto_precioVenta.PlaceholderText = "Precio de venta...";
            input_producto_precioVenta.Size = new Size(133, 23);
            input_producto_precioVenta.TabIndex = 17;
            // 
            // input_producto_proveedor
            // 
            input_producto_proveedor.Location = new Point(283, 176);
            input_producto_proveedor.Margin = new Padding(5);
            input_producto_proveedor.Name = "input_producto_proveedor";
            input_producto_proveedor.PlaceholderText = "Proveedor del producto...";
            input_producto_proveedor.Size = new Size(187, 23);
            input_producto_proveedor.TabIndex = 18;
            // 
            // select_producto_categoria
            // 
            select_producto_categoria.FormattingEnabled = true;
            select_producto_categoria.Items.AddRange(new object[] { "Categoría A", "Categoría B", "Categoría C" });
            select_producto_categoria.Location = new Point(514, 110);
            select_producto_categoria.Margin = new Padding(5);
            select_producto_categoria.Name = "select_producto_categoria";
            select_producto_categoria.Size = new Size(188, 23);
            select_producto_categoria.TabIndex = 19;
            // 
            // select_producto_subCategoria
            // 
            select_producto_subCategoria.FormattingEnabled = true;
            select_producto_subCategoria.Items.AddRange(new object[] { "Subcategoría A.A", "Subcategoría A.B", "Subcategoría A.C", "Subcategoría B.B", "Subcategoría B.C", "Subcategoría C.C" });
            select_producto_subCategoria.Location = new Point(512, 176);
            select_producto_subCategoria.Margin = new Padding(5);
            select_producto_subCategoria.Name = "select_producto_subCategoria";
            select_producto_subCategoria.Size = new Size(190, 23);
            select_producto_subCategoria.TabIndex = 20;
            // 
            // image_producto
            // 
            image_producto.Image = Properties.Resources.Producto_SinFoto;
            image_producto.Location = new Point(20, 79);
            image_producto.Name = "image_producto";
            image_producto.Size = new Size(216, 125);
            image_producto.SizeMode = PictureBoxSizeMode.Zoom;
            image_producto.TabIndex = 21;
            image_producto.TabStop = false;
            // 
            // button_cancelar
            // 
            button_cancelar.BackColor = Color.Red;
            button_cancelar.FlatAppearance.BorderSize = 0;
            button_cancelar.FlatStyle = FlatStyle.Flat;
            button_cancelar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button_cancelar.ForeColor = Color.White;
            button_cancelar.Location = new Point(187, 400);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(90, 35);
            button_cancelar.TabIndex = 22;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = false;
            button_cancelar.Click += Button_cancelar;
            // 
            // button_reset
            // 
            button_reset.BackColor = Color.Blue;
            button_reset.FlatAppearance.BorderSize = 0;
            button_reset.FlatStyle = FlatStyle.Flat;
            button_reset.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_reset.ForeColor = Color.White;
            button_reset.Location = new Point(380, 400);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(90, 35);
            button_reset.TabIndex = 23;
            button_reset.Text = "Limpiar";
            button_reset.UseVisualStyleBackColor = false;
            button_reset.Click += Button_limpiar;
            // 
            // button_guardar
            // 
            button_guardar.BackColor = Color.Green;
            button_guardar.FlatAppearance.BorderSize = 0;
            button_guardar.FlatStyle = FlatStyle.Flat;
            button_guardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button_guardar.ForeColor = Color.White;
            button_guardar.Location = new Point(570, 400);
            button_guardar.Name = "button_guardar";
            button_guardar.Size = new Size(90, 35);
            button_guardar.TabIndex = 24;
            button_guardar.Text = "Guardar";
            button_guardar.UseVisualStyleBackColor = false;
            button_guardar.Click += button_guardar_producto;
            // 
            // Form_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background2;
            ClientSize = new Size(800, 450);
            Controls.Add(button_guardar);
            Controls.Add(button_reset);
            Controls.Add(button_cancelar);
            Controls.Add(image_producto);
            Controls.Add(select_producto_subCategoria);
            Controls.Add(select_producto_categoria);
            Controls.Add(input_producto_proveedor);
            Controls.Add(input_producto_precioVenta);
            Controls.Add(input_producto_precioBruto);
            Controls.Add(input_producto_iva);
            Controls.Add(input_producto_margen);
            Controls.Add(input_producto_precioCosto);
            Controls.Add(input_producto_descripcion);
            Controls.Add(input_producto_nombre);
            Controls.Add(label_producto_subCategoria);
            Controls.Add(label_producto_categoria);
            Controls.Add(label_producto_proveedor);
            Controls.Add(label_producto_precioVenta);
            Controls.Add(label_producto_precioBruto);
            Controls.Add(label_producto_iva);
            Controls.Add(label_producto_margen);
            Controls.Add(label_producto_precioCosto);
            Controls.Add(label_producto_descripcion);
            Controls.Add(label_producto_nombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_producto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insumos de computación - Agregar nuevo producto";
            ((System.ComponentModel.ISupportInitialize)image_producto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_producto_nombre;
        private Label label_producto_descripcion;
        private Label label_producto_precioCosto;
        private Label label_producto_margen;
        private Label label_producto_iva;
        private Label label_producto_precioBruto;
        private Label label_producto_precioVenta;
        private Label label_producto_proveedor;
        private Label label_producto_categoria;
        private Label label_producto_subCategoria;
        private TextBox input_producto_nombre;
        private TextBox input_producto_descripcion;
        private TextBox input_producto_precioCosto;
        private TextBox input_producto_margen;
        private TextBox input_producto_iva;
        private TextBox input_producto_precioBruto;
        private TextBox input_producto_precioVenta;
        private TextBox input_producto_proveedor;
        private ComboBox select_producto_categoria;
        private ComboBox select_producto_subCategoria;
        private PictureBox image_producto;
        private Button button_cancelar;
        private Button button_reset;
        private Button button_guardar;
    }
}