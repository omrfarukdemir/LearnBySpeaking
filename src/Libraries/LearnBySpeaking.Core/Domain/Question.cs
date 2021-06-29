using System.Collections.Generic;

namespace LearnBySpeaking.Core.Domain
{
    public class Question : BaseEntity<int>
    {
        public virtual ICollection<Answer> Answers { get; set; }
        public Stylish CorrectStylish { get; set; }
        public virtual Exam Exam { get; set; }
        public int ExamId { get; set; }
        public byte Order { get; set; }
        public string Title { get; set; }
    }
}