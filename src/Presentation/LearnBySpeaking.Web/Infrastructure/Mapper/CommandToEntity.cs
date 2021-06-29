using AutoMapper;
using LearnBySpeaking.Core.Domain;
using LearnBySpeaking.Web.Commands.Exam.Model;

namespace LearnBySpeaking.Web.Infrastructure.Mapper
{
    public class CommandToEntity : Profile
    {
        public CommandToEntity()
        {
            CreateMap<CreateExamCommand, Exam>();
            CreateMap<AnswerCommand, Answer>();
            CreateMap<QuestionCommand, Question>();
        }
    }
}