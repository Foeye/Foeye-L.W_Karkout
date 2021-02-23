using NotImplementedException = System.NotImplementedException;

namespace Framewrok.System
{
    public class SystemSingleton<T> where T : class, new()
    {
        public static T mInstance;

        public static T Instance
        {
            get
            {
                return mInstance ?? new T();
            }
        }
    }
}