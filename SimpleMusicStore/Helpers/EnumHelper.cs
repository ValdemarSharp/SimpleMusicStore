namespace SimpleMusicStore.Helpers
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

    public static class EnumHelper
    {
        /// <summary>
        /// Отображает юзер-френдли  значение перечисления, которое задаётся с помощь атрибута
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
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