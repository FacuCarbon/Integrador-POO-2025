namespace Integrador.Entidades
{
    public class ClienteEmpresa : Cliente
    {
        public string? Contacto { get; set; }

        public ClienteEmpresa(
            string nombre,
            string? contacto = null,
            string? cuit = null,
            string? mail = null,
            string? telefono = null,
            string? direccion = null
        ) : base(nombre, cuit, mail, telefono, direccion)
        {
            Contacto = contacto;
        }

        public ClienteEmpresa(
            int id,
            string nombre,
            string? contacto,
            string? cuit,
            string? mail,
            string? telefono,
            string? direccion
        ) : base(id, nombre, cuit, mail, telefono, direccion)
        {
            Contacto = contacto;
        }
    }
}