using System;
using System.Collections.Generic;
using Cookbook.Objects;

namespace Cookbook.Db.EntityTypes {
    /// <inheritdoc cref="IRecipeInfo" />
    internal class RecipeInfo : IDbItem, IRecipeInfo {
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
        public int Servings { get; set; }

        /// <inheritdoc />
        public TimeSpan Duration { get; set; }

        /// <inheritdoc />
        public ICollection<IAppliedTag> Tags { get; set; }

        /// <inheritdoc />
        public float EstimatedPrice { get; set; }
    }
}