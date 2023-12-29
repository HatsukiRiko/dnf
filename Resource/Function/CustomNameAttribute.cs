using System.Reflection;

namespace Resource.Function;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class CustomNameAttribute : Attribute
{
    public string Name { get; }

    public CustomNameAttribute(string name)
    {
        Name = name;
    }
}

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class CustomDescriptionAttribute : Attribute
{
    public string Description { get; }

    public CustomDescriptionAttribute(string description)
    {
        Description = description;
    }
}

public static class TypeExtensions
{
    public static string GetCustomNameOrClassName(this Type type)
    {
        var customNameAttribute = type.GetCustomAttribute<CustomNameAttribute>();
        return customNameAttribute?.Name ?? type.Name;
    }

    public static string GetCustomDescription(this Type type)
    {
        var customDescriptionAttribute = type.GetCustomAttribute<CustomDescriptionAttribute>();
        return customDescriptionAttribute?.Description;
    }
}