using Microsoft.AspNetCore.Mvc;
using WebApp.Infrastructure;
using Infrastructure.Interfaces;

namespace WebApp.API.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class OWNController : ControllerBase
    {
        private readonly Context _context;
        private readonly Discipl _individualRepository;

    }
}
