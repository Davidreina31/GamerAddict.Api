using AutoMapper;
using GamerAddict.Domain.Entity;
using GamerAddict.Dto;

namespace GamerAddict.Api.MapperProfiles
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<AnswerDTO, Answer>();
            CreateMap<Answer, AnswerDTO>();
        }
    }
}
