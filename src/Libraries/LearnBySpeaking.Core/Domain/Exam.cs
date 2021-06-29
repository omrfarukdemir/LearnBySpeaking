using System.Collections.Generic;

namespace LearnBySpeaking.Core.Domain
{
    public class Exam : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}