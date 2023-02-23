using DogsApi.Entities;
using DogsApi.Entities.Dto;
using DogsApi.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DogsApi.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IDogRepository repository;
        public DogController(IDogRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DogEntity>>> GetDogs()
        {
            var result = await repository.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DogEntity>> GetDog(int id)
        {
            var result = await repository.GetOne(id);
            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreatetDog(CreateDogDto createDogDto) 
        {
            var result = new DogEntity
            {
                Color = createDogDto.Color,
                Name = createDogDto.Name,
                TailLenth = createDogDto.TailLenth,
                Weight = createDogDto.Weight
            };
            await repository.Add(result);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeeteDog(int id)
        { 
            await repository.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateDog(int id, UpdateDogDto updateDogDto)
        {
            var result = new DogEntity
            {
                Id= updateDogDto.Id,
                Color = updateDogDto.Color,
                Name = updateDogDto.Name,
                TailLenth = updateDogDto.TailLenth,
                Weight = updateDogDto.Weight
            };

            await repository.Update(result);
            return Ok();
        }
    }
}
