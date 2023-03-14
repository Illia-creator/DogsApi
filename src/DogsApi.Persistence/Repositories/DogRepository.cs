using DogsApi.Entities;
using DogsApi.Persistence.Pagination;
using Microsoft.EntityFrameworkCore;
using System.Windows.Markup;

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
                itemToUpdate.TailLenth = entity.TailLenth;
                await context.SaveChangesAsync();
            }
        }

        public async Task<PaginationResponse<DogEntity>> GetAll(int pageNumber, int pageSize)
        {
            PaginationFilter filter = new PaginationFilter(pageNumber, pageSize);
            var query = await context.Dogs.PaginateAsync(filter);
            return query;
        }
    }
}
