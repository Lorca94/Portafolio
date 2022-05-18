using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISendGridService _sendGridService;
        private readonly IProyectosRepository _repo;
        public HomeController(ILogger<HomeController> logger, IProyectosRepository repo, ISendGridService sendGridService)
        {
            _logger = logger;
            _repo = repo;
            _sendGridService = sendGridService;
        }

        public IActionResult Index()
        {
            List<ProyectoViewModel> proyectos = _repo.ObtenerProyectos().Take(3).ToList();
            HomeIndexViewModel modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            List<ProyectoViewModel> proyectos = _repo.ObtenerProyectos().ToList();
            return View(proyectos);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            await _sendGridService.Enviar(contactoViewModel);
            return RedirectToAction("MensajeAgradecimiento");
        }

        public IActionResult MensajeAgradecimiento()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}