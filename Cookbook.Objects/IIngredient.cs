using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    /// <summary>
    ///     An ingredient is a food item together with a quantity.
    /// </summary>
    public interface IIngredient : ITracable, ITrackable {
        /// <summary>
        ///     The food item
        /// </summary>
        IFood Food { get; set; }

        /// <summary>
        ///     The unit of the <see cref="QuantityValue" />
        /// </summary>
        IQuantity Quantity { get; set; }

        /// <summary>
        ///     The quantity value with <see cref="Quantity" /> as the unit
        /// </summary>
        float QuantityValue { get; set; }

        /// <summary>
        ///     Optional comments on this ingredient
        /// </summary>
        ICollection<IComment> Comments { get; set; }
    }
}