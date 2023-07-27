using AutoMapper;
using AutoMapperLearn.Models.DTO;
using AutoMapperLearn.Models.POCO;

namespace AutoMapperLearn.Configs
{
    //public class AutoMapperConfig
    //{
    //    public static Mapper InitializeAutomapper()
    //    {
    //        var config = new MapperConfiguration(cfg =>
    //        {
    //            cfg.CreateMap<Student, StudentDTO>().ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
    //        });

    //        //IMapper mapper = config.CreateMapper();
    //        var mapper = new Mapper(config);

    //        return mapper;
    //    }
    //}

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDTO>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
            CreateMap<StudentDTO, Student>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FullName.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0]))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.FullName.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]));
        }
    }

}
