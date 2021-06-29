using System.Collections.Generic;

namespace LearnBySpeaking.Web.Models
{
    public class LearnBySpeakingResult
    {
        public bool Success { get; set; }
        public IEnumerable<string> ErrorMessages { get; set; }
        public static LearnBySpeakingResult Successful => new() { Success = true };

        public static LearnBySpeakingResult ErrorResults(List<string> errors) =>
            new() { Success = false, ErrorMessages = errors };

        public static LearnBySpeakingResult ErrorResult(string error) =>
            new() { Success = false, ErrorMessages = new List<string>() { error } };
    }
}