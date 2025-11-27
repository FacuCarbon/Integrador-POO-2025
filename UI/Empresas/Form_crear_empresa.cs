using Integrador.Datos;
using Integrador.Entidades;
using Integrador.Utilidades;

namespace Integrador
{
    public partial class Form_crear_empresa : Form
    {
        public Form_crear_empresa()
        {
            InitializeComponent();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input_empresa_nombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Campos requeridos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input_empresa_nombre.Focus();
                    return;
                }

                string cuit = input_empresa_cuit.Text.Replace("-", "").Trim();

                if (!input_empresa_cuit.MaskCompleted || string.IsNullOrWhiteSpace(cuit))
                {
                    MessageBox.Show("El CUIT es obligatorio.", "Campos requeridos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input_empresa_cuit.Focus();
                    return;
                }

                ClienteEmpresa empresa = new ClienteEmpresa(
                 input_empresa_nombre.Text.Trim().ToUpper(),
                 input_empresa_contacto.Text.Trim().ToUpper(),
                 cuit,
                 input_empresa_email.Text.Trim().ToUpper(),
                 input_empresa_telefono.Text.Trim(),
                 input_empresa_direccion.Text.Trim().ToUpper()

             );

                DALEmpresa dal = new DALEmpresa();
                dal.AgregarEmpresa(empresa);

                MessageBox.Show("La empresa fue registrada en el sistema.", "guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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