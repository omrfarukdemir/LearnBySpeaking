using System.Collections.Generic;
using LearnBySpeaking.Core.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LearnBySpeaking.Web.Models.ViewModels.Exam
{
    public class CreateExamViewModel
    {
        [BindNever]
        public List<WiredMostRecent> MostRecents { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
    }
}