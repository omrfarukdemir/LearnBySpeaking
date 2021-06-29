using LearnBySpeaking.Web.Models.ViewModels.Exam;
using MediatR;

namespace LearnBySpeaking.Web.Queries.Exam.Model
{
    public class CreateExamQuery:IRequest<CreateExamViewModel>
    {
        public string Url { get; set; }
    }
}