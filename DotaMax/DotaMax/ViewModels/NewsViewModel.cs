using DotaMax.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaMax.ViewModels
{
    public class NewsViewModel
    {
        public ObservableCollection<Models.MaxNews.Result> NewsCollection = new ObservableCollection<Models.MaxNews.Result>();

        public void InitAction()
        {
            GetNews();
        }

        /// <summary>
        /// 获取新闻
        /// </summary>
        private async void GetNews()
        {
            if (NewsCollection.Count <= 0)
            {
                var news = await MaxApi.GetNews("dota2", 0);
                if (news == null)
                {
                    // 获取新闻失败
                    return;
                }
                foreach (var newsItem in news.result)
                {
                    NewsCollection.Add(newsItem);
                }
            }
        }
    }
}
