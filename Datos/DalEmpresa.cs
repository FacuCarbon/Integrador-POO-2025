using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Integrador.Entidades;

namespace Integrador.Datos
{
    public class DALEmpresa
    {
        public DataTable ObtenerEmpresas(string? textoBusqueda)
        {
            DataTable tabla = new DataTable();

            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                string sql = @"
                    SELECT ID, NOMBRE, CONTACTO, CUIT, MAIL, TELEFONO, DIRECCION
                    FROM CLIENTEEMPRESA";

                if (!string.IsNullOrWhiteSpace(textoBusqueda))
                {
                    sql += @"
                        WHERE NOMBRE   LIKE @busqueda
                           OR CONTACTO LIKE @busqueda
                           OR CUIT     LIKE @busqueda
                           OR MAIL     LIKE @busqueda";
                }

                comando.Connection = conexion;
                comando.CommandText = sql;

                if (!string.IsNullOrWhiteSpace(textoBusqueda))
                {
                    comando.Parameters.AddWithValue("@busqueda", "%" + textoBusqueda + "%");
                }

                adaptador.SelectCommand = comando;

                conexion.Open();
                adaptador.Fill(tabla);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al consultar empresas: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

            return tabla;
        }

        public void AgregarEmpresa(ClienteEmpresa c)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();

            try
            {
                string sql = @"
                    INSERT INTO CLIENTEEMPRESA
                        (NOMBRE, CONTACTO, CUIT, MAIL, TELEFONO, DIRECCION)
                    VALUES
                        (@nombre, @contacto, @cuit, @mail, @telefono, @direccion)";

                comando.Connection = conexion;
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@contacto", c.Contacto);
                comando.Parameters.AddWithValue("@cuit", (object?)c.Cuit ?? DBNull.Value);
                comando.Parameters.AddWithValue("@mail", (object?)c.Mail ?? DBNull.Value);
                comando.Parameters.AddWithValue("@telefono", (object?)c.Telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@direccion", (object?)c.Direccion ?? DBNull.Value);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar empresa: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public void ActualizarEmpresa(ClienteEmpresa c)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();

            try
            {
                string sql = @"
                    UPDATE CLIENTEEMPRESA
                    SET NOMBRE    = @nombre,
                        CONTACTO  = @contacto,
                        CUIT      = @cuit,
                        MAIL      = @mail,
                        TELEFONO  = @telefono,
                        DIRECCION = @direccion
                    WHERE ID = @id";

                comando.Connection = conexion;
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("@id", c.ID);
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@contacto", c.Contacto);
                comando.Parameters.AddWithValue("@cuit", (object?)c.Cuit ?? DBNull.Value);
                comando.Parameters.AddWithValue("@mail", (object?)c.Mail ?? DBNull.Value);
                comando.Parameters.AddWithValue("@telefono", (object?)c.Telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@direccion", (object?)c.Direccion ?? DBNull.Value);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar empresa: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public void EliminarEmpresa(int idCliente)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();

            try
            {
                string sql = @"DELETE FROM CLIENTEEMPRESA WHERE ID = @id";

                comando.Connection = conexion;
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@id", idCliente);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar empresa: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public ClienteEmpresa? ObtenerEmpresaPorId(int idCliente)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            ClienteEmpresa? cliente = null;

            try
            {
                string sql = @"
                    SELECT ID, NOMBRE, CONTACTO, CUIT, MAIL, TELEFONO, DIRECCION
                    FROM CLIENTEEMPRESA
                    WHERE ID = @id";

                comando.Connection = conexion;
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@id", idCliente);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new ClienteEmpresa(
                        id: idCliente,
                        nombre: reader["NOMBRE"].ToString() ?? "",
                        contacto: reader["CONTACTO"].ToString() ?? "",
                        cuit: reader["CUIT"] as string,
                        mail: reader["MAIL"] as string,
                        telefono: reader["TELEFONO"] as string,
                        direccion: reader["DIRECCION"] as string
                    );
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener empresa: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

            return cliente;
        }
    }
}