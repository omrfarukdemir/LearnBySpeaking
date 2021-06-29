using AutoMapper;
using LearnBySpeaking.Web.Models.ViewModels.Account;
using LearnBySpeaking.Web.Models.ViewModels.Exam;
using LearnBySpeaking.Web.Queries.Account.Model;
using LearnBySpeaking.Web.Queries.Exam.Model;

namespace LearnBySpeaking.Web.Infrastructure.Mapper
{
    public class ViewModelToQuery:Profile
    {
        public ViewModelToQuery()
        {
            CreateMap<LoginViewModel, LoginQuery>();
            CreateMap<ExamCompleteViewModel, CompleteExamQuery>();
        }
    }
}