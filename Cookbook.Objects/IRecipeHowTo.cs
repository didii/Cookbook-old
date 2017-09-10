using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    /// <summary>
    ///     A single step in the howto of a recipe
    /// </summary>
    public interface IRecipeHowTo : ITracable, ITrackable {
        /// <summary>
        ///     A description of how to succeed in doing this step
        /// </summary>
        string Description { get; set; }

        /// <summary>
        ///     Optional comments about this particular step
        /// </summary>
        ICollection<IComment> Comment { get; set; }
    }
}