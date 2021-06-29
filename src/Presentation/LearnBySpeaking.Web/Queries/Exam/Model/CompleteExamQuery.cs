using LearnBySpeaking.Web.Models.ViewModels.Exam;
using MediatR;
using System.Collections.Generic;

namespace LearnBySpeaking.Web.Queries.Exam.Model
{
    public class CompleteExamQuery : IRequest<List<ExamResultViewModel>>
    {
        public int Id { get; set; }
        public List<QuestionCompleteViewModel> Answers { get; set; }
    }
}