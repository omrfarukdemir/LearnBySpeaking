using LearnBySpeaking.Core.Domain;
using System.Collections.Generic;
using MediatR;

namespace LearnBySpeaking.Web.Commands.Exam.Model
{
    public class CreateExamCommand:IRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<QuestionCommand> Questions { get; set; }
    }

    public class QuestionCommand
    {
        public byte Order { get; set; }
        public string Title { get; set; }
        public Stylish CorrectStylish { get; set; }
        public List<AnswerCommand> Answers { get; set; }
    }

    public class AnswerCommand
    {
        public string Content { get; set; }
        public Stylish Stylish { get; set; }
    }
}