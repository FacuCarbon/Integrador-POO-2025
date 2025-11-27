using Integrador.Datos;
using Integrador.Entidades;
using Integrador.Utilidades;

namespace Integrador
{
    public partial class Form_editar_cliente : Form
    {
        private readonly int _idCliente;

        public Form_editar_cliente(int idCliente)
        {
            InitializeComponent();
            _idCliente = idCliente;

            this.Load += Form_editar_cliente_Load;
        }

        private void Form_editar_cliente_Load(object? sender, EventArgs e)
        {
            try
            {
                DALCliente dal = new DALCliente();
                ClienteIndividuo? c = dal.ObtenerClientePorId(_idCliente);

                if (c == null)
                {
                    MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                input_cliente_nombre.Text = c?.Nombre;
                input_cliente_apellido.Text = c?.Apellido;
                input_cliente_cuit.Text = c?.Cuit;
                input_cliente_email.Text = c?.Mail;
                input_cliente_telefono.Text = c?.Telefono;
                input_cliente_direccion.Text = c?.Direccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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
                _idCliente,
                 input_cliente_nombre.Text.Trim().ToUpper(),
                 input_cliente_apellido.Text.Trim().ToUpper(),
                 cuit,
                 input_cliente_email.Text.Trim().ToUpper(),
                 input_cliente_telefono.Text.Trim(),
                 input_cliente_direccion.Text.Trim().ToUpper()

            );

                DALCliente dal = new DALCliente();
                dal.ActualizarCliente(c);

                MessageBox.Show("El cliente fue actualizado en el sistema.", "guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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