using System;
using Cookbook.Objects;

namespace Cookbook.Db.EntityTypes {
    /// <inheritdoc cref="IQuantityType" />
    internal class QuantityType : IDbItem, IQuantityType {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public IQuantity BaseQuantity { get; set; }

        /// <inheritdoc />
        public DateTime CreatedOn { get; set; }

        /// <inheritdoc />
        public DateTime UpdatedOn { get; set; }

        /// <inheritdoc />
        public IUser CreatedBy { get; set; }

        /// <inheritdoc />
        public IUser UpdatedBy { get; set; }
    }
}