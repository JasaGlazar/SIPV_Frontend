using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPV_Frontend
{
    class TrafficNews
    {
        public string title { get; set; }
        public string news_description { get; set; }
        public string picture_url { get; set; }

        public DateTime news_date { get; set; }

        public TrafficNews() { }
        public TrafficNews(string title,string news_description, string picture_url, DateTime news_date)
        {
            this.title = title;
            this.news_description = news_description;
            this.picture_url = picture_url;
            this.news_date = news_date;
        }
    }
}
