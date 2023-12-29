using System;
using System.Linq;

namespace AtomicRegistrationTool;

public class MappingAttribute : Attribute
{
    public string MappingValue { get; private set; }

    public MappingAttribute(string mappingValue)
    {
        MappingValue = mappingValue;
    }
}

public static class MappingExtensions
{
    public static string GetMapping<TEnum>(this TEnum enumValue) where TEnum : System.Enum
    {
        var memberInfo = enumValue.GetType().GetMember(enumValue.ToString()).FirstOrDefault();
        if (memberInfo != null)
        {
            var attribute =
                memberInfo.GetCustomAttributes(typeof(MappingAttribute), false).FirstOrDefault() as MappingAttribute;
            return attribute?.MappingValue ?? string.Empty;
        }

        return string.Empty;
    }
}