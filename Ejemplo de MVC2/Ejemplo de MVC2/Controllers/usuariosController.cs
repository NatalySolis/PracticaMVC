using Ejemplo_de_MVC2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;


namespace Ejemplo_de_MVC2.Controllers

{
    public class usuariosController : ControllerBase
    {
        private readonly usuariosContext _usuariosContexto;

        public usuariosController(usuariosContext usuariosContexto)
        {
            _usuariosContexto = usuariosContexto;
        }
    }
}
