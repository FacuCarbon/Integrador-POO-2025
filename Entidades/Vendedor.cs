namespace Integrador.Entidades
{
    public class Vendedor
    {
        public int IdVendedor { get; private set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Cuit { get; set; } = string.Empty;

        public Vendedor(string nombre, string apellido, string dni, string cuit)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Cuit = cuit;
        }

        public Vendedor(int idVendedor, string nombre, string apellido, string dni, string cuit)
            : this(nombre, apellido, dni, cuit)
        {
            IdVendedor = idVendedor;
        }
    }
}