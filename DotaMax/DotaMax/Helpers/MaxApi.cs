using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DotaMax.Helpers
{
    public static class MaxApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<Models.BBSTopic.BBSTopicModel> GetBBSTopics()
        {
            try
            {
                string time = ((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000).ToString();
                string url = "https://news.maxjia.com/bbs/app/api/topic/index?lang=zh-cn&_time=" + time;
                if (Courier.Instance.HasLoggedIn && Courier.Instance.MaxId != 0)
                {
                    url += "max__id=" + Courier.Instance.MaxId.ToString();
                }
                Models.BBSTopic.BBSTopicModel topics = null;
                using (HttpClient http = new HttpClient())
                {
                    try
                    {
                        var response = await http.GetAsync(new Uri(url));
                        var jsonMessage = await response.Content.ReadAsStringAsync();

                        JsonSerializerSettings jss = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        topics = JsonConvert.DeserializeObject<Models.BBSTopic.BBSTopicModel>(jsonMessage, jss);
                    }
                    catch { topics = null; }
                }
                return topics;
            }
            catch { return null; }
        }

        public static async Task<Models.MaxNews.MaxNews> GetNews(string gametype, int offset = 0)
        {
            try
            {
                string url = "https://news.maxjia.com/maxnews/app/list?os_type=web&game_type=" + gametype + "&offset=" + offset + "&limit=20&tag=None";
                Models.MaxNews.MaxNews news = null;
                using (HttpClient http = new HttpClient())
                {
                    try
                    {
                        http.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
                        http.DefaultRequestHeaders.Add("Host", "news.maxjia.com");
                        var response = await http.GetAsync(new Uri(url));
                        var jsonMessage = await response.Content.ReadAsStringAsync();

                        JsonSerializerSettings jss = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        news = JsonConvert.DeserializeObject<Models.MaxNews.MaxNews>(jsonMessage, jss);
                    }
                    catch { news = null; }
                }
                return news;
            }
            catch { return null; }
        }
    }
}
