using System;

namespace FSC_CNest.Extensions
{
    public static class TypeConvert
    {
        /// <summary>
        /// Converts a value to any type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T To<T>(this object value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
