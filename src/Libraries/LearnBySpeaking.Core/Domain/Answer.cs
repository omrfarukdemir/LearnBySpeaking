namespace LearnBySpeaking.Core.Domain
{
    public class Answer : BaseEntity<int>
    {
        public string Content { get; set; }
        public virtual Question Question { get; set; }
        public int QuestionId { get; set; }
        public Stylish Stylish { get; set; }
    }
}