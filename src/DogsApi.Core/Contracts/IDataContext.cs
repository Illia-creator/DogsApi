using DogsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DogsApi.Core.Contracts
{
    public interface IDataContext
    {
        DbSet<DogEntity> Dogs { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
