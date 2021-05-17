namespace MovieRatingTask.Core.Base
{
    public class BasePaginationQuery
    {
        const int _maxPageSize = 5000;

        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > _maxPageSize) ? _maxPageSize : value;
        }
    }
}