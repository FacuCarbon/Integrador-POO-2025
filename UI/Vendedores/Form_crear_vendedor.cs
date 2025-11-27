using Integrador.Datos;
using Integrador.Entidades;
using Integrador.Utilidades;

namespace Integrador
{
    public partial class Form_crear_vendedor : Form
    {
        public Form_crear_vendedor()
        {
            InitializeComponent();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input_vendedor_nombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Campos requeridos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input_vendedor_nombre.Focus();
                    return;
                }

                string cuit = input_vendedor_cuit.Text.Replace("-", "").Trim();

                if (!input_vendedor_cuit.MaskCompleted || string.IsNullOrWhiteSpace(cuit))
                {
                    MessageBox.Show("El CUIT es obligatorio.", "Campos requeridos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input_vendedor_cuit.Focus();
                    return;
                }

                Vendedor v = new Vendedor(
                 input_vendedor_nombre.Text.Trim().ToUpper(),
                 input_vendedor_apellido.Text.Trim().ToUpper(),
                 input_vendedor_dni.Text.Trim(),
                 cuit

             );

                DALVendedor dal = new DALVendedor();
                dal.AgregarVendedor(v);

                MessageBox.Show("El vendedor fue registrado en el sistema.", "guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}