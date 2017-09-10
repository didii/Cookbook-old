using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    public interface IRecipe {
        string Name { get; set; }
        string Description { get; set; }
        IRecipeInfo RecipeInfo { get; set; }
        ICollection<IIngredient> Ingredients { get; set; }
        ICollection<IRecipeHowTo> HowTo { get; set; }
        ICollection<IComment> Comments { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        IUser CreatedBy { get; set; }
        IUser UpdatedBy { get; set; }
    }
}