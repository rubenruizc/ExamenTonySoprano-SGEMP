using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Saldria un menú donde estaría un scroll que al abrirlo saldria el listado de Misiones
        public IActionResult Index()
        {
            return View();
        }

        // Una vez cogida la misión se vería la lista de candidatos validos(gracias a la funcion de candidatosValidos)
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }

        // Una vez haberle dado al apartado detalles saldran el listado de candidatos validos con todos sus detalles en específico
        public IActionResult DetallesCandidatos()
        {
            return View();
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
