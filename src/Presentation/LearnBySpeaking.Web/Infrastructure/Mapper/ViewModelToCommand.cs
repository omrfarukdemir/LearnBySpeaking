using AutoMapper;
using LearnBySpeaking.Web.Commands.Exam.Model;
using LearnBySpeaking.Web.Models.ViewModels.Exam;

namespace LearnBySpeaking.Web.Infrastructure.Mapper
{
    public class ViewModelToCommand : Profile
    {
        public ViewModelToCommand()
        {
            CreateMap<CreateExamViewModel, CreateExamCommand>();
            CreateMap<QuestionViewModel, QuestionCommand>();
            CreateMap<AnswerViewModel, AnswerCommand>();
        }
    }
}