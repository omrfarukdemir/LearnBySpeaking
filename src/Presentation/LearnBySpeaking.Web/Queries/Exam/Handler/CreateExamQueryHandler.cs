using System.Linq;
using LearnBySpeaking.Services.Common.Abstract;
using LearnBySpeaking.Web.Models.ViewModels.Exam;
using LearnBySpeaking.Web.Queries.Exam.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LearnBySpeaking.Web.Queries.Exam.Handler
{
    public class CreateExamQueryHandler : IRequestHandler<CreateExamQuery, CreateExamViewModel>
    {
        private readonly IWiredCrawlerService _wiredCrawlerService;

        public CreateExamQueryHandler(IWiredCrawlerService wiredCrawlerService)
        {
            _wiredCrawlerService = wiredCrawlerService;
        }

        public Task<CreateExamViewModel> Handle(CreateExamQuery request, CancellationToken cancellationToken)
        {
            var result = new CreateExamViewModel
            {
                MostRecents = _wiredCrawlerService.GetMostRecents()
            };

            if (string.IsNullOrEmpty(request.Url)) return Task.FromResult(result);

            result.Content = _wiredCrawlerService.GetPost(request.Url);
            result.Title = result.MostRecents.FirstOrDefault(x => x.Url == request.Url)?.Title;

            return Task.FromResult(result);
        }
    }
}