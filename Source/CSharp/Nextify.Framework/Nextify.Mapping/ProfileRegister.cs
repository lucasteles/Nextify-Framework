﻿using System.Collections.Generic;
using System.Reflection;

namespace Nextify.Mapping
{
    public class ProfileRegister
    {
        internal static IList<Assembly> Profiles = new List<Assembly>();

        public static void Register(Assembly assembly)
        {
            Profiles.Add(assembly);
        }

    }
}
