#if NETSTANDARD2_0
namespace Raspberry.IO.GeneralPurpose.Configuration
{
    public static class GlobalConfiguration
    {
        private static GpioConnectionConfiguration _gpioConnectionConfiguration;

        public static void SetConnectionConfiguration(GpioConnectionConfiguration configuration)
        {
            _gpioConnectionConfiguration = configuration;
        }

        public static GpioConnectionConfiguration GetConnectionConfiguration()
        {
            return _gpioConnectionConfiguration;
        }
    }
}
#endif