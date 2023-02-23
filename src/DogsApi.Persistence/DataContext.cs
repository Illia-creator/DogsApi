using DogsApi.Entities;
using DogsApi.Entities.EntityAbstracts;
using Microsoft.EntityFrameworkCore;

namespace DogsApi.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<DogEntity> Dogs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DogEntity>(options =>
            {
                options.OwnsOne(x => x.Color);
                options.OwnsOne(x => x.Name);
                options.OwnsOne(x => x.TailLenth);
                options.OwnsOne(x => x.Weight);
                options.HasKey(x => x.Id);
            });
            base.OnModelCreating(builder);
        }
    }
}
