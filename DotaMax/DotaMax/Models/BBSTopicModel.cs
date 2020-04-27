using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaMax.Models.BBSTopic
{
    public class BBSTopicModel
    {
        public string msg { get; set; }
        public string notify { get; set; }
        public Recommend recommend { get; set; }
        public string status { get; set; }
        public Topic[] topics { get; set; }
    }

    public class Recommend
    {
        public string board { get; set; }
        public Child[] children { get; set; }
        public int id { get; set; }
        public int is_open { get; set; }
    }

    public class Child
    {
        public string description { get; set; }
        public int follow_num { get; set; }
        public int link_num { get; set; }
        public string name { get; set; }
        public string pic_url { get; set; }
        public string str_link_num { get; set; }
        public int today_link_num { get; set; }
        public int topic_id { get; set; }
    }

    public class Topic
    {
        public string board { get; set; }
        public Child1[] children { get; set; }
        public int id { get; set; }
        public int is_open { get; set; }
        public string name { get; set; }
    }

    public class Child1
    {
        public int can_post_hs_deck { get; set; }
        public string description { get; set; }
        public int follow_num { get; set; }
        public string game_type { get; set; }
        public object link_num { get; set; }
        public string name { get; set; }
        public string pic_url { get; set; }
        public string str_link_num { get; set; }
        public int today_link_num { get; set; }
        public int topic_id { get; set; }
    }
}
