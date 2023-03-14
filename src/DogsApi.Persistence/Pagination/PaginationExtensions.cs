using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsApi.Persistence.Pagination
{
    public static class PaginationExtensions
    {
        public static async Task<PaginationResponse<TEntity>> PaginateAsync<TEntity>(
            this IQueryable<TEntity> query, PaginationFilter filter, CancellationToken token = default)
        { 
            var response = new PaginationResponse<TEntity>();

            response.CurrentPage = filter.PageNumber;
            response.PageSize = filter.PageSize;
            response.TotalItems = await query.CountAsync(token);
            
            response.Items = await query
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take((filter.PageSize))
                .ToListAsync();

            response.TotalPages = (int)Math.Ceiling(response.TotalItems / (double)filter.PageSize);

            return response;
        }
    }
}
