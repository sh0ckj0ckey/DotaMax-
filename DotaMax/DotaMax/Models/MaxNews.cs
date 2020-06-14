using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaMax.Models.MaxNews
{
    public class MaxNews
    {
        public Imgs imgs { get; set; }
        public string msg { get; set; }
        public int reply_timestamp { get; set; }
        public Result[] result { get; set; }
        public string status { get; set; }
    }

    public class Imgs
    {
        public string mjia_all { get; set; }
        public string topic_all { get; set; }
    }

    public class Result
    {
        public object[] ad_cm { get; set; }
        public object[] ad_pm { get; set; }
        public string bo { get; set; }
        public int click { get; set; }
        public int comment_num { get; set; }
        public int content_type { get; set; }
        public string create_at { get; set; }
        public string date { get; set; }
        public string description { get; set; }
        public string detail_json { get; set; }
        public bool favour { get; set; }
        public int img_type { get; set; }
        public string[] imgs { get; set; }
        public int is_partition_top { get; set; }
        public int is_rotate { get; set; }
        public bool is_supported { get; set; }
        public string league_id { get; set; }
        public int linkid { get; set; }
        public string match_id { get; set; }
        public long[] match_list { get; set; }
        public string newUrl { get; set; }
        public int?[] news_topic_type { get; set; }
        public string newsid { get; set; }
        public string os_type { get; set; }
        public string share_url { get; set; }
        public string source { get; set; }
        public string tag { get; set; }
        public Tag_Info tag_info { get; set; }
        public float timestamp { get; set; }
        public string title { get; set; }
        public bool top { get; set; }
        public int up { get; set; }
        public string url { get; set; }
        public int has_video { get; set; } = 0;
        public int is_large_img { get; set; }
        public int topic_id { get; set; }
        public Video_Info video_info { get; set; }
        public string video_thumb { get; set; }
        public string video_url { get; set; }
    }

    public class Tag_Info
    {
    }

    public class Video_Info
    {
        public int bilibili_id { get; set; }
        public int is_manual { get; set; }
        public int play_times { get; set; }
        public string source_site { get; set; }
        public string thumb { get; set; }
        public string url { get; set; }
        public Url_Info url_info { get; set; }
        public string video_time { get; set; }
    }

    public class Url_Info
    {
        public string Referer { get; set; }
        public string UserAgent { get; set; }
        public string url { get; set; }
        public string Cookie { get; set; }
    }

}
