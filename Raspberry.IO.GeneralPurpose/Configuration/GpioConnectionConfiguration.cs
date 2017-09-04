#if NETSTANDARD2_0
namespace Raspberry.IO.GeneralPurpose.Configuration
{
    /// <inheritdoc />
    public class GpioConnectionConfiguration : IGpioConnectionConfiguration
    {
        /// <inheritdoc />
        public string DriverTypeName { get; set; }

        /// <inheritdoc />
        public int BoardConnectorRevision { get; set; }

        /// <inheritdoc />
        public decimal PollInterval { get; set; }
    }
}
#endif