﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text)
        {
            _text = text;
        }

        public override string InnerHtml()
        {
            return _text;
        }

        public override string OuterHtml()
        {
            return _text;
        }
    }
}
