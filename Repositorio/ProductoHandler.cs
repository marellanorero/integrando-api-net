using SistemaGestion.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGestion.Repositorio
{
    public class ProductoHandler
    {
        private static string cadenaConexion = "Data Source=Lauri;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static int DeleteProducto(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuario(Descripciones, Costo, PrecioVenta, Stock, IdUsuario) " +
                    "VALUES (@descripciones, @costo, @precioVenta, @stock, @idUsuario)", conn);

                cmd.Parameters.AddWithValue("@descripciones", producto.Descripciones);
                cmd.Parameters.AddWithValue("@costo", producto.Costo);
                cmd.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@idUsuario", producto.IdUsuario);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int ModificarProducto(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Producto SET Costo = @nombreUsuario WHERE Id = @id", conn);
                SqlParameter produtoParam = new SqlParameter();
                produtoParam.ParameterName = "descripciones";
                produtoParam.SqlDbType = SqlDbType.VarChar;
                produtoParam.Value = producto.Descripciones;

                SqlParameter descripcionesParam = new SqlParameter("descripciones", producto.Descripciones);
                SqlParameter costoParam = new SqlParameter("costo", producto.Costo);
                SqlParameter precioVentaParam = new SqlParameter("precioVenta", producto.PrecioVenta);
                SqlParameter stockParam = new SqlParameter("stock", producto.Stock);
                SqlParameter idUsuarioParam = new SqlParameter("isUsuario", producto.IdUsuario);

                cmd.Parameters.Add(descripcionesParam);
                cmd.Parameters.Add(costoParam);
                cmd.Parameters.Add(precioVentaParam);
                cmd.Parameters.Add(stockParam);
                cmd.Parameters.Add(idUsuarioParam);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int DeleteProducto(long id)
        {
            using(SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Producto WHERE id=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);
                conn.Open() ;

                return cmd.ExecuteNonQuery();
            }
        }

    }

   
}
