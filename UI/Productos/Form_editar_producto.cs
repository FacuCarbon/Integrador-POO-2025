using Integrador.Datos;
using Integrador.Entidades;
using Integrador.Utilidades;

namespace Integrador
{
    public partial class Form_editar_producto : Form
    {
        private readonly int _idProducto;

       
        public Form_editar_producto(int idProducto)
        {
            InitializeComponent();
            _idProducto = idProducto;

          
            this.Load += Form_editar_producto_Load;
        }

        private void Form_editar_producto_Load(object? sender, EventArgs e)
        {
            try
            {
                DALProducto dal = new DALProducto();
                Producto? p = dal.ObtenerProductoPorId(_idProducto);

                if (p == null)
                {
                    MessageBox.Show("El producto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

               
                input_producto_nombre.Text = p.Nombre;
                input_producto_descripcion.Text = p.Descripcion;
                input_producto_precioCosto.Text = p.PrecioCosto.ToString("0.00");
                input_producto_margen.Text = p.Margen.ToString("0.00");
                input_producto_iva.Text = p.IVA.ToString("0.00");
                input_producto_precioBruto.Text = p.PrecioBruto.ToString("0.00");
                input_producto_precioVenta.Text = p.PrecioVenta.ToString("0.00");
                input_producto_proveedor.Text = p.Proveedor;
                select_producto_categoria.Text = p.Categoria;
                select_producto_subCategoria.Text = p.SubCategoria;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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
                    _idProducto,
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
                dal.EditarProducto(p);

                MessageBox.Show("Producto editado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
