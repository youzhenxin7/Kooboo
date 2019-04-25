﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.Model.Meta
{
    public class SelectOptions
    {
        public List<OptionItem> Items { get; set; }

        public OptionContext Context { get; set; }

        /// <summary>
        /// Get select options from context data
        /// </summary>
        public static SelectOptions UseContext(string dataField, string textField, string valueField = null)
        {
            return new SelectOptions 
            {
                Context = new OptionContext
                {
                    DataField = dataField,
                    TextField = textField,
                    ValueField = valueField
                }
            };
        }

        public static SelectOptions UseList(params OptionItem[] items)
        {
            return new SelectOptions
            {
                Items = items.ToList()
            };
        }

        public class OptionContext
        {
            public string DataField { get; set; }

            public string TextField { get; set; }

            public string ValueField { get; set; }
        }

        public class OptionItem
        {
            public string Text { get; set; }

            public string Value { get; set; }
        }
    }
}
