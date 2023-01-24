using AutoMapper;
using GamerAddict.Domain.Entity;
using GamerAddict.Dto;

namespace GamerAddict.Api.MapperProfiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<AnswerDTO, Answer>();
            CreateMap<Answer, AnswerDTO>();
            CreateMap<CityDTO, City>().ReverseMap();
            CreateMap<CommentDTO, Comment>().ReverseMap();
            CreateMap<DeveloperDTO, Developer>().ReverseMap();
            CreateMap<Plateform_VideoGameDTO, Plateform_VideoGame>().ReverseMap();
            CreateMap<PlateformDTO, Plateform>().ReverseMap();
            CreateMap<PublisherDTO, Publisher>().ReverseMap();
            CreateMap<QuestionDTO, Question>().ReverseMap();
            CreateMap<ReportDTO, Report>().ReverseMap();
            CreateMap<User_VideoGameDTO, User_VideoGame>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<VideoGameDTO, VideoGame>().ReverseMap();
        }
    }
}
