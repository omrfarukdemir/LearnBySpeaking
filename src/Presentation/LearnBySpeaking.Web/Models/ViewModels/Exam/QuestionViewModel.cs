using System.Collections.Generic;
using LearnBySpeaking.Core.Domain;

namespace LearnBySpeaking.Web.Models.ViewModels.Exam
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public byte Order { get; set; }
        public string Title { get; set; }
        public Stylish CorrectStylish { get; set; }

        public List<AnswerViewModel> Answers { get; set; }
    }
}