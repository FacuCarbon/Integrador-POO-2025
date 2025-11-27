using Integrador.Datos;
using Integrador.Entidades;
using Integrador.Utilidades;

namespace Integrador
{
    public partial class Form_crear_producto : Form
    {
        public Form_crear_producto()
        {
            InitializeComponent();
        }

        private void Button_cancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_limpiar(object sender, EventArgs e)
        {
            Helpers.LimpiarControles(this);
        }

        private void button_guardar_producto(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input_producto_nombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.");
                    input_producto_nombre.Focus();
                    return;
                }

                if (!decimal.TryParse(input_producto_precioCosto.Text, out decimal precioCosto))
                {
                    MessageBox.Show("Precio costo inválido.");
                    return;
                }

                if (!double.TryParse(input_producto_margen.Text, out double margen))
                {
                    MessageBox.Show("Margen inválido.");
                    return;
                }

                if (!double.TryParse(input_producto_iva.Text, out double iva))
                {
                    MessageBox.Show("IVA inválido.");
                    return;
                }

                decimal precioBruto = precioCosto + (decimal)margen;
                decimal precioVenta = precioBruto + (decimal)iva;

                input_producto_precioBruto.Text = precioBruto.ToString("0.00");
                input_producto_precioVenta.Text = precioVenta.ToString("0.00");

                Producto p = new Producto(
                    input_producto_nombre.Text.ToUpper(),
                    input_producto_descripcion.Text.ToUpper(),
                    precioCosto,
                    margen,
                    iva,
                    precioBruto,
                    precioVenta,
                    input_producto_proveedor.Text.ToUpper(),
                    select_producto_categoria.Text.ToUpper(),
                    select_producto_subCategoria.Text.ToUpper()
                );

                DALProducto dal = new DALProducto();
                dal.AgregarProducto(p);

                MessageBox.Show("El producto fue registrado en el sistema.", "guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

