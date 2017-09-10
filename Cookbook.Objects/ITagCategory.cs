using System;

namespace Cookbook.Objects {
    /// <summary>
    ///     The category of any <see cref="ITag" />
    /// </summary>
    public interface ITagCategory : ITracable, ITrackable {
        /// <summary>
        ///     The name of the category
        /// </summary>
        string Name { get; set; }
    }
}