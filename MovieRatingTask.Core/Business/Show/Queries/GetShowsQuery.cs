using MediatR;
using MovieRatingTask.Core.Base;
using MovieRatingTask.Core.Core;
using MovieRatingTask.Core.Helpers.Pagination;
using MovieRatingTask.Data.Dto;

namespace MovieRatingTask.Core.Business.Show.Queries
{
    public class GetShowsQuery : BasePaginationQuery, IRequest<CommandResponse<PagedList<MovieShowDto>>>
    {
        public string SearchKeyword { get; set; }
    }
}