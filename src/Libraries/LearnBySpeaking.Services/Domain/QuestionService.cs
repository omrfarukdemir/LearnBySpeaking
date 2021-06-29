using LearnBySpeaking.Core.Data;
using LearnBySpeaking.Core.Domain;
using LearnBySpeaking.Services.Domain.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBySpeaking.Services.Domain
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository<int, Question> _questionRepository;

        public QuestionService(IRepository<int, Question> questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public Task<List<Question>> GetExamQuestionsAsync(int examId)
        {
            return _questionRepository.Table.Where(x => x.ExamId == examId).ToListAsync();
        }
    }
}