using LearnBySpeaking.Core.Domain;

namespace LearnBySpeaking.Web.Models.ViewModels.Exam
{
    public class ExamResultViewModel
    {
        public int QuestionId { get; set; }
        public bool Correct { get; set; }
        public string CorrectStylish { get; set; }
    }
}