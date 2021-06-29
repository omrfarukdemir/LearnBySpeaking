using LearnBySpeaking.Web.Models;
using MediatR;

namespace LearnBySpeaking.Web.Commands.Exam.Model
{
    public class ExamDeleteCommand : IRequest<LearnBySpeakingResult>
    {
        public int Id { get; set; }
    }
}