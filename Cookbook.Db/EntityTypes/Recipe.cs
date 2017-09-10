using System;
using System.Collections.Generic;
using Cookbook.Objects;

namespace Cookbook.Db.EntityTypes {
    /// <inheritdoc cref="IRecipe" />
    public class Recipe : IDbItem, IRecipe {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public DateTime CreatedOn { get; set; }

        /// <inheritdoc />
        public DateTime UpdatedOn { get; set; }

        /// <inheritdoc />
        public IUser CreatedBy { get; set; }

        /// <inheritdoc />
        public IUser UpdatedBy { get; set; }

        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public string Description { get; set; }

        /// <inheritdoc />
        public IRecipeInfo RecipeInfo { get; set; }

        /// <inheritdoc />
        public ICollection<IIngredient> Ingredients { get; set; }

        /// <inheritdoc />
        public ICollection<IRecipeHowTo> HowTo { get; set; }

        /// <inheritdoc />
        public ICollection<IComment> Comments { get; set; }
    }
}