namespace Integrador
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void Event_menuItem_salir(object sender, EventArgs e)
        {
            Close();
        }

        private void boton_crear_producto_Click(object sender, EventArgs e)
        {
            Form_producto form_producto = new Form_producto();
            form_producto.Show();
        }

        private void boton_crear_vendedor_Click(object sender, EventArgs e)
        {
            Form_vendedor form_vendedor = new Form_vendedor();
            form_vendedor.Show();
        }
    }
}

 