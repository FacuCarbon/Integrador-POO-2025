using Integrador.Datos;
using Integrador.Utilidades;

namespace Integrador
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();

            listado_productos.BotonCrearClick += ListadoProductos_BotonCrearClick;
            listado_vendedores.BotonCrearClick += ListadoVendedores_BotonCrearClick;
            listado_clientes.BotonCrearClick += ListadoClientes_BotonCrearClick;
            listado_empresas.BotonCrearClick += ListadoEmpresas_BotonCrearClick;

            listado_productos.EditarClick += EditarProducto;
            listado_productos.EliminarClick += EliminarProducto;

            listado_vendedores.EditarClick += EditarVendedor;
            listado_vendedores.EliminarClick += EliminarVendedor;

            listado_productos.TextoBusquedaChanged += ListadoProductos_TextoBusquedaChanged;
            listado_vendedores.TextoBusquedaChanged += ListadoVendedores_TextoBusquedaChanged;
            listado_clientes.TextoBusquedaChanged += ListadoClientes_TextoBusquedaChanged;
            listado_empresas.TextoBusquedaChanged += ListadoEmpresas_TextoBusquedaChanged;
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null)
            {
                MenuItem_archivo.Text = $"{Sesion.UsuarioActual.ApellyNom} - Admin";
            }

            listado_productos.Titulo = "Productos";
            listado_vendedores.Titulo = "Vendedores";
            listado_clientes.Titulo = "Clientes";
            listado_empresas.Titulo = "Empresas";

            Helpers.CargarProductos(listado_productos.Grid, null);
            Helpers.CargarVendedores(listado_vendedores.Grid, null);
            Helpers.CargarClientes(listado_clientes.Grid, null);
            Helpers.CargarEmpresas(listado_empresas.Grid, null);
        }

        private void ListadoProductos_TextoBusquedaChanged(object? sender, EventArgs e)
        {
            string query = listado_productos.TextoBusqueda;
            Helpers.CargarProductos(
                listado_productos.Grid,
                query.Length >= 3 ? query : null
            );
        }

        private void ListadoProductos_BotonCrearClick(object? sender, EventArgs e)
        {
            Form_crear_producto form_crear_producto = new Form_crear_producto();

            if (form_crear_producto.ShowDialog(this) == DialogResult.OK)
            {
                Helpers.CargarProductos(listado_productos.Grid, null);
            }
        }

        private void ListadoEmpresas_BotonCrearClick(object? sender, EventArgs e)
        { }

        private void ListadoClientes_BotonCrearClick(object? sender, EventArgs e)
        { }

        private void EditarProducto(int id)
        {
            Form_editar_producto form = new Form_editar_producto(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Helpers.CargarProductos(listado_productos.Grid, null);
            }
        }

        private void EliminarProducto(int id)
        {
            DialogResult result = MessageBox.Show(
                "¿Seguro que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                DALProducto dal = new DALProducto();
                dal.EliminarProducto(id);

                Helpers.CargarProductos(listado_productos.Grid, null);
            }
        }

        /////////////////////////////////////////////////////////////////

        private void ListadoVendedores_TextoBusquedaChanged(object? sender, EventArgs e)
        {
            string query = listado_vendedores.TextoBusqueda;

            Helpers.CargarVendedores(
                listado_vendedores.Grid,
                !string.IsNullOrWhiteSpace(query) && query.Length >= 3 ? query : null
            );
        }

        private void ListadoVendedores_BotonCrearClick(object? sender, EventArgs e)
        {
            using (var form = new Form_crear_vendedor())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Helpers.CargarVendedores(listado_vendedores.Grid, null);
                }
            }
        }

        private void EditarVendedor(int id)
        {
            using (var form = new Form_editar_vendedor(id))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Helpers.CargarVendedores(listado_vendedores.Grid, null);
                }
            }
        }

        private void EliminarVendedor(int id)
        {
            if (MessageBox.Show(
                "¿Seguro que querés eliminar este vendedor?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DALVendedor dal = new DALVendedor();
                dal.EliminarVendedor(id);
                Helpers.CargarVendedores(listado_vendedores.Grid, null);
            }
        }

        ///////////////////////////////
        private void ListadoClientes_TextoBusquedaChanged(object? sender, EventArgs e)
        {
            string query = listado_clientes.TextoBusqueda;

            Helpers.CargarClientes(
                listado_clientes.Grid,
                !string.IsNullOrWhiteSpace(query) && query.Length >= 3 ? query : null
            );
        }

        ///////////////////////////////
        private void ListadoEmpresas_TextoBusquedaChanged(object? sender, EventArgs e)
        {
            string query = listado_empresas.TextoBusqueda;

            Helpers.CargarEmpresas(
                listado_empresas.Grid,
                !string.IsNullOrWhiteSpace(query) && query.Length >= 3 ? query : null
            );
        }
    }
}