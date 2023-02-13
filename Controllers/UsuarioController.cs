using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion.Modelos;
using SistemaGestion.Repositorio;

namespace SistemaGestion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPut("")]
        public void ModificarUsuario(long id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            usuario.Nombre= nombre;
            usuario.Apellido= apellido;
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contraseña = contraseña;
            usuario.Mail = mail;

            UsuarioHandler.ModificarUsuario(usuario);
        }
    }
}

