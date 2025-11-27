using System;

namespace Integrador.Datos
{
    public class Conexion
    {
        private static readonly string Server = @"MASTER\SQLEXPRESS";
        private static readonly string BaseDatos = "INTEGRADORNET";

        public static string CadenaConexion =>
            $@"Server={Server}; Initial Catalog={BaseDatos}; Integrated Security=True; TrustServerCertificate=True;";
      
    }
}
