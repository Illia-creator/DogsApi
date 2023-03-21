using DogsApi.Entities;
using DogsApi.Entities.Dto;
using DogsApi.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace DogsApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IDogRepository repository;
        public DogController(IDogRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("dogs")]
        public async Task<IActionResult> GetDogs(double? weight, int pageNumber, int pageSize)
        {
            var result = await repository.GetAll(weight, pageNumber, pageSize);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDog(int id)
        {
            var result = await repository.GetOne(id);
            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreatetDog(CreateDogDto createDogDto)
        {
            var result = new DogEntity
            {
                Color = createDogDto.Color,
                Name = createDogDto.Name,
                TailLength = createDogDto.TailLength,
                Weight = createDogDto.Weight
            };
            await repository.Add(result);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDog(int id)
        {
            await repository.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDog(int id, UpdateDogDto updateDogDto)
        {
            var result = new DogEntity
            {
                Id = updateDogDto.Id,
                Color = updateDogDto.Color,
                Name = updateDogDto.Name,
                TailLength = updateDogDto.TailLength,
                Weight = updateDogDto.Weight
            };

            await repository.Update(result);
            return Ok();
        }

        [HttpGet("/Ping")]
        public IActionResult GetVersion()
        {
            return Ok(repository.GetVersion());
        }
    }
}
