using AutoMapper;
using MovieRatingTask.Data.Dto;
using MovieRatingTask.Data.Models;
using System.Linq;

namespace MovieRatingTask.Core.Business.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieShow, MovieShowDto>()
            .ForMember(dest => dest.Average,
                        opt => opt.MapFrom(src => src.MovieShowRatings.Count > 0 ? src.MovieShowRatings.Average(x => x.Stars) : 0))
            .ForMember(dest => dest.Actors,
                        opt => opt.MapFrom(src => src.CastMovie.Cast.CastActors.Select(y => y.Actor)));
        }
    }
}