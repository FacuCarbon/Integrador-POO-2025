namespace Integrador
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            input_username = new TextBox();
            label_usuario = new Label();
            label_password = new Label();
            input_password = new MaskedTextBox();
            button_cancelar = new Button();
            button_login = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // input_username
            // 
            input_username.Location = new Point(131, 133);
            input_username.Name = "input_username";
            input_username.PlaceholderText = "Ingrese su usuario...";
            input_username.Size = new Size(258, 23);
            input_username.TabIndex = 2;
            // 
            // label_usuario
            // 
            label_usuario.AutoSize = true;
            label_usuario.BackColor = Color.Transparent;
            label_usuario.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_usuario.ForeColor = Color.White;
            label_usuario.Location = new Point(128, 108);
            label_usuario.Name = "label_usuario";
            label_usuario.Size = new Size(74, 22);
            label_usuario.TabIndex = 5;
            label_usuario.Text = "Usuario";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.BackColor = Color.Transparent;
            label_password.Font = new Font("Arial Black", 11.25F, FontStyle.Bold);
            label_password.ForeColor = Color.White;
            label_password.Location = new Point(128, 180);
            label_password.Name = "label_password";
            label_password.Size = new Size(105, 22);
            label_password.TabIndex = 6;
            label_password.Text = "Contraseña";
            // 
            // input_password
            // 
            input_password.Location = new Point(131, 205);
            input_password.Name = "input_password";
            input_password.PasswordChar = '*';
            input_password.Size = new Size(258, 23);
            input_password.TabIndex = 7;
            // 
            // button_cancelar
            // 
            button_cancelar.BackColor = Color.Red;
            button_cancelar.FlatAppearance.BorderSize = 0;
            button_cancelar.FlatStyle = FlatStyle.Flat;
            button_cancelar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button_cancelar.ForeColor = Color.White;
            button_cancelar.Location = new Point(155, 263);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(90, 35);
            button_cancelar.TabIndex = 26;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = false;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // button_login
            // 
            button_login.BackColor = Color.Teal;
            button_login.FlatAppearance.BorderSize = 0;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(278, 263);
            button_login.Name = "button_login";
            button_login.Size = new Size(90, 35);
            button_login.TabIndex = 28;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 35);
            label1.Name = "label1";
            label1.Size = new Size(306, 32);
            label1.TabIndex = 29;
            label1.Text = "¡Bienvenido nuevamente!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(513, 351);
            Controls.Add(label1);
            Controls.Add(button_login);
            Controls.Add(button_cancelar);
            Controls.Add(input_password);
            Controls.Add(label_password);
            Controls.Add(label_usuario);
            Controls.Add(input_username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insumos de computación - Login";
        
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox input_username;
        private Label label_usuario;
        private Label label_password;
        private MaskedTextBox input_password;
        private Button button_cancelar;
        private Button button_login;
        private Label label1;
    }
}