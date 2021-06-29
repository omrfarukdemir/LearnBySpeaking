using LearnBySpeaking.Core.Data;
using LearnBySpeaking.Core.Domain;
using LearnBySpeaking.Services.Domain.Abstract;
using System.Threading.Tasks;

namespace LearnBySpeaking.Services.Domain
{
    public class AnswerService : IAnswerService
    {
        private readonly IRepository<int, Answer> _answerRepository;

        public AnswerService(IRepository<int, Answer> answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public Task CreateAnswerAsync(Answer answer)
        {
            return _answerRepository.InsertAsync(answer);
        }
    }
}