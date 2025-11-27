using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Integrador.Entidades;

namespace Integrador.Datos
{
    public class DALCliente
    {
        public DataTable ObtenerClientes(string? textoBusqueda)
        {
            DataTable tabla = new DataTable();

            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                string sql = @"
                    SELECT ID, NOMBRE, APELLIDO, CUIT, MAIL, TELEFONO, DIRECCION
                    FROM CLIENTEINDIVIDUO";

                if (!string.IsNullOrWhiteSpace(textoBusqueda))
                {
                    sql += @"
                        WHERE NOMBRE   LIKE @busqueda
                           OR APELLIDO LIKE @busqueda
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
                throw new Exception("Error al consultar clientes: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

            return tabla;
        }

        public void AgregarCliente(ClienteIndividuo c)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();

            try
            {
                string sql = @"
                    INSERT INTO CLIENTEINDIVIDUO
                        (NOMBRE, APELLIDO, CUIT, MAIL, TELEFONO, DIRECCION)
                    VALUES
                        (@nombre, @apellido, @cuit, @mail, @telefono, @direccion)";

                comando.Connection = conexion;
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@apellido", c.Apellido);
                comando.Parameters.AddWithValue("@cuit", (object?)c.Cuit ?? DBNull.Value);
                comando.Parameters.AddWithValue("@mail", (object?)c.Mail ?? DBNull.Value);
                comando.Parameters.AddWithValue("@telefono", (object?)c.Telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@direccion", (object?)c.Direccion ?? DBNull.Value);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar cliente: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public void ActualizarCliente(ClienteIndividuo c)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();

            try
            {
                string sql = @"
                    UPDATE CLIENTEINDIVIDUO
                    SET NOMBRE    = @nombre,
                        APELLIDO  = @apellido,
                        CUIT      = @cuit,
                        MAIL      = @mail,
                        TELEFONO  = @telefono,
                        DIRECCION = @direccion
                    WHERE ID = @id";

                comando.Connection = conexion;
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("@id", c.ID);
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@apellido", c.Apellido);
                comando.Parameters.AddWithValue("@cuit", (object?)c.Cuit ?? DBNull.Value);
                comando.Parameters.AddWithValue("@mail", (object?)c.Mail ?? DBNull.Value);
                comando.Parameters.AddWithValue("@telefono", (object?)c.Telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@direccion", (object?)c.Direccion ?? DBNull.Value);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public void EliminarCliente(int idCliente)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();

            try
            {
                string sql = @"DELETE FROM CLIENTEINDIVIDUO WHERE ID = @id";

                comando.Connection = conexion;
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@id", idCliente);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public ClienteIndividuo? ObtenerClientePorId(int idCliente)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            ClienteIndividuo? cliente = null;

            try
            {
                string sql = @"
                    SELECT ID, NOMBRE, APELLIDO, CUIT, MAIL, TELEFONO, DIRECCION
                    FROM CLIENTEINDIVIDUO
                    WHERE ID = @id";

                comando.Connection = conexion;
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@id", idCliente);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new ClienteIndividuo(
                        id: idCliente,
                        nombre: reader["NOMBRE"].ToString() ?? "",
                        apellido: reader["APELLIDO"].ToString() ?? "",
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
                throw new Exception("Error al obtener cliente: " + ex.Message);
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