using LearnBySpeaking.Web.Models;
using MediatR;

namespace LearnBySpeaking.Web.Queries.Account.Model
{
    public class LoginQuery:IRequest<LearnBySpeakingResult>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}