using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    public interface IComment {
        string Message { get; set; }
        IComment Reply { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        IUser CreatedBy { get; set; }
        IUser UpdatedBy { get; set; }
    }
}
