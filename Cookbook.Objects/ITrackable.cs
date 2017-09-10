using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Objects {
    /// <summary>
    ///     Any object that should be tracked to a specific user that updated or created it
    /// </summary>
    public interface ITrackable {
        /// <summary>
        ///     Who created this item
        /// </summary>
        IUser CreatedBy { get; set; }

        /// <summary>
        ///     Who last updated this item
        /// </summary>
        IUser UpdatedBy { get; set; }
    }
}