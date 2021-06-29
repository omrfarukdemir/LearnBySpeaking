using LearnBySpeaking.Core.Models;
using System.Collections.Generic;

namespace LearnBySpeaking.Services.Common.Abstract
{
    public interface IWiredCrawlerService
    {
        List<WiredMostRecent> GetMostRecents();

        string GetPost(string url);
    }
}