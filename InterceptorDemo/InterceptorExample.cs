using System.Runtime.CompilerServices;

namespace InterceptorDemo
{
    public static class InterceptorExample
    {
        public static void InterceptorDisplayName(this Employee employee, string name)
        {
            Console.WriteLine("Hello from Interceptor with value = " + name);
        }
    }
}
