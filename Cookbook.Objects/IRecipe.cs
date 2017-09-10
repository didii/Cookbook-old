using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    /// <summary>
    ///     A recipe
    /// </summary>
    public interface IRecipe : ITracable, ITrackable {
        /// <summary>
        ///     The name of this recipe
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     A more detailed description of this recipe
        /// </summary>
        string Description { get; set; }

        /// <summary>
        ///     Contains basic information about this recipe
        /// </summary>
        IRecipeInfo RecipeInfo { get; set; }

        /// <summary>
        ///     The necessary ingredients
        /// </summary>
        ICollection<IIngredient> Ingredients { get; set; }

        /// <summary>
        ///     The steps to take to succeed the creation
        /// </summary>
        ICollection<IRecipeHowTo> HowTo { get; set; }

        /// <summary>
        ///     Optional comments about this ingredient
        /// </summary>
        ICollection<IComment> Comments { get; set; }
    }
}