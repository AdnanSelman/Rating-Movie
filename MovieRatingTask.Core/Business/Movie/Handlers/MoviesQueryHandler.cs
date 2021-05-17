using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using MovieRatingTask.Core.Business.Movie.Queries;
using MovieRatingTask.Core.Core;
using MovieRatingTask.Core.Helpers.Pagination;
using MovieRatingTask.Data.Dto;
using MovieRatingTask.Data.Models;
using MovieRatingTask.Data.Repositories.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MovieRatingTask.Core.Business.Movie.Handlers
{
    public class MoviesQueryHandler : IRequestHandler<GetMoviesQuery, CommandResponse<PagedList<MovieShowDto>>>
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        public MoviesQueryHandler(IMovieRepository movieRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public Task<CommandResponse<PagedList<MovieShowDto>>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            var data = _movieRepository.GetMovies(request.SearchKeyword).ToList();

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
