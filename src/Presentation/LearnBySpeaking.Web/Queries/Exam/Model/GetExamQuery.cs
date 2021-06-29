using LearnBySpeaking.Web.Models.ViewModels.Exam;
using MediatR;

namespace LearnBySpeaking.Web.Queries.Exam.Model
{
    public class GetExamQuery:IRequest<ExamViewModel>
    {
        public int Id { get; set; }
    }
}