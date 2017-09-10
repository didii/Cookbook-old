using System;

namespace Cookbook.Objects {
    /// <summary>
    ///     The type of a unit such as mass or volume
    /// </summary>
    public interface IQuantityType : ITracable, ITrackable {
        /// <summary>
        ///     The name of this quantity type
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     The quantity that is considered the base which should have 1 as <see cref="IQuantity.Multiplier" />
        /// </summary>
        IQuantity BaseQuantity { get; set; }
    }
}