using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ImproveYourDotnetStyle.Extensions
{
    public class EnumExtensions
    {
        public static string GetDisplayName(Enum value)
        {
            try
            {
                return value.GetType()
                    .GetMember(value.ToString())
                    .First()
                    .GetCustomAttribute<DisplayAttribute>()
                    .Name;
            }
            catch
            {
                return value.ToString();
            }
        }
    }
}