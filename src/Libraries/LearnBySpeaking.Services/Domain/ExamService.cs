using AutoMapper;
using AutoMapper.QueryableExtensions;
using LearnBySpeaking.Core.Data;
using LearnBySpeaking.Core.Domain;
using LearnBySpeaking.Services.Domain.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBySpeaking.Services.Domain
{
    public class ExamService : IExamService
    {
        private readonly IRepository<int, Exam> _examRepository;

        public ExamService(IRepository<int, Exam> examRepository)
        {
            _examRepository = examRepository;
        }

        public Task CreateExamAsync(Exam exam)
        {
            return _examRepository.InsertAsync(exam);
        }

        public Task DeleteExamAsync(Exam exam)
        {
            return _examRepository.DeleteAsync(exam);
        }

        public ValueTask<Exam> GetExamAsync(int id)
        {
            return _examRepository.GetAsync(id);
        }

        public Task<List<Exam>> GetExamsAsync()
        {
            return _examRepository.Table.ToListAsync();
        }

        public Task<List<TDto>> GetExamsAsync<TDto>(IMapper mapper)
        {
            return _examRepository
                .Table
                .ProjectTo<TDto>(mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public Task<TDto> GetExamAsync<TDto>(int id, IMapper mapper)
        {
            return _examRepository
                 .Table
                 .Where(x => x.Id == id)
                 .ProjectTo<TDto>(mapper.ConfigurationProvider)
                 .FirstOrDefaultAsync();
        }
    }
}