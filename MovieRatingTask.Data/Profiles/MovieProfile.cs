using AutoMapper;
using MovieRatingTask.Data.Dto;
using MovieRatingTask.Data.Models;
using System.Linq;

namespace MovieRatingTask.Data.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieShow, MovieShowDto>()
            .ForMember(dest => dest.Average,
                        opt => opt.MapFrom(src => src.MovieShowRatings.Average(x => x.Stars)));
        }
    }
}