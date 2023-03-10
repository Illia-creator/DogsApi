using DogsApi.Entities;

namespace DogsApi.Persistence.Repositories
{
    public interface IDogRepository
    {
        string GetVersion();
        Task<DogEntity> GetOne(int id);
        Task<IEnumerable<DogEntity>> GetAll();
        Task Delete(int id);
        Task Add(DogEntity entity);
        Task Update(DogEntity entity);
    } 
}
