using AutoMapper;
using LearnBySpeaking.Services.Domain.Abstract;
using LearnBySpeaking.Web.Models.ViewModels.Exam;
using LearnBySpeaking.Web.Queries.Exam.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LearnBySpeaking.Web.Queries.Exam.Handler
{
    public class GetExamQueryHandler : IRequestHandler<GetExamQuery, ExamViewModel>
    {
        private readonly IExamService _examService;
        private readonly IMapper _mapper;

        public GetExamQueryHandler(IExamService examService, IMapper mapper)
        {
            _examService = examService;
            _mapper = mapper;
        }

        public async Task<ExamViewModel> Handle(GetExamQuery request, CancellationToken cancellationToken)
        {
            var exam = await _examService.GetExamAsync<ExamViewModel>(request.Id, _mapper);

            return exam;
        }
    }
}