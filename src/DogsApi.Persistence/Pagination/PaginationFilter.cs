namespace DogsApi.Persistence.Pagination
{
    public class PaginationFilter
    {
        private int pageNumber;
        private int pageSize;

        public PaginationFilter(int pageNumber, int pageSize)
        {
            this.pageNumber = pageNumber;
            this.pageSize = pageSize;
        }

        public int PageNumber
        {
            get => pageNumber;
            set => pageNumber = value < 1 ? 1 : value;
        }

        public int PageSize
        {
            get => pageSize;
            set => pageSize = value > 3 ? 3 : value;
        }
    }
}
