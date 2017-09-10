using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Db.EntityTypes {
    internal interface IDbItem {
        /// <summary>
        /// The internal ID of this item
        /// </summary>
        int Id { get; set; }
    }
}