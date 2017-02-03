using System;
using System.Configuration;

namespace Pragma.Core.POCO
{
    public class ConfigManager
    {
        public static string GetConfig(string key)
        {
            return GetConfig(key, false);
        }

        public static string GetConfig(string key, bool isNecessary)
        {
            string configuration = ConfigurationManager.AppSettings[key];

            if (isNecessary && configuration == null)
            {
                throw new InvalidOperationException(
                   $"Configuration not found {key}"
                );
            }

            return configuration;
        }

        public static bool TryParse(
            string keyName,
            out string obj
        )
        {
            var canConverted = false;
            obj = default(string);

            var value = GetConfig(keyName);
            if (!string.IsNullOrWhiteSpace(value))
            {
                obj = value;
                canConverted = true;
            }

            return canConverted;
        }

        public static bool TryParse(
            string keyName,
            out int obj
        )
        {
            var canConverted = false;
            obj = default(int);

            var value = GetConfig(keyName);
            if (!string.IsNullOrWhiteSpace(value))
                canConverted = int.TryParse(value, out obj);

            return canConverted;
        }

        public static bool TryParse(
            string keyName,
            out bool obj
        )
        {
            var canConverted = false;
            obj = default(bool);

            var value = GetConfig(keyName);
            if (!string.IsNullOrWhiteSpace(value))
                canConverted = bool.TryParse(value, out obj);

            return canConverted;
        }
    }
}
