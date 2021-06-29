using AutoMapper;
using LearnBySpeaking.Services.Domain.Abstract;
using LearnBySpeaking.Web.Commands.Exam.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LearnBySpeaking.Web.Commands.Exam.Handler
{
    public class CreateExamCommandHandler : IRequestHandler<CreateExamCommand>
    {
        private readonly IExamService _examService;
        private readonly IMapper _mapper;

        public CreateExamCommandHandler(IExamService examService, IMapper mapper)
        {
            _examService = examService;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateExamCommand request, CancellationToken cancellationToken)
        {
            var exam = _mapper.Map<Core.Domain.Exam>(request);

            await _examService.CreateExamAsync(exam);

            return Unit.Value;
        }
    }
}