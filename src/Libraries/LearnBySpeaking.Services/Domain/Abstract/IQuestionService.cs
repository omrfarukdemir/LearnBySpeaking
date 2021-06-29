using LearnBySpeaking.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnBySpeaking.Services.Domain.Abstract
{
    public interface IQuestionService
    {
        Task<List<Question>> GetExamQuestionsAsync(int examId);
    }
}