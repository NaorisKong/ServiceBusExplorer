using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBusExplorer.Common.Helpers
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// this exthension method is used to get the string value from the dictionary
        /// if the value is null or empty then it will return null
        /// </summary>
        /// <param name="propertyValue"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static string? GetNullableStringValue(this Dictionary<string, object> propertyValue, string propertyName)
        {
            return !string.IsNullOrWhiteSpace(propertyValue[propertyName] as string) ? propertyValue[propertyName] as string : null;
        }
    }
}
