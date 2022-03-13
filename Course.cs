using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DLS
{
    [Serializable]
    [XmlInclude(typeof(Picture)), XmlInclude(typeof(Text)), XmlInclude(typeof(Video)), XmlInclude(typeof(Test))]
    public abstract class Method
    {
        public Method(string _title) { title = _title; }
        public Method() { }

        public string title { get; set; }
        public string type { get; set; }
        public double value { get; set; }

        public virtual void Calc_val() { }
    }

    [Serializable]
    public class Picture : Method
    {
        public string path { get; set; }

        public override void Calc_val()
        {
            value = 300 / 60;
        }

        public Picture(string _title, string _path) : base(_title)
        {
            path = _path;
            type = "Изображение";
            Calc_val();
        }

        public Picture() { }
    }

    [Serializable]
    public class Text : Method
    {
        public string text { get; set; }

        public override void Calc_val()
        {
            value = (text.Length / 3) / 60;
        }

        public Text(string _title, string _text) : base(_title)
        {
            text = _text;
            type = "Параграф";
            Calc_val();
        }

        public Text() { }
    }

    [Serializable]
    public class Video : Method
    {
        public string link { get; set; }
        public double duration { get; set; }

        public override void Calc_val()
        {
            value = duration / 60;
        }

        public Video(string _title, string _link, double _duration) : base(_title)
        {
            link = _link;
            duration = _duration;
            type = "Видеоролик";
            Calc_val();
        }

        public Video() { }
    }

    [Serializable]
    public class Test : Method
    {
        public List<string> Guestion_list { get; set; }

        public override void Calc_val()
        {
            value = (Guestion_list.Count * 120) / 60;
        }

        public Test(string _title, List<string> _Guestion_list) : base(_title)
        {
            Guestion_list = _Guestion_list;
            type = "Тест";
            Calc_val();
        }

        public Test() { }
    }

    [Serializable]
    public class Course
    {
        public Course(string _title, string _author) { title = _title; author = _author; }

        public Course() { }

        public string author { get; set; }
        public string title { get; set; }
        public double total_value { get; set; }

        public void Calc_Value()
        {
            total_value = 0;
            foreach (Method m in method_list)
            {
                m.Calc_val();
                total_value += m.value;
            }               
        }

        public List<Method> method_list = new List<Method> { };

        public void Add_Picture(string _title, string _path)
        {
            Picture pic = new Picture(_title, _path);
            method_list.Add(pic);
            total_value += pic.value;
        }

        public void Add_Text(string _title, string _text)
        {
            Text text = new Text(_title, _text);
            method_list.Add(text);
            total_value += text.value;
        }

        public void Add_Video(string _title, string _link, double _duration)
        {
            Video vid = new Video(_title, _link, _duration);
            method_list.Add(vid);
            total_value += vid.value;
        }

        public void Add_Test(string _title, List<string> _Guestion_list)
        {
            Test test = new Test(_title, _Guestion_list);
            method_list.Add(test);
            total_value += test.value;
        }
    }
}
