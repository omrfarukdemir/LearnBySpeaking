using System.Collections.Generic;
using AutoMapper;
using LearnBySpeaking.Core.Domain;
using System.Threading.Tasks;

namespace LearnBySpeaking.Services.Domain.Abstract
{
    public interface IExamService
    {
        Task CreateExamAsync(Exam exam);

        Task DeleteExamAsync(Exam exam);

        ValueTask<Exam> GetExamAsync(int id);

        Task<List<Exam>> GetExamsAsync();

        Task<List<TDto>> GetExamsAsync<TDto>(IMapper mapper);

        Task<TDto> GetExamAsync<TDto>(int id, IMapper mapper);
    }
}