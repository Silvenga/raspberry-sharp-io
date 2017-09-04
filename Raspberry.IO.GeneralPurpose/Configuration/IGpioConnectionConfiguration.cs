namespace Raspberry.IO.GeneralPurpose.Configuration
{
    public interface IGpioConnectionConfiguration
    {
        /// <summary>
        /// Gets or sets the name of the driver type.
        /// </summary>
        /// <value>
        /// The name of the driver type.
        /// </value>
        string DriverTypeName { get; set; }

        /// <summary>
        /// Gets or sets the board connector revision.
        /// </summary>
        /// <value>
        /// The board revision, <c>0</c> for automatic detection, <c>1</c> for model B rev1; <c>2</c> for model B rev2 and model A, <c>3</c> for model B+, A+ and higher.
        /// </value>
        int BoardConnectorRevision { get; set; }

        /// <summary>
        /// Gets or sets the poll interval, in milliseconds.
        /// </summary>
        /// <value>
        /// The poll interval, in millisecond.
        /// </value>
        /// <remarks>
        /// Default value is 50ms.
        /// Values lower than 1ms may be specified on Raspberry Pi using decimal notation.
        /// </remarks>
        decimal PollInterval { get; set; }
    }
}