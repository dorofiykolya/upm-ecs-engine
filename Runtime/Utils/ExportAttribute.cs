using System;

namespace Battle.Engine.Utils
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ExportAttribute : Attribute
    {
        public bool CanImport { get; set; } = true;
    }
}