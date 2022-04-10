using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWalkingSkeleton.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        private readonly DataContext _context;

        public SuperHeroController(ISuperHeroService superHeroService, DataContext context)
        {
            _superHeroService = superHeroService;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAll()
        {
            return Ok(await _superHeroService.GetAll());
        }
    }
}
