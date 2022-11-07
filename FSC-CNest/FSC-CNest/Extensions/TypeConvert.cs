namespace FSC_CNest.Extensions
{
    public static class TypeConvert
    {
        public static T To<T>(this object value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
