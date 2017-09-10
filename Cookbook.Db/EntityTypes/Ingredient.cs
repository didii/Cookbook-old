using System;
using System.Collections.Generic;
using Cookbook.Objects;

namespace Cookbook.Db.EntityTypes {
    internal class Ingredient : IDbItem, IIngredient {
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
        public IFood Food { get; set; }

        /// <inheritdoc />
        public IQuantity Quantity { get; set; }

        /// <inheritdoc />
        public float QuantityValue { get; set; }

        /// <inheritdoc />
        public ICollection<IComment> Comments { get; set; }
    }
}