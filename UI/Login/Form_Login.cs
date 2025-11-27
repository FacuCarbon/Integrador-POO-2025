using Integrador.Datos;
using Integrador.Entidades;
using Integrador.Utilidades;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private int intentos = 3;

        private void button_login_Click(object sender, EventArgs e)
        {
            string usernameInput = input_username.Text.Trim();
            string passwordInput = input_password.Text.Trim();

            if (usernameInput.Length == 0 || passwordInput.Length == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DALUsuario dal = new DALUsuario();
            Usuario? usuario = dal.Login(usernameInput, passwordInput);

            if (usuario == null)
            {
                intentos--;
                MessageBox.Show("Credenciales incorrectas. Te quedan " + intentos + " intentos.", "Credenciales invalidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (intentos == 0)
                {
                    MessageBox.Show("Su cuenta fue bloqueada por seguridad. Contactese con soporte.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
            {
                Sesion.UsuarioActual = usuario;
                MessageBox.Show($"¡Bienvenido de nuevo {usuario?.ApellyNom}!", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Form_principal formPrincipal = new Form_principal();
                formPrincipal.Show();
                this.Hide();
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}