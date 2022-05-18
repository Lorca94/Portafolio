using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IProyectosRepository
    {
        List<ProyectoViewModel> ObtenerProyectos();
    }
}
