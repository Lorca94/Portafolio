using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ProyectoViewModel> proyectos = ObtenerProyectos().Take(3).ToList();
            HomeIndexViewModel modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<ProyectoViewModel> ObtenerProyectos()
        {
            return new List<ProyectoViewModel>()
            {
                new ProyectoViewModel()
                {
                    Titulo = "Proyecto 1",
                    Descripcion = "Descripcion de proyecto, tecnologia usada",
                    Link ="https://google.es",
                    ImagenUrl = "https://josefacchin.com/wp-content/uploads/2017/09/bancos-imagenes-gratis.png"
                },
                new ProyectoViewModel()
                {
                    Titulo = "Proyecto 2",
                    Descripcion = "Descripcion de proyecto, tecnologia usada",
                    Link ="https://google.es",
                    ImagenUrl = "https://josefacchin.com/wp-content/uploads/2017/09/bancos-imagenes-gratis.png"
                },
                new ProyectoViewModel()
                {
                    Titulo = "Proyecto 3",
                    Descripcion = "Descripcion de proyecto, tecnologia usada",
                    Link ="https://google.es",
                    ImagenUrl = "https://josefacchin.com/wp-content/uploads/2017/09/bancos-imagenes-gratis.png"
                },
                new ProyectoViewModel()
                {
                    Titulo = "Proyecto 4",
                    Descripcion = "Descripcion de proyecto, tecnologia usada",
                    Link ="https://google.es",
                    ImagenUrl = "https://josefacchin.com/wp-content/uploads/2017/09/bancos-imagenes-gratis.png"
                },
            };
        }

        public IActionResult Privacy()
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