using Pragma.Mapping;
using System.Reflection;

namespace Pragma.App.Mapping
{
    public class MapperConfiguration
    {
        public static void RegisterAllProfiles()
        {
            ProfileRegister.Register(Assembly.GetExecutingAssembly());
        }


    }
}

