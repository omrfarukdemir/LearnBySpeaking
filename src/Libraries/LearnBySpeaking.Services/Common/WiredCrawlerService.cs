using HtmlAgilityPack;
using LearnBySpeaking.Core.Models;
using LearnBySpeaking.Services.Common.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace LearnBySpeaking.Services.Common
{
    public class WiredCrawlerService : IWiredCrawlerService
    {
        private const string BaseUrl = "https://www.wired.com";

        public List<WiredMostRecent> GetMostRecents()
        {
            var web = new HtmlWeb();
            var htmlDocument = web.Load(BaseUrl);

            var mostRecentsElements = htmlDocument.DocumentNode
                .SelectNodes("//div[@class=\"secondary-grid-component\"]//ul[@class=\"post-listing-component__list\"]")
                .First();

            htmlDocument.LoadHtml(mostRecentsElements.InnerHtml);

            var liElements = htmlDocument.DocumentNode.SelectNodes("//li[@class=\"post-listing-list-item__post\"]");

            var wiredMostRecents = new List<WiredMostRecent>();

            foreach (var liElement in liElements)
            {
                var tempHtmlDocument = new HtmlDocument();

                tempHtmlDocument.LoadHtml(liElement.InnerHtml);

                var aElement = tempHtmlDocument.DocumentNode.SelectSingleNode("//a[@class=\"post-listing-list-item__link\"]");

                var url = aElement.Attributes["href"].Value;

                var title = aElement.SelectNodes("//h5[@class=\"post-listing-list-item__title\"]").First().InnerText;

                wiredMostRecents.Add(new()
                {
                    Title = title,
                    Url = url
                });
            }

            return wiredMostRecents;
        }

        public string GetPost(string url)
        {
            
            var web = new HtmlWeb();
            var htmlDocument = web.Load($"{BaseUrl}{url}");

            var mostRecentsElements = htmlDocument.DocumentNode
                .SelectNodes("//div[@class=\"article__chunks\"]")
                .First();

            return mostRecentsElements.InnerText;
        }
    }
}