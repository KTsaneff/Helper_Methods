public class ReflectionHelperMethods
{
    private static object GetPrivateFieldValue(Type type, object obj, string fieldName)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

        FieldInfo field = type.GetField(fieldName, flags);
        return field.GetValue(obj);
    }
}
