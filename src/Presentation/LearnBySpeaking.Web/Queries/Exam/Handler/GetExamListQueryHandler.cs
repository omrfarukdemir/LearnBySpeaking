using AutoMapper;
using LearnBySpeaking.Services.Domain.Abstract;
using LearnBySpeaking.Web.Models.ViewModels.Exam;
using LearnBySpeaking.Web.Queries.Exam.Model;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LearnBySpeaking.Web.Queries.Exam.Handler
{
    public class GetExamListQueryHandler : IRequestHandler<GetExamListQuery, List<ListExamViewModel>>
    {
        private readonly IExamService _examService;
        private readonly IMapper _mapper;

        public GetExamListQueryHandler(IExamService examService, IMapper mapper)
        {
            _examService = examService;
            _mapper = mapper;
        }

        public async Task<List<ListExamViewModel>> Handle(GetExamListQuery request, CancellationToken cancellationToken)
        {
            var exams = await _examService.GetExamsAsync<ListExamViewModel>(_mapper);

            return exams;
        }
    }
}