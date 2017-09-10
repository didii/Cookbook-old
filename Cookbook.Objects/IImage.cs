using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    /// <summary>
    ///     An image stored as a byte array
    /// </summary>
    public interface IImage : ITracable, ITrackable {
        /// <summary>
        ///     Code for the image
        /// </summary>
        byte[] ByteArray { get; set; }

        /// <summary>
        ///     Optional comments about this image
        /// </summary>
        ICollection<IComment> Comments { get; set; }
    }
}