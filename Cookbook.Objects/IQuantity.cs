using System;

namespace Cookbook.Objects {
    /// <summary>
    ///     Represents quantity unit
    /// </summary>
    public interface IQuantity : ITracable, ITrackable {
        /// <summary>
        ///     The full name of this quantity unit
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     The abbreviated form of this quantity unit
        /// </summary>
        string ShortName { get; set; }

        /// <summary>
        ///     How many times to multiply this item with to get the SI unit
        /// </summary>
        float Multiplier { get; set; }

        /// <summary>
        ///     To which quantity type does this quantity belong?
        /// </summary>
        IQuantityType QuantityType { get; set; }
    }
}