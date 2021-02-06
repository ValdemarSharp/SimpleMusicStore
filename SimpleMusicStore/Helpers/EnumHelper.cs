namespace SimpleMusicStore.Helpers
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

    public static class EnumHelper
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            string result;
            try
            {
                result = enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
            }
            catch
            {
                result = enumValue.ToString();
            }
            return result;
        }
    }
}