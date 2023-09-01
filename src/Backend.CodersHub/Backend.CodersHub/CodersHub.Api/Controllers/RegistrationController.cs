using Backend.CodersHub.Services.RegistrationServices;
using Microsoft.AspNetCore.Mvc;

namespace CodersHub.Api.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationController()
        {
            _registrationService = new RegistrationService();
        }

        [HttpPost("firstname, lastname, bio, email address, password")]
        public Guid Register(string firstName, string lastName, string bio, string emailAddress, string password)
        {
            return _registrationService.Register(firstName, lastName, bio, emailAddress, password);
        }

        [HttpPost("email address, password")]
        public Guid Login(string emailAddress, string password)
        {
            return _registrationService.Login(emailAddress, password);
        }
    }
}
