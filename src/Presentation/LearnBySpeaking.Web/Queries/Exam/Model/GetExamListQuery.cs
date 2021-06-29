using System.Collections.Generic;
using LearnBySpeaking.Web.Models.ViewModels.Exam;
using MediatR;

namespace LearnBySpeaking.Web.Queries.Exam.Model
{
    public class GetExamListQuery : IRequest<List<ListExamViewModel>>
    {

    }
}