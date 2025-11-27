using System;
using Microsoft.Data.SqlClient;
using Integrador.Entidades;


namespace Integrador.Datos
{
    public class DALUsuario
    {
        public Usuario? Login(string login, string password)
        {
            Usuario? usuario = null;

            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;

            try
            {
                string consulta = @"
                    SELECT LOGIN, APELLYNOM, PASSW, FCH_ALTA, FCH_BAJA
                    FROM USUARIO
                    WHERE LOGIN = @login AND PASSW = @passw
                      AND (FCH_BAJA IS NULL)";

                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@login", login);
                comando.Parameters.AddWithValue("@passw", password);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario(
                        reader["LOGIN"].ToString() ?? "",
                        reader["APELLYNOM"].ToString() ?? "",
                        reader["PASSW"].ToString() ?? "",
                        Convert.ToDateTime(reader["FCH_ALTA"]),
                        reader["FCH_BAJA"] == DBNull.Value
                            ? (DateTime?)null
                            : Convert.ToDateTime(reader["FCH_BAJA"])
                    );
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

            return usuario;
        }
    }
}