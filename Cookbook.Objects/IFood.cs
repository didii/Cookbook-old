using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    /// <summary>
    ///     A food item which is not bound to any quantity
    /// </summary>
    public interface IFood : ITracable, ITrackable {
        /// <summary>
        ///     The name of this item
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     The name of this item as plural
        /// </summary>
        string NamePlural { get; set; }

        /// <summary>
        ///     A more detailed description about this item
        /// </summary>
        string Description { get; set; }

        /// <summary>
        ///     An image visualising this food item
        /// </summary>
        IImage Image { get; set; }

        /// <summary>
        ///     Optional comments about this food item
        /// </summary>
        ICollection<IComment> Comments { get; set; }
    }
}