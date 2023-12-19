using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using WebApp.DTO_s;
using WebApp.Infrastructure;

namespace PidzhaWEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Context _context;
        private readonly DisciplineRepository _informationRepository;
        public InfoController(Context context)
        {
            _context = context;
            _informationRepository = new InfoRepository(_context);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherDto>>> GetInfos()
        {
            var info = await _informationRepository.GetAll();
            return InformationDTOMapper.ToDto(info);
        }
    }
}