using LearnBySpeaking.Services.Domain.Abstract;
using LearnBySpeaking.Web.Commands.Exam.Model;
using LearnBySpeaking.Web.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LearnBySpeaking.Web.Commands.Exam.Handler
{
    public class ExamDeleteCommandHandler : IRequestHandler<ExamDeleteCommand, LearnBySpeakingResult>
    {
        private readonly IExamService _examService;

        public ExamDeleteCommandHandler(IExamService examService)
        {
            _examService = examService;
        }

        public async Task<LearnBySpeakingResult> Handle(ExamDeleteCommand request, CancellationToken cancellationToken)
        {
            var exam = await _examService.GetExamAsync(request.Id);

            if (exam is null)
            {
                return LearnBySpeakingResult.ErrorResult("Exam not found");
            }

            await _examService.DeleteExamAsync(exam);

            return LearnBySpeakingResult.Successful;
        }
    }
}