using ArtigoAutoMapper.API.Models;
using AutoMapper;

namespace ArtigoAutoMapper.API.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonInputModel, Person>();

            CreateMap<Person, PersonViewModel>();
        }
    }
}
