namespace Integrador
{
    partial class Form_crear_empresa
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
            label_vendedor_nombre = new Label();
            input_empresa_nombre = new TextBox();
            input_empresa_contacto = new TextBox();
            label_vendedor_apellido = new Label();
            label_vendedor_cuit = new Label();
            input_empresa_cuit = new MaskedTextBox();
            button_guardar = new Button();
            button_reset = new Button();
            button_cancelar = new Button();
            input_empresa_email = new TextBox();
            label2 = new Label();
            label3 = new Label();
            input_empresa_direccion = new TextBox();
            label4 = new Label();
            input_empresa_telefono = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 22);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 1;
            label1.Text = "Registrar empresa";
            // 
            // label_vendedor_nombre
            // 
            label_vendedor_nombre.AutoSize = true;
            label_vendedor_nombre.BackColor = Color.Transparent;
            label_vendedor_nombre.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_vendedor_nombre.ForeColor = Color.White;
            label_vendedor_nombre.Location = new Point(51, 89);
            label_vendedor_nombre.Name = "label_vendedor_nombre";
            label_vendedor_nombre.Size = new Size(75, 22);
            label_vendedor_nombre.TabIndex = 2;
            label_vendedor_nombre.Text = "Nombre";
            // 
            // input_empresa_nombre
            // 
            input_empresa_nombre.CharacterCasing = CharacterCasing.Upper;
            input_empresa_nombre.Location = new Point(54, 116);
            input_empresa_nombre.Margin = new Padding(5);
            input_empresa_nombre.Name = "input_empresa_nombre";
            input_empresa_nombre.PlaceholderText = "Nombre de la empresa...";
            input_empresa_nombre.Size = new Size(186, 23);
            input_empresa_nombre.TabIndex = 12;
            // 
            // input_empresa_contacto
            // 
            input_empresa_contacto.CharacterCasing = CharacterCasing.Upper;
            input_empresa_contacto.Location = new Point(291, 116);
            input_empresa_contacto.Margin = new Padding(5);
            input_empresa_contacto.Name = "input_empresa_contacto";
            input_empresa_contacto.PlaceholderText = "Contacto de la empresa...";
            input_empresa_contacto.Size = new Size(186, 23);
            input_empresa_contacto.TabIndex = 14;
            // 
            // label_vendedor_apellido
            // 
            label_vendedor_apellido.AutoSize = true;
            label_vendedor_apellido.BackColor = Color.Transparent;
            label_vendedor_apellido.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_vendedor_apellido.ForeColor = Color.White;
            label_vendedor_apellido.Location = new Point(286, 89);
            label_vendedor_apellido.Name = "label_vendedor_apellido";
            label_vendedor_apellido.Size = new Size(86, 22);
            label_vendedor_apellido.TabIndex = 13;
            label_vendedor_apellido.Text = "Contacto";
            // 
            // label_vendedor_cuit
            // 
            label_vendedor_cuit.AutoSize = true;
            label_vendedor_cuit.BackColor = Color.Transparent;
            label_vendedor_cuit.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_vendedor_cuit.ForeColor = Color.White;
            label_vendedor_cuit.Location = new Point(48, 165);
            label_vendedor_cuit.Name = "label_vendedor_cuit";
            label_vendedor_cuit.Size = new Size(44, 22);
            label_vendedor_cuit.TabIndex = 17;
            label_vendedor_cuit.Text = "Cuit";
            // 
            // input_empresa_cuit
            // 
            input_empresa_cuit.Location = new Point(54, 190);
            input_empresa_cuit.Mask = "99-99999999-9";
            input_empresa_cuit.Name = "input_empresa_cuit";
            input_empresa_cuit.Size = new Size(186, 23);
            input_empresa_cuit.TabIndex = 18;
            // 
            // button_guardar
            // 
            button_guardar.BackColor = Color.Green;
            button_guardar.FlatAppearance.BorderSize = 0;
            button_guardar.FlatStyle = FlatStyle.Flat;
            button_guardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button_guardar.ForeColor = Color.White;
            button_guardar.Location = new Point(391, 340);
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
            button_reset.Location = new Point(225, 340);
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
            button_cancelar.Location = new Point(54, 340);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(90, 35);
            button_cancelar.TabIndex = 25;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = false;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // input_empresa_email
            // 
            input_empresa_email.CharacterCasing = CharacterCasing.Upper;
            input_empresa_email.Location = new Point(291, 190);
            input_empresa_email.Margin = new Padding(5);
            input_empresa_email.MaxLength = 30;
            input_empresa_email.Name = "input_empresa_email";
            input_empresa_email.PlaceholderText = "Email de la empresa...";
            input_empresa_email.Size = new Size(186, 23);
            input_empresa_email.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(288, 163);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 28;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 242);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 30;
            label3.Text = "Telefono";
            // 
            // input_empresa_direccion
            // 
            input_empresa_direccion.CharacterCasing = CharacterCasing.Upper;
            input_empresa_direccion.Location = new Point(291, 269);
            input_empresa_direccion.Margin = new Padding(5);
            input_empresa_direccion.Name = "input_empresa_direccion";
            input_empresa_direccion.PlaceholderText = "Dirección de la empresa...";
            input_empresa_direccion.Size = new Size(186, 23);
            input_empresa_direccion.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(288, 242);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 32;
            label4.Text = "Dirección";
            // 
            // input_empresa_telefono
            // 
            input_empresa_telefono.Location = new Point(54, 269);
            input_empresa_telefono.MaxLength = 15;
            input_empresa_telefono.Name = "input_empresa_telefono";
            input_empresa_telefono.PlaceholderText = "Telefono de la empresa...";
            input_empresa_telefono.Size = new Size(186, 23);
            input_empresa_telefono.TabIndex = 34;
            input_empresa_telefono.KeyPress += input_cliente_telefono_KeyPress;
            // 
            // Form_crear_empresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(544, 438);
            Controls.Add(input_empresa_telefono);
            Controls.Add(input_empresa_direccion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(input_empresa_email);
            Controls.Add(label2);
            Controls.Add(button_guardar);
            Controls.Add(button_reset);
            Controls.Add(button_cancelar);
            Controls.Add(input_empresa_cuit);
            Controls.Add(label_vendedor_cuit);
            Controls.Add(input_empresa_contacto);
            Controls.Add(label_vendedor_apellido);
            Controls.Add(input_empresa_nombre);
            Controls.Add(label_vendedor_nombre);
            Controls.Add(label1);
            Name = "Form_crear_empresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insumos de computación - Agregar nueva empresa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_vendedor_nombre;
        private TextBox input_empresa_nombre;
        private TextBox input_empresa_contacto;
        private Label label_vendedor_apellido;
        private Label label_vendedor_cuit;
        private MaskedTextBox input_empresa_cuit;
        private Button button_guardar;
        private Button button_reset;
        private Button button_cancelar;
        private TextBox input_empresa_email;
        private Label label2;
        private Label label3;
        private TextBox input_empresa_direccion;
        private Label label4;
        private TextBox input_empresa_telefono;
    }
}