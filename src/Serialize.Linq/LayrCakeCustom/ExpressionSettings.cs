using System.Collections.Generic;

namespace Serialize.Linq.LayrCakeCustom
{
    public class ExpressionSettings
    {
        public List<ExpressionSettingsItem> Expressions { get; set; } = new();
    }

    public class ExpressionSettingsItem
    {
        public string Name { get; set; }

        public string AssemblyName { get; set; }

        public string LookupNamespace { get; set; }

        public string SuffixRemove { get; set; }

        public string SuffixReplace { get; set; }
    }
}
