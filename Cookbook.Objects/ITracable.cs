using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Objects {
    /// <summary>
    ///     Any object that should be tracable to a date of when it was created and last updated
    /// </summary>
    public interface ITracable {
        /// <summary>
        ///     The date when this item was created
        /// </summary>
        DateTime CreatedOn { get; set; }

        /// <summary>
        ///     The date for when this item was last updated
        /// </summary>
        DateTime UpdatedOn { get; set; }
    }
}