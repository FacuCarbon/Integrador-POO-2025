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
    public partial class Form_producto : Form
    {
        public Form_producto()
        {
            InitializeComponent();

        }

        private void Button_cancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_limpiar(object sender, EventArgs e)
        {
            input_producto_nombre.Text = "";
            input_producto_descripcion.Text = "";
            input_producto_proveedor.Text = "";
            select_producto_categoria.Text = "";
            select_producto_subCategoria.Text = "";
            input_producto_precioCosto.Text = "";
            input_producto_iva.Text = "";
            input_producto_precioBruto.Text = "";
            input_producto_margen.Text = "";
            input_producto_precioVenta.Text = "";
        }

        private void button_guardar_producto(object sender, EventArgs e)
        {
            MessageBox.Show("Todavía no guarda :)");
        }
    }
}
