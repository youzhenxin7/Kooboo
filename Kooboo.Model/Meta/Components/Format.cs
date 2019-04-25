﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.Model.Meta
{
    public class Format
    {
        public string Text { get; set; }

        public Condition Condition { get; set; }

        public static Format UseCondition(Condition map)
        {
            return new Format { Condition = map };
        }

        public static implicit operator Format(string text)
        {
            return new Format { Text = text };
        }
    }
}
