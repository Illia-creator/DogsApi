using DogsApi.Entities;
using DogsApi.Persistence.Pagination;

namespace DogsApi.Persistence.Repositories
{
    public class DogRepository : IDogRepository
    {
        private readonly DataContext context;

        public DogRepository(DataContext context)
        {
            this.context = context;
        }
        public string GetVersion()
        {
            return "Dogs house service. Version 1.0.1";
        }
        public async Task Add(DogEntity entity)
        {
            var addingEntity = context.Dogs.Where(x => x.Name.Value == entity.Name.Value);
            if (addingEntity.Any()) { throw new Exception("Such Dog Is Exist"); }
            context.Dogs.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var itemToDelete = await context.Dogs.FindAsync(id);
            if (itemToDelete is null)
            {
                throw new Exception("Item Do Not Exist");
            }
            else
            {
                context.Dogs.Remove(itemToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task<DogEntity> GetOne(int id)
        {
            var itemToFind = await context.Dogs.FindAsync(id);
            if (itemToFind is null) { throw new NullReferenceException(); }
            else
            {
                return itemToFind;
            }
        }

        public async Task Update(DogEntity entity)
        {
            var itemToUpdate = await context.Dogs.FindAsync(entity.Id);
            if (itemToUpdate is null) { throw new NullReferenceException(); }
            else
            {
                itemToUpdate.Color = entity.Color;
                itemToUpdate.Name = entity.Name;
                itemToUpdate.Weight = entity.Weight;
                itemToUpdate.TailLength = entity.TailLength;
                await context.SaveChangesAsync();
            }
        }

        public async Task<PaginationResponse<DogEntity>> GetAll(double? weight, int pageNumber, int pageSize)
        {
            IQueryable<DogEntity> dogs;
            PaginationFilter filter = new PaginationFilter(pageNumber, pageSize);
            PaginationResponse<DogEntity> query = new PaginationResponse<DogEntity>();
            if (weight != null)
            {
                dogs = context.Dogs.Where(x => x.Weight.Value <= weight).OrderByDescending(x => x.Weight.Value);
                query = await dogs.PaginateAsync(filter);
            }
            else { query = await context.Dogs.PaginateAsync(filter); }

            return query;
        }
    }
}
