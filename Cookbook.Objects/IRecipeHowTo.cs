using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    public interface IRecipeHowTo {
        string Description { get; set; }
        ICollection<IComment> Comment { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        IUser CreatedBy { get; set; }
        IUser UpdatedBy { get; set; }
    }
}
