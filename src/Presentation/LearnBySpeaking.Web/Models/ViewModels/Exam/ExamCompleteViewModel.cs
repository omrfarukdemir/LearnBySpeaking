using LearnBySpeaking.Core.Domain;
using System.Collections.Generic;

namespace LearnBySpeaking.Web.Models.ViewModels.Exam
{
    public class ExamCompleteViewModel
    {
        public int Id { get; set; }
        public List<QuestionCompleteViewModel> Answers { get; set; }
    }

    public class QuestionCompleteViewModel
    {
        public int QuestionId { get; set; }
        public string Answer { get; set; }
    }
}