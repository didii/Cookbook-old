using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    /// <summary>
    ///     Helper class that contains basic information about a recipe
    /// </summary>
    public interface IRecipeInfo : ITracable, ITrackable {
        /// <summary>
        ///     The amount of servings this recipe will give
        /// </summary>
        int Servings { get; set; }

        /// <summary>
        ///     How long this recipe will approximately take to prepare
        /// </summary>
        TimeSpan Duration { get; set; }

        /// <summary>
        ///     Tags belonging to this recipe
        /// </summary>
        ICollection<IAppliedTag> Tags { get; set; }

        /// <summary>
        ///     How much this recipe will approximately cost in Euro's
        /// </summary>
        float EstimatedPrice { get; set; }
    }
}