using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using MovieRatingTask.Core.Business.Show.Queries;
using MovieRatingTask.Core.Core;
using MovieRatingTask.Core.Helpers.Pagination;
using MovieRatingTask.Data.Dto;
using MovieRatingTask.Data.Repositories.Show;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MovieRatingTask.Core.Business.Show.Handlers
{
    public class ShowsQueryHandler : IRequestHandler<GetShowsQuery, CommandResponse<PagedList<MovieShowDto>>>
    {
        private readonly IShowRepository _showRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        public ShowsQueryHandler(IShowRepository showRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _showRepository = showRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public Task<CommandResponse<PagedList<MovieShowDto>>> Handle(GetShowsQuery request, CancellationToken cancellationToken)
        {
            var data = _showRepository.GetShows(request.SearchKeyword);

            var dtos = data.Select(x =>
              _mapper.Map<MovieShowDto>(x)
            ).AsQueryable();

            var paggedResult = PagedList<MovieShowDto>.Create(dtos, request.PageNumber, request.PageSize);

            var paginationMetadata = new
            {
                totalCount = paggedResult.TotalCount,
                pageSize = paggedResult.PageSize,
                currentPage = paggedResult.CurrentPage,
                totalPages = paggedResult.TotalPages
            };

            _httpContextAccessor.HttpContext.Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetadata));

            return Task.FromResult(CommandResponse<PagedList<MovieShowDto>>.Ok(paggedResult));
        }
    }
}