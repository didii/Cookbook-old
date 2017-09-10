using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    /// <summary>
    ///     A single comment on any type of object
    /// </summary>
    public interface IComment : ITracable, ITrackable {
        /// <summary>
        ///     The content of the message
        /// </summary>
        string Message { get; set; }

        /// <summary>
        ///     The direct reply to this comment
        /// </summary>
        IComment Reply { get; set; }
    }
}