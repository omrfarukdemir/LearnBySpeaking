using AutoMapper;
using LearnBySpeaking.Core.Domain;
using LearnBySpeaking.Web.Models.ViewModels.Exam;

namespace LearnBySpeaking.Web.Infrastructure.Mapper
{
    public class EntityToViewModel : Profile
    {
        public EntityToViewModel()
        {
            CreateMap<Exam, ListExamViewModel>();

            CreateMap<Exam, ExamViewModel>();
            CreateMap<Question, QuestionViewModel>();
            CreateMap<Answer, AnswerViewModel>();
        }
    }
}