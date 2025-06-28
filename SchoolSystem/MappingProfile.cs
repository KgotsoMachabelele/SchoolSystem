using AutoMapper;
using DataModels.DBModels;

namespace SchoolSystem
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Enrollment, EnrollmentDTO>().ReverseMap();
            CreateMap<Teacher, TeacherDTO>().ReverseMap();                                
            CreateMap<Course, CourseDTO>().ReverseMap();
        
        
        }
    }
}
