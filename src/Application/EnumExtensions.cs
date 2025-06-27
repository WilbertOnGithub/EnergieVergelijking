using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Arentheym.EnergieVergelijker.Application;

public static class EnumExtensions
{
    public static string GetDescription([NotNull] this Enum enumValue)
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DescriptionAttribute>()
            ?.Description ?? enumValue.ToString();
    }
}
