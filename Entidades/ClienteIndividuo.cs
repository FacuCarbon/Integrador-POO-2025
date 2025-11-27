namespace Integrador.Entidades
{
    public class ClienteIndividuo : Cliente
    {
        public string Apellido { get; set; }

        public ClienteIndividuo(
            string nombre,
            string apellido,
            string? cuit = null,
            string? mail = null,
            string? telefono = null,
            string? direccion = null
        ) : base(nombre, cuit, mail, telefono, direccion)
        {
            Apellido = apellido;
        }

        public ClienteIndividuo(
            int id,
            string nombre,
            string apellido,
            string? cuit,
            string? mail,
            string? telefono,
            string? direccion
        ) : base(id, nombre, cuit, mail, telefono, direccion)
        {
            Apellido = apellido;
        }
    }
}