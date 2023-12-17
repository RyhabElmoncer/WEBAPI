using AutoMapper;
using Microsoft.AspNetCore.Routing.Constraints;
using WEB_API.Dtos;
using WEB_API.Models;

namespace WEB_API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
        CreateMap<Movie, MovieDetailsDto>();
            CreateMap<MovieDto, Movie>()
                .ForMember(src => src.Poster, opt => opt.Ignore());
                }
    }
}
