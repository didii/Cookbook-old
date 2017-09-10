using System;
using Cookbook.Objects;

namespace Cookbook.Db.EntityTypes {
    /// <inheritdoc cref="IQuantity" />
    public class Quantity : IDbItem, IQuantity {
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
        public string ShortName { get; set; }

        /// <inheritdoc />
        public float Multiplier { get; set; }

        /// <inheritdoc />
        public IQuantityType QuantityType { get; set; }
    }
}