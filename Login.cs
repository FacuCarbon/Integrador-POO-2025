using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


        }

        readonly string username = "admin";
        readonly string password = "admin123";
        int intentos = 3;
        private void button_login_Click(object sender, EventArgs e)
        {
            string usernameInput = input_username.Text.Trim();
            string passwordInput = input_password.Text.Trim();

            if (usernameInput.Length == 0 || passwordInput.Length == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usernameInput == username && passwordInput == password)
            {

                Form_principal formPrincipal = new Form_principal();
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                intentos--;
                MessageBox.Show("Credenciales incorrectas. Te quedan " + intentos + " intentos.", "Credenciales invalidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (intentos == 0)
                {
                    MessageBox.Show("Su cuenta fue bloqueada por seguridad. Contactese con soporte.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

   
    }
}
