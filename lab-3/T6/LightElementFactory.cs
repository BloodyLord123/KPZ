using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T6
{
    public class LightElementFactory
    {
        private readonly Dictionary<string, LightElementNode> _flyweights = new Dictionary<string, LightElementNode>();
        public LightElementNode GetElement(string tagName)
        {
            return new LightElementNode(tagName);
        }
    }
}