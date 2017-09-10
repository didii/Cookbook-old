using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Objects;

namespace Cookbook.Db.EntityTypes {
    /// <inheritdoc cref="IImage"/>
    internal class Image : IDbItem, IImage {
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
        public byte[] ByteArray { get; set; }

        /// <inheritdoc />
        public ICollection<IComment> Comments { get; set; }
    }
}
