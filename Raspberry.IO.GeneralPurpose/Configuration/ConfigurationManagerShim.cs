using System;

namespace Raspberry.IO.GeneralPurpose.Configuration
{
    public static class ConfigurationManagerShim
    {
#if NET40
        public static object GetSection(string sectionName)
        {
            return System.Configuration.ConfigurationManager.GetSection(sectionName);
        }
#endif
#if NETSTANDARD2_0
        public static object GetSection(string sectionName)
        {
            throw new NotImplementedException();
        }
#endif
    }
}