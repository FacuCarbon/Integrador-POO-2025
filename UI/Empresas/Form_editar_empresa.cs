using Integrador.Datos;
using Integrador.Entidades;
using Integrador.Utilidades;

namespace Integrador
{
    public partial class Form_editar_empresa : Form
    {
        private readonly int _idEmpresa;

        public Form_editar_empresa()
        {
            InitializeComponent();
        }

        public Form_editar_empresa(int idEmpresa)
        {
            InitializeComponent();
            _idEmpresa = idEmpresa;

            this.Load += Form_editar_empresa_Load;
        }

        private void Form_editar_empresa_Load(object? sender, EventArgs e)
        {
            try
            {
                DALEmpresa dal = new DALEmpresa();
                ClienteEmpresa? empresa = dal.ObtenerEmpresaPorId(_idEmpresa);

                if (e == null)
                {
                    MessageBox.Show("La empresa no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                input_empresa_nombre.Text = empresa?.Nombre;
                input_empresa_contacto.Text = empresa?.Contacto;
                input_empresa_cuit.Text = empresa?.Cuit;

                input_empresa_email.Text = empresa?.Mail;
                input_empresa_telefono.Text = empresa?.Telefono;
                input_empresa_direccion.Text = empresa?.Direccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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
                _idEmpresa,
                 input_empresa_nombre.Text.Trim().ToUpper(),
                 input_empresa_contacto.Text.Trim().ToUpper(),
                 cuit,
                 input_empresa_email.Text.Trim().ToUpper(),
                 input_empresa_telefono.Text.Trim(),
                 input_empresa_direccion.Text.Trim().ToUpper()

             );

                DALEmpresa dal = new DALEmpresa();
                dal.ActualizarEmpresa(empresa);

                MessageBox.Show("La empresa fue actualizada en el sistema.", "guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

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