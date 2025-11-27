using Integrador.Datos;
using Integrador.Entidades;
using Integrador.Utilidades;

namespace Integrador
{
    public partial class Form_editar_vendedor : Form
    {
        private readonly int _idVendedor;

        public Form_editar_vendedor(int idVendedor)
        {
            InitializeComponent();
            _idVendedor = idVendedor;

            this.Load += Form_editar_vendedor_Load;
        }

        private void Form_editar_vendedor_Load(object? sender, EventArgs e)
        {
            try
            {
                DALVendedor dal = new DALVendedor();
                Vendedor? v = dal.ObtenerVendedorPorId(_idVendedor);

                if (v == null)
                {
                    MessageBox.Show("El vendedor no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                input_vendedor_nombre.Text = v?.Nombre;
                input_vendedor_apellido.Text = v?.Apellido;
                input_vendedor_dni.Text = v?.Dni;
                input_vendedor_cuit.Text = v?.Cuit;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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
                _idVendedor,
                input_vendedor_nombre.Text.Trim().ToUpper(),
                input_vendedor_apellido.Text.Trim().ToUpper(),
                input_vendedor_dni.Text.Trim(),
                cuit

            );

                DALVendedor dal = new DALVendedor();
                dal.ActualizarVendedor(v);

                MessageBox.Show("El vendedor fue actualizado en el sistema.", "guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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