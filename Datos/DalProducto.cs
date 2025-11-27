using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Integrador.Entidades;

namespace Integrador.Datos
{
    public class DALProducto
    {
        public DataTable ObtenerProductos(string? pQuery)
        {
            string query = "SELECT * FROM PRODUCTO";

            if (!string.IsNullOrWhiteSpace(pQuery))
            {
                query += " WHERE NOMBRE LIKE @busqueda OR DESCRIPCION LIKE @busqueda";
            }

            query += " ORDER BY ID_PRODUCTO";

            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                if (!string.IsNullOrWhiteSpace(pQuery))
                {
                    comando.Parameters.AddWithValue("@busqueda", "%" + pQuery + "%");
                }

                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    try
                    {
                        conexion.Open();
                        adaptador.Fill(tabla);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al consultar productos: " + ex.Message);
                    }
                }
            }

            return tabla;
        }

        public Producto? ObtenerProductoPorId(int id)
        {
            Producto? producto = null;

            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;

            try
            {
                string consulta = "SELECT * FROM PRODUCTO WHERE ID_PRODUCTO = @id";
                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@id", id);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    producto = new Producto(
                        Convert.ToInt32(reader["ID_PRODUCTO"]),
                        reader["NOMBRE"].ToString() ?? "",
                        reader["DESCRIPCION"].ToString() ?? "",
                        Convert.ToDecimal(reader["PRECIOCOSTO"]),
                        Convert.ToDouble(reader["MARGEN"]),
                        Convert.ToDouble(reader["IVA"]),
                        Convert.ToDecimal(reader["PRECIOBRUTO"]),
                        Convert.ToDecimal(reader["PRECIOVENTA"]),
                        reader["PROVEEDOR"].ToString() ?? "",
                        reader["CATEGORIA"].ToString() ?? "",
                        reader["SUBCATEGORIA"].ToString() ?? ""
                    );
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener producto por ID: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

            return producto;
        }

        public void AgregarProducto(Producto p)
        {
            const string SQL = @"
                INSERT INTO PRODUCTO
                (NOMBRE, DESCRIPCION, PRECIOCOSTO, MARGEN, IVA,
                 PRECIOBRUTO, PRECIOVENTA, PROVEEDOR, CATEGORIA, SUBCATEGORIA)
                VALUES
                (@Nombre, @Descripcion, @PrecioCosto, @Margen, @Iva,
                 @PrecioBruto, @PrecioVenta, @Proveedor, @Categoria, @SubCategoria)
            ";

            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand(SQL, conexion);

            comando.Parameters.AddWithValue("@Nombre", p.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", (object?)p.Descripcion ?? DBNull.Value);
            comando.Parameters.AddWithValue("@PrecioCosto", p.PrecioCosto);
            comando.Parameters.AddWithValue("@Margen", p.Margen);
            comando.Parameters.AddWithValue("@Iva", p.IVA);
            comando.Parameters.AddWithValue("@PrecioBruto", p.PrecioBruto);
            comando.Parameters.AddWithValue("@PrecioVenta", p.PrecioVenta);
            comando.Parameters.AddWithValue("@Proveedor", (object?)p.Proveedor ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Categoria", p.Categoria);
            comando.Parameters.AddWithValue("@SubCategoria", p.SubCategoria);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }
            finally
            {
                comando.Dispose();
                conexion.Close();
                conexion.Dispose();
            }
        }

        public void EliminarProducto(int id)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;

            try
            {
                string consulta = "DELETE FROM PRODUCTO WHERE ID_PRODUCTO = @id";
                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@id", id);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el producto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }

        public void EditarProducto(Producto p)
        {
            SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;

            try
            {
                string consulta = @"
            UPDATE PRODUCTO SET
            NOMBRE = @nombre,
            DESCRIPCION = @descripcion,
            PRECIOCOSTO = @precioCosto,
            MARGEN = @margen,
            IVA = @iva,
            PRECIOBRUTO = @precioBruto,
            PRECIOVENTA = @precioVenta,
            PROVEEDOR = @proveedor,
            CATEGORIA = @categoria,
            SUBCATEGORIA = @subCategoria
            WHERE ID_PRODUCTO = @id";

                comando.CommandText = consulta;

                comando.Parameters.AddWithValue("@id", p.IdProducto);
                comando.Parameters.AddWithValue("@nombre", p.Nombre);
                comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
                comando.Parameters.AddWithValue("@precioCosto", p.PrecioCosto);
                comando.Parameters.AddWithValue("@margen", p.Margen);
                comando.Parameters.AddWithValue("@iva", p.IVA);
                comando.Parameters.AddWithValue("@precioBruto", p.PrecioBruto);
                comando.Parameters.AddWithValue("@precioVenta", p.PrecioVenta);
                comando.Parameters.AddWithValue("@proveedor", p.Proveedor);
                comando.Parameters.AddWithValue("@categoria", p.Categoria);
                comando.Parameters.AddWithValue("@subCategoria", p.SubCategoria);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al editar el producto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }
        }
    }
}