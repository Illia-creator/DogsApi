using DogsApi.Entities;
using DogsApi.Persistence.Pagination;

namespace DogsApi.Persistence.Repositories
{
    public interface IDogRepository
    {
        string GetVersion();
        Task<DogEntity> GetOne(int id);
        Task<PaginationResponse<DogEntity>> GetAll(int pageNumber, int pageSize);
        Task Delete(int id);
        Task Add(DogEntity entity);
        Task Update(DogEntity entity);
    } 
}
