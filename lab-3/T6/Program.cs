using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;


namespace T6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
            string textContent = DownloadText(url);
            LightElementFactory factory = new LightElementFactory();
            LightElementNode root = new LightElementNode("div");
            long memoryBefore = GC.GetTotalMemory(true);
            string[] lines = textContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string trimmed = line.TrimEnd();

                if (string.IsNullOrWhiteSpace(trimmed))
                {
                    continue; 
                }
                string tag;
                if (root.Children.Count == 0)
                {
                    tag = "h1";
                }
                else if (trimmed.Length < 20)
                {
                    tag = "h2";
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    tag = "blockquote";
                }
                else
                { 
                    tag = "p";
                }
                LightElementNode element = factory.GetElement(tag);
                element.AddChild(new LightTextNode(trimmed));
                root.AddChild(element);
            }
            long memoryAfter = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryAfter - memoryBefore} bytes");
            string filePath = "Text.html";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(root.OuterHtml());
            }

            Console.WriteLine($"HTML has been written to {filePath}");
        }
        static string DownloadText(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "C# App");
                string content = client.GetStringAsync(url).Result;
                return content;
            }
        }
    }
}