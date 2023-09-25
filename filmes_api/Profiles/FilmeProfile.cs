using AutoMapper;
using filmes_api.Dtos;
using filmes_api.Models;

namespace filmes_api.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
    }
}