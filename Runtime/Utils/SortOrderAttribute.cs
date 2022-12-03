using System;

namespace Battle.Engine.Utils
{
    public class SortOrderAttribute : Attribute
    {
        public readonly int Order;

        public SortOrderAttribute(int order)
        {
            Order = order;
        }
    }
}