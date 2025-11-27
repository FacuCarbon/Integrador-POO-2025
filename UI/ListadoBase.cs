namespace Integrador.UI
{
    public partial class ListadoBase : UserControl
    {
        public event EventHandler? BotonCrearClick;
        public event EventHandler? TextoBusquedaChanged;
        public event Action<int>? EditarClick;
        public event Action<int>? EliminarClick;

        public ListadoBase()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            searchbar.TextChanged += Searchbar_TextChanged;
            dataGridView1.CellContentClick += Grid_CellContentClick;
        }

        public string Titulo
        {
            get => title_listado_base.Text;
            set
            {
                title_listado_base.Text = value;
                searchbar.PlaceholderText = $"Buscar en {value.ToLower()}...";
            }
        }

        public DataGridView Grid => dataGridView1;

        private void Boton_crear_base_Click(object? sender, EventArgs e)
        {
            BotonCrearClick?.Invoke(this, EventArgs.Empty);
        }

        public string TextoBusqueda
        {
            get => searchbar.Text;
            set => searchbar.Text = value;
        }

        private void Searchbar_TextChanged(object? sender, EventArgs e)
        {
            TextoBusquedaChanged?.Invoke(this, EventArgs.Empty);
        }

        private void Grid_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string col = Grid.Columns[e.ColumnIndex].Name;
            int id = Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[0].Value);

            if (col == "ColEditar")
                EditarClick?.Invoke(id);

            if (col == "ColEliminar")
                EliminarClick?.Invoke(id);
        }
    }
}
