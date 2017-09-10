using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Objects;

namespace Cookbook.Db.EntityTypes {
    /// <inheritdoc cref="IComment" />
    internal class Comment : IDbItem, IComment {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public string Message { get; set; }

        /// <inheritdoc />
        public IComment Reply { get; set; }

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