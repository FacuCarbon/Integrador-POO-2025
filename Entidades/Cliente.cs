namespace Integrador.Entidades
{
    public abstract class Cliente
    {
        public int ID { get; private set; }

        public string Nombre { get; set; }
        public string? Cuit { get; set; }
        public string? Mail { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }

        protected Cliente(string nombre, string? cuit = null, string? mail = null, string? telefono = null, string? direccion = null)
        {
            Nombre = nombre;
            Cuit = cuit;
            Mail = mail;
            Telefono = telefono;
            Direccion = direccion;
        }

        protected Cliente(int id, string nombre, string? cuit, string? mail, string? telefono, string? direccion)
        {
            ID = id;
            Nombre = nombre;
            Cuit = cuit;
            Mail = mail;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}