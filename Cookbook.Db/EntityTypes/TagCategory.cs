using System;
using Cookbook.Objects;

namespace Cookbook.Db.EntityTypes {
    /// <inheritdoc cref="ITagCategory" />
    internal class TagCategory : IDbItem, ITagCategory {
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
    }
}