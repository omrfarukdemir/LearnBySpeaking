using LearnBySpeaking.Services.Domain.Abstract;
using LearnBySpeaking.Web.Models.ViewModels.Exam;
using LearnBySpeaking.Web.Queries.Exam.Model;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LearnBySpeaking.Web.Queries.Exam.Handler
{
    public class CompleteExamQueryHandler : IRequestHandler<CompleteExamQuery, List<ExamResultViewModel>>
    {
        private readonly IQuestionService _questionService;

        public CompleteExamQueryHandler(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        public async Task<List<ExamResultViewModel>> Handle(CompleteExamQuery request, CancellationToken cancellationToken)
        {
            var result = new List<ExamResultViewModel>();

            var questions = await _questionService.GetExamQuestionsAsync(request.Id);

            foreach (var answer in request.Answers)
            {
                var exam = new ExamResultViewModel();

                exam.QuestionId = answer.QuestionId;
                exam.CorrectStylish = questions.FirstOrDefault(x => x.Id == answer.QuestionId).CorrectStylish.ToString();
                exam.Correct = questions.Any(x => x.CorrectStylish.ToString() == answer.Answer && x.Id == answer.QuestionId);

                result.Add(exam);
            }

            return result;
        }
    }
}