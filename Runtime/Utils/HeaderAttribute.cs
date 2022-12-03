using System;

namespace Battle.Engine.Utils
{
    public class HeaderAttribute : Attribute
    {
        public HeaderAttribute(string label)
        {
            Label = label;
        }

        public string Label { get; set; }
    }
}