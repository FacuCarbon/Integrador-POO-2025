namespace Integrador.Entidades
{
    public class Producto
    {
        public int IdProducto { get; private set; }

        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto { get; set; }
        public decimal PrecioVenta { get; set; }

        public string Proveedor { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string SubCategoria { get; set; } = string.Empty;

        public Producto(string nombre,
                        string descripcion,
                        decimal precioCosto,
                        double margen,
                        double iva,
                        decimal precioBruto,
                        decimal precioVenta,
                        string proveedor,
                        string categoria,
                        string subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iva;
            PrecioBruto = precioBruto;
            PrecioVenta = precioVenta;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }

        public Producto(int idProducto,
                        string nombre,
                        string descripcion,
                        decimal precioCosto,
                        double margen,
                        double iva,
                        decimal precioBruto,
                        decimal precioVenta,
                        string proveedor,
                        string categoria,
                        string subCategoria)
            : this(nombre, descripcion, precioCosto, margen, iva, precioBruto, precioVenta, proveedor, categoria, subCategoria)
        {
            IdProducto = idProducto;
        }
    }
}