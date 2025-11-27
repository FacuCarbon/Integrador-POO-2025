using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Integrador.Entidades;

namespace Integrador.Datos
{
    public class DALVendedor
    {
        public DataTable ObtenerVendedores(string? textoBusqueda)
        {
            DataTable tabla = new DataTable();

            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                string sql = @"
                    SELECT ID_VENDEDOR, NOMBRE, APELLIDO, DNI, CUIT
                    FROM VENDEDOR";

                if (!string.IsNullOrWhiteSpace(textoBusqueda))
                {
                    sql += " WHERE NOMBRE LIKE @busqueda OR APELLIDO LIKE @busqueda OR DNI LIKE @busqueda";
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
                throw new Exception("Error al consultar vendedores: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

            return tabla;
        }

        public void AgregarVendedor(Vendedor v)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();

            try
            {
                string sql = @"
                    INSERT INTO VENDEDOR (NOMBRE, APELLIDO, DNI, CUIT)
                    VALUES (@nombre, @apellido, @dni, @cuit)";

                comando.Connection = conexion;
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("@nombre", v.Nombre);
                comando.Parameters.AddWithValue("@apellido", v.Apellido);
                comando.Parameters.AddWithValue("@dni", v.Dni);
                comando.Parameters.AddWithValue("@cuit", v.Cuit);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar vendedor: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public void ActualizarVendedor(Vendedor v)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();

            try
            {
                string sql = @"
                    UPDATE VENDEDOR
                    SET NOMBRE = @nombre,
                        APELLIDO = @apellido,
                        DNI = @dni,
                        CUIT = @cuit
                    WHERE ID_VENDEDOR = @id";

                comando.Connection = conexion;
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("@nombre", v.Nombre);
                comando.Parameters.AddWithValue("@apellido", v.Apellido);
                comando.Parameters.AddWithValue("@dni", v.Dni);
                comando.Parameters.AddWithValue("@cuit", v.Cuit);
                comando.Parameters.AddWithValue("@id", v.IdVendedor);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar vendedor: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public void EliminarVendedor(int idVendedor)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();

            try
            {
                string sql = @"DELETE FROM VENDEDOR WHERE ID_VENDEDOR = @id";

                comando.Connection = conexion;
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@id", idVendedor);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar vendedor: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public Vendedor? ObtenerVendedorPorId(int idVendedor)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            Vendedor? vendedor = null;

            try
            {
                string sql = @"
                    SELECT ID_VENDEDOR, NOMBRE, APELLIDO, DNI, CUIT
                    FROM VENDEDOR
                    WHERE ID_VENDEDOR = @id";

                comando.Connection = conexion;
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@id", idVendedor);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    vendedor = new Vendedor(
                        idVendedor,
                        reader["NOMBRE"].ToString() ?? "",
                        reader["APELLIDO"].ToString() ?? "",
                        reader["DNI"].ToString() ?? "",
                        reader["CUIT"].ToString() ?? ""
                    );
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener vendedor: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

            return vendedor;
        }
    }
}
