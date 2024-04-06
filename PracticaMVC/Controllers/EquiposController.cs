using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaMVC.Models;

namespace PracticaMVC.Controllers
{
    public class EquiposController : Controller
    {
        private readonly equiposDbContext _equiposDbContext;

        public EquiposController(equiposDbContext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }
        public IActionResult Index()
        {
            var listaDeMarcas = (from m in _equiposDbContext.marcas
                                 select m).ToList();
            ViewData["ListadoDeMarcas"] = new SelectList(listaDeMarcas, "id_marcas", "nombre_marca");

            var listaDeTipoEquipos = (from m in _equiposDbContext.tipo_equipo
                                 select m).ToList();
            ViewData["ListadoDeTipoEquipos"] = new SelectList(listaDeTipoEquipos, "id_tipo_equipo", "descripcion");

            var listaDeTipoEstados = (from m in _equiposDbContext.estados_equipo
                                      select m).ToList();
            ViewData["ListadoDeTipoEstados"] = new SelectList(listaDeTipoEstados, "id_estados_equipo", "estados");

            var listadoDeEquipos = (from e in _equiposDbContext.equipos
                                    join m in _equiposDbContext.marcas on e.id_marca equals m.id_marcas
                                    select new
                                    {
                                        nombre = e.nombre,
                                        descripcion = e.descripcion,
                                        id_marca = e.id_marca,
                                        nombre_marca = m.nombre_marca

                                    }).ToList();

            ViewData["listadoEquipos"] = listadoDeEquipos;

            return View();
        }

        public IActionResult CrearEquipos(equipos nuevoEquipo)
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
