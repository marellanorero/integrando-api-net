using Microsoft.AspNetCore.Mvc;
using SistemaGestion.Modelos;
using System.Data.SqlClient;
using System.Data;
using SistemaGestion.Repositorio;

namespace SistemaGestion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        [HttpPost("")]
        public void CrearProducto(long id, string descripciones, decimal costo, decimal precioVenta, int stock, long idUsuario)
        {
            Producto producto = new Producto();
            producto.Id = id;
            producto.Descripciones = descripciones;
            producto.Costo = costo;
            producto.PrecioVenta = precioVenta;
            producto.Stock = stock;
            producto.IdUsuario = idUsuario;

            ProductoHandler.DeleteProducto(producto);
        }

        [HttpPut("")]
        public void ModificarProducto(long id, string descripciones, decimal costo, decimal precioVenta, int stock, long idUsuario)
        {
            Producto producto = new Producto();
            producto.Id = id;
            producto.Descripciones = descripciones;
            producto.Costo = costo;
            producto.PrecioVenta = precioVenta;
            producto.Stock = stock;
            producto.IdUsuario = idUsuario;

            ProductoHandler.DeleteProducto(producto);
        }

        [HttpDelete("{id}")]
        public void DeleteProducto(long id, string descripciones, decimal costo, decimal precioVenta, int stock, long idUsuario)
        {
            Producto producto = new Producto();
            producto.Id = id;
            producto.Descripciones = descripciones;
            producto.Costo = costo;
            producto.PrecioVenta = precioVenta;
            producto.Stock = stock;
            producto.IdUsuario = idUsuario;

            ProductoHandler.DeleteProducto(producto);
        }
    }
}
