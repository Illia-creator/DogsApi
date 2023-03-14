namespace DogsApi.Persistence.Pagination
{
    public class PaginationResponse<TEntity>
    {
        public IEnumerable<TEntity>? Items { get; set; }
        public bool Succeeded { get; set; }

        public PaginationResponse()
        {
            Items = new List<TEntity>();
            Succeeded = true;
        }

        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}
