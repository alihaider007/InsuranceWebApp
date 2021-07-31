using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace InsuranceWebApp.Data
{
    public static class Helpers
    {
        public static string GetDisplayName(string propertyName, Type classType)
        {
            MemberInfo property = classType.GetProperty(propertyName);
            if (property.GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute dd)
            {
                return dd.Name;
            }
            return "";
        }

        public static string GetDisplayDescription(string propertyName, Type classType)
        {
            MemberInfo property = classType.GetProperty(propertyName);
            if (property.GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute dd)
            {
                return dd.Description;
            }
            return "";
        }

        public static Dictionary<string, string> GetKeyValuesFromEnum(Type enumType)
        {
            Dictionary<string, string> results = new Dictionary<string, string>();

            foreach (var field in enumType.GetFields())
            {
                if (!(Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) is DisplayAttribute attribute))
                {
                    if (field.Name != "value__")
                    {
                        results.Add(field.Name, field.Name);
                    }
                }
                else
                {
                    results.Add(field.Name, attribute.Name);
                }
            }

            return results;
        }
        public static List<EnumKeyValue> GetKeyValuesAsListFromEnum(Type enumType)
        {
            List<EnumKeyValue> results = new List<EnumKeyValue>();

            foreach (var field in enumType.GetFields())
            {
                if (!(Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) is DisplayAttribute attribute))
                {
                    if (field.Name != "value__")
                    {
                        results.Add(new EnumKeyValue { Key = field.Name, Value = field.Name });
                    }
                }
                else
                {
                    results.Add(new EnumKeyValue { Key = field.Name, Value = attribute.Name });
                }
            }

            return results.OrderBy(o => o.Value).ToList(); ;
        }
        public class EnumKeyValue
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

        public static NameValueCollection CreateHeaders(string sysId)
        {
            return new NameValueCollection()
            {
                { nameof(sysId), sysId }
            };
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (action == null) throw new ArgumentNullException("action");

            foreach (T item in source)
            {
                action(item);
            }
        }

        public static string GetEnumDisplayAttribute<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = System.Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));
                        var displayAttribute = memInfo[0]
                            .GetCustomAttributes(typeof(DisplayAttribute), false)
                            .FirstOrDefault() as DisplayAttribute;

                        if (displayAttribute != null)
                        {
                            return displayAttribute.Name;
                        }
                    }
                }
            }

            return null; // could also return string.Empty
        }
    }
}
