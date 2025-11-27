namespace Integrador
{
    partial class Form_editar_vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_editar_vendedor));
            label1 = new Label();
            label_vendedor_nombre = new Label();
            input_vendedor_nombre = new TextBox();
            input_vendedor_apellido = new TextBox();
            label_vendedor_apellido = new Label();
            input_vendedor_dni = new TextBox();
            label_vendedor_dni = new Label();
            label_vendedor_cuit = new Label();
            input_vendedor_cuit = new MaskedTextBox();
            image_vendedor = new PictureBox();
            button_guardar = new Button();
            button_reset = new Button();
            button_cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)image_vendedor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 1;
            label1.Text = "Editar vendedor";
            // 
            // label_vendedor_nombre
            // 
            label_vendedor_nombre.AutoSize = true;
            label_vendedor_nombre.BackColor = Color.Transparent;
            label_vendedor_nombre.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_vendedor_nombre.ForeColor = Color.White;
            label_vendedor_nombre.Location = new Point(302, 79);
            label_vendedor_nombre.Name = "label_vendedor_nombre";
            label_vendedor_nombre.Size = new Size(75, 22);
            label_vendedor_nombre.TabIndex = 2;
            label_vendedor_nombre.Text = "Nombre";
            // 
            // input_vendedor_nombre
            // 
            input_vendedor_nombre.CharacterCasing = CharacterCasing.Upper;
            input_vendedor_nombre.Location = new Point(302, 106);
            input_vendedor_nombre.Margin = new Padding(5);
            input_vendedor_nombre.Name = "input_vendedor_nombre";
            input_vendedor_nombre.PlaceholderText = "Nombre del vendedor...";
            input_vendedor_nombre.Size = new Size(186, 23);
            input_vendedor_nombre.TabIndex = 12;
            // 
            // input_vendedor_apellido
            // 
            input_vendedor_apellido.CharacterCasing = CharacterCasing.Upper;
            input_vendedor_apellido.Location = new Point(539, 106);
            input_vendedor_apellido.Margin = new Padding(5);
            input_vendedor_apellido.Name = "input_vendedor_apellido";
            input_vendedor_apellido.PlaceholderText = "Apellido del vendedor...";
            input_vendedor_apellido.Size = new Size(186, 23);
            input_vendedor_apellido.TabIndex = 14;
            // 
            // label_vendedor_apellido
            // 
            label_vendedor_apellido.AutoSize = true;
            label_vendedor_apellido.BackColor = Color.Transparent;
            label_vendedor_apellido.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_vendedor_apellido.ForeColor = Color.White;
            label_vendedor_apellido.Location = new Point(539, 79);
            label_vendedor_apellido.Name = "label_vendedor_apellido";
            label_vendedor_apellido.Size = new Size(77, 22);
            label_vendedor_apellido.TabIndex = 13;
            label_vendedor_apellido.Text = "Apellido";
            // 
            // input_vendedor_dni
            // 
            input_vendedor_dni.Location = new Point(302, 185);
            input_vendedor_dni.Margin = new Padding(5);
            input_vendedor_dni.MaxLength = 8;
            input_vendedor_dni.Name = "input_vendedor_dni";
            input_vendedor_dni.PlaceholderText = "Dni del vendedor...";
            input_vendedor_dni.Size = new Size(186, 23);
            input_vendedor_dni.TabIndex = 16;
            // 
            // label_vendedor_dni
            // 
            label_vendedor_dni.AutoSize = true;
            label_vendedor_dni.BackColor = Color.Transparent;
            label_vendedor_dni.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_vendedor_dni.ForeColor = Color.White;
            label_vendedor_dni.Location = new Point(302, 158);
            label_vendedor_dni.Name = "label_vendedor_dni";
            label_vendedor_dni.Size = new Size(41, 22);
            label_vendedor_dni.TabIndex = 15;
            label_vendedor_dni.Text = "DNI";
            // 
            // label_vendedor_cuit
            // 
            label_vendedor_cuit.AutoSize = true;
            label_vendedor_cuit.BackColor = Color.Transparent;
            label_vendedor_cuit.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_vendedor_cuit.ForeColor = Color.White;
            label_vendedor_cuit.Location = new Point(539, 158);
            label_vendedor_cuit.Name = "label_vendedor_cuit";
            label_vendedor_cuit.Size = new Size(44, 22);
            label_vendedor_cuit.TabIndex = 17;
            label_vendedor_cuit.Text = "Cuit";
            // 
            // input_vendedor_cuit
            // 
            input_vendedor_cuit.Location = new Point(543, 185);
            input_vendedor_cuit.Mask = "99-99999999-9";
            input_vendedor_cuit.Name = "input_vendedor_cuit";
            input_vendedor_cuit.Size = new Size(186, 23);
            input_vendedor_cuit.TabIndex = 18;
            // 
            // image_vendedor
            // 
            image_vendedor.Image = Properties.Resources.Vendedor_SinFoto;
            image_vendedor.Location = new Point(19, 79);
            image_vendedor.Name = "image_vendedor";
            image_vendedor.Size = new Size(216, 125);
            image_vendedor.SizeMode = PictureBoxSizeMode.Zoom;
            image_vendedor.TabIndex = 22;
            image_vendedor.TabStop = false;
            // 
            // button_guardar
            // 
            button_guardar.BackColor = Color.Green;
            button_guardar.FlatAppearance.BorderSize = 0;
            button_guardar.FlatStyle = FlatStyle.Flat;
            button_guardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button_guardar.ForeColor = Color.White;
            button_guardar.Location = new Point(550, 297);
            button_guardar.Name = "button_guardar";
            button_guardar.Size = new Size(90, 35);
            button_guardar.TabIndex = 27;
            button_guardar.Text = "Guardar";
            button_guardar.UseVisualStyleBackColor = false;
            button_guardar.Click += button_guardar_Click;
            // 
            // button_reset
            // 
            button_reset.BackColor = Color.Blue;
            button_reset.FlatAppearance.BorderSize = 0;
            button_reset.FlatStyle = FlatStyle.Flat;
            button_reset.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_reset.ForeColor = Color.White;
            button_reset.Location = new Point(360, 297);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(90, 35);
            button_reset.TabIndex = 26;
            button_reset.Text = "Limpiar";
            button_reset.UseVisualStyleBackColor = false;
            button_reset.Click += button_reset_Click;
            // 
            // button_cancelar
            // 
            button_cancelar.BackColor = Color.Red;
            button_cancelar.FlatAppearance.BorderSize = 0;
            button_cancelar.FlatStyle = FlatStyle.Flat;
            button_cancelar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button_cancelar.ForeColor = Color.White;
            button_cancelar.Location = new Point(167, 297);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(90, 35);
            button_cancelar.TabIndex = 25;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = false;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // Form_editar_vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 377);
            Controls.Add(button_guardar);
            Controls.Add(button_reset);
            Controls.Add(button_cancelar);
            Controls.Add(image_vendedor);
            Controls.Add(input_vendedor_cuit);
            Controls.Add(label_vendedor_cuit);
            Controls.Add(input_vendedor_dni);
            Controls.Add(label_vendedor_dni);
            Controls.Add(input_vendedor_apellido);
            Controls.Add(label_vendedor_apellido);
            Controls.Add(input_vendedor_nombre);
            Controls.Add(label_vendedor_nombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_editar_vendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insumos de computación - Agregar nuevo vendedor";
            ((System.ComponentModel.ISupportInitialize)image_vendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_vendedor_nombre;
        private TextBox input_vendedor_nombre;
        private TextBox input_vendedor_apellido;
        private Label label_vendedor_apellido;
        private TextBox input_vendedor_dni;
        private Label label_vendedor_dni;
        private Label label_vendedor_cuit;
        private MaskedTextBox input_vendedor_cuit;
        private PictureBox image_vendedor;
        private Button button_guardar;
        private Button button_reset;
        private Button button_cancelar;
    }
}