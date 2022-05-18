using Portafolio.Models;

namespace Portafolio.Services
{
    public class ProyectosRepository : IProyectosRepository
    {
        public List<ProyectoViewModel> ObtenerProyectos()
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
    }
}
