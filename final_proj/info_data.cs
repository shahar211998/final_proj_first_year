using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_proj
{
    class info_data
    {
        private int unique_number;
        private string topic;
        private string content;

        protected int Unique_number { get => unique_number; set => unique_number = value; }
        protected string Topic { get => topic; set => topic = value; }
        protected string Content { get => content; set => content = value; }

        public info_data()
        {
            Unique_number = -1;
            Topic = "null";
            Content = "null";
        }
        public info_data(string topic)
        {
            Topic = topic;
        }
        public info_data(int unique_number, string topic, string content)
        {
            Unique_number = unique_number;
            Topic = topic;
            Content = content;
        }
        public override string ToString()
        {
            return "#" + Unique_number + " topic:" + Topic + " content: " + Content;
        }
       
    }

    class info_data_with_pic : info_data
    {
        private string pic;

        protected string Pic { get => pic; set => pic = value; }
        public info_data_with_pic(int unique_number, string topic, string content,string pic):base(unique_number,topic,content)
        {
            Pic = pic;
        }

        public info_data_with_pic(string topic, string pic) : base(topic)
        {
            Pic = pic;
        }
        public override string ToString()
        {
            return base.ToString(); //+ " pic direct: " + Pic;
        }
        public string get_image_location()
        {
            return pic;
        }
        public string get_image_location_of_two_pic()
        {
            return Content;
        }
    }
}
