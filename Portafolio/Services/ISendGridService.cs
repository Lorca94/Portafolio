using Portafolio.Models;

namespace Portafolio.Services
{
    public interface ISendGridService
    {
        Task Enviar(ContactoViewModel contacto);
    }
}
