using DogsApi.Core.Contracts;
using DogsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DogsApi.Core
{
    public class DataContext :DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<DogEntity> Dogs { get; set; }
    }
}
