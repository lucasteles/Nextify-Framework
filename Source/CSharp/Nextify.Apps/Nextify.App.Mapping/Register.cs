using Nextify.Mapping;
using System.Reflection;

namespace Nextify.App.Mapping
{
    public class MapperConfiguration
    {
        public static void RegisterAllProfiles()
        {
            ProfileRegister.Register(Assembly.GetExecutingAssembly());
        }
    }
}

