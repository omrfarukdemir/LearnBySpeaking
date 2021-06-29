using LearnBySpeaking.Core.Domain;
using System.Threading.Tasks;

namespace LearnBySpeaking.Services.Domain.Abstract
{
    public interface IAnswerService
    {
        Task CreateAnswerAsync(Answer answer);
    }
}