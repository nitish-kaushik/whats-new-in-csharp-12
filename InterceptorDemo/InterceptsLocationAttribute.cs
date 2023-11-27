
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    internal sealed class InterceptsLocationAttribute(string filePath, int line, int character) : Attribute
    {
    }
}