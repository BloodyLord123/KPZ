using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LightElementNode ul = new LightElementNode("ul");
            ul.AddClass("my-list");
            LightElementNode li1 = new LightElementNode("li");
            LightTextNode text1 = new LightTextNode("1");
            li1.AddChild(text1);
            LightElementNode li2 = new LightElementNode("li");
            LightTextNode text2 = new LightTextNode("2");
            li2.AddChild(text2);
            ul.AddChild(li1);
            ul.AddChild(li2);
            Console.WriteLine(ul.OuterHtml());
        }
    }
}
