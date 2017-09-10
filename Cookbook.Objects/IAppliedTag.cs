using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Objects {
    /// <summary>
    ///     A tag when applied to a specific recipe
    /// </summary>
    public interface IAppliedTag : ITracable, ITrackable {
        /// <summary>
        ///     The tag
        /// </summary>
        ITag Tag { get; set; }

        /// <summary>
        ///     The recipe
        /// </summary>
        IRecipe Recipe { get; set; }
    }
}