using System.Reflection;

namespace Gb.Application
{
    public static class ApplicationAssembly
    {
        public static Assembly GetAssembly()
        {
            return typeof(ApplicationAssembly).Assembly;
        }
    }
}
