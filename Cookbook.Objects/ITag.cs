using System;

namespace Cookbook.Objects {
    /// <summary>
    ///     A tag belonging to a recipe
    /// </summary>
    public interface ITag : ITracable, ITrackable {
        /// <summary>
        ///     The name of this tag
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     The category this tag belongs to
        /// </summary>
        ITagCategory Category { get; set; }
    }
}