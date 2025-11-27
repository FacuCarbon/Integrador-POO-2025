using Integrador.Datos;
using Integrador.Entidades;
using Integrador.Utilidades;

namespace Integrador
{
    public partial class Form_crear_cliente : Form
    {
        public Form_crear_cliente()
        {
            InitializeComponent();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input_cliente_nombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Campos requeridos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input_cliente_nombre.Focus();
                    return;
                }

                string cuit = input_cliente_cuit.Text.Replace("-", "").Trim();

                if (!input_cliente_cuit.MaskCompleted || string.IsNullOrWhiteSpace(cuit))
                {
                    MessageBox.Show("El CUIT es obligatorio.", "Campos requeridos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input_cliente_cuit.Focus();
                    return;
                }

                ClienteIndividuo c = new ClienteIndividuo(
                 input_cliente_nombre.Text.Trim().ToUpper(),
                 input_cliente_apellido.Text.Trim().ToUpper(),
                 cuit,
                 input_cliente_email.Text.Trim().ToUpper(),
                 input_cliente_telefono.Text.Trim(),
                 input_cliente_direccion.Text.Trim().ToUpper()

             );

                DALCliente dal = new DALCliente();
                dal.AgregarCliente(c);

                MessageBox.Show("El cliente fue registrado en el sistema.", "guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Helpers.LimpiarControles(this);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void input_cliente_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.SoloNumeros(sender, e);
        }
    }
}