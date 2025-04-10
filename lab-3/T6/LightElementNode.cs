using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public bool SelfClosing { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        public LightElementNode(string tagName, bool selfClosing = false)
        {
            TagName = tagName;
            SelfClosing = selfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
        }

        public void AddClass(string cssClass)
        {
            CssClasses.Add(cssClass);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string InnerHtml()
        {
            string html = "";
            for (int i = 0; i < Children.Count; i++)
            {
                html += Children[i].OuterHtml();
            }
            return html;
        }

        public override string OuterHtml()
        {
            string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            if (SelfClosing)
            {
                return $"<{TagName}{classAttr} />";
            }

            return $"<{TagName}{classAttr}>{InnerHtml()}</{TagName}>";
        }
    }
}
