using System.Collections.Generic;

namespace LearnBySpeaking.Web.Models.ViewModels.Exam
{
    public class ExamViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
    }
}