using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using X20240408.EntidadesDeNegocio;
using X20240408.LogicaDeNegocio;

namespace X20240408.UI.AppWebMVC.Controllers
{
    public class PersonaXController : Controller
    {
        readonly PersonaXBL _personaXBL;
        public PersonaXController(PersonaXBL personaXBL)
        {
            _personaXBL = personaXBL;
        }

        // GET: PersonaXController
        public async Task<ActionResult> Index(PersonaX personaX)
        {
            var personas = await _personaXBL.Buscar(personaX);
            return View();
        }

        // GET: PersonaXController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var persona = await _personaXBL.ObtenerPorId(new PersonaX { Id = id });
            return View(persona);
        }

        // GET: PersonaXController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaXController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaX personaX)
        {
            try
            {
                await _personaXBL.Crear(personaX);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaXController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var persona = await _personaXBL.ObtenerPorId(new PersonaX { Id = id });
            return View(persona);
        }

        // POST: PersonaXController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, PersonaX personaX)
        {
            try
            {
                await _personaXBL.Modificar(personaX);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaXController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var persona = await _personaXBL.ObtenerPorId(new PersonaX { Id = id });
            return View(persona);
        }

        // POST: PersonaXController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaX personaX)
        {
            try
            {
                await _personaXBL.Eliminar(personaX);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
