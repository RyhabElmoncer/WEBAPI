using Microsoft.AspNetCore.Mvc;
using WEB_API.Dtos;
using WEB_API.Models;
using WEB_API.Services;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : Controller
    {
        private readonly IGenresService _genresService;
        public GenresController(IGenresService genresService)
        {
            _genresService = genresService;
        }
        [HttpGet]
        public async Task< IActionResult> GetAllAsync()
        {
            var generes = await _genresService.GetAll();
            return Ok(generes);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(GenreDto dto)
        {
            var genre = new Genre { Name = dto.Name };
            await _genresService.Add(genre);
            return Ok(genre);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(byte id, [FromBody] GenreDto dto)
        {
            var genre = await _genresService.GetById(id);
            if (genre == null)
                return NotFound($"No genre was found with ID: {id}");
            genre.Name = dto.Name;
            _genresService.Update(genre);
            return Ok(genre);
        }

    }
}
