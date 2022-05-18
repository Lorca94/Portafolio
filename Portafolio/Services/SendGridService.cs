using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio.Services
{
    public class SendGridService : ISendGridService
    {
        private readonly IConfiguration _configuration;
        public SendGridService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Enviar(ContactoViewModel contacto)
        {
            var apiKey = _configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = _configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = _configuration.GetValue<string>("SENDGRID_NOMBRE");

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(email);
            var subject = $"El cliente { contacto.Email} quiere contactar contigo:";
            var to = new EmailAddress(email, nombre);
            var mensaje = contacto.Mensaje;
            var contenidoHtml = @$"De: {contacto.Nombre} -
Email: {contacto.Email}
Mensaje: {contacto.Mensaje}";
            var singleEmail = MailHelper.CreateSingleEmail(from,to,subject,mensaje,contenidoHtml);

            var respuesta = await client.SendEmailAsync(singleEmail);
        }
    }
}
