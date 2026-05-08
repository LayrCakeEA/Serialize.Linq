using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Serialize.Linq.LayrCakeCustom
{
    public class ExternalNamespace
    {
        public string NameSpace { get; set; }

        public string SuffixRemove { get; set; }

        public string SuffixReplace { get; set; }
    }

    public static class TypeResolver_Helper
    {
        public static List<ExternalNamespace> GetNamespaces()
        {
            var namespaceList = new List<ExternalNamespace>();

            try
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                    .Build();

                var settings = configuration
                    .GetSection("ExpressionSettings")
                    .Get<ExpressionSettings>();

                if (settings?.Expressions == null)
                    return namespaceList;

                foreach (var expression in settings.Expressions)
                {
                    namespaceList.Add(new ExternalNamespace
                    {
                        NameSpace = expression.LookupNamespace,
                        SuffixRemove = expression.SuffixRemove,
                        SuffixReplace = expression.SuffixReplace
                    });
                }
            }
            catch (Exception exc)
            {
                throw new Exception("Serialize.Linq error opening ExpressionSerialise Config Settings", exc);
            }

            return namespaceList;
        }
    }
}
