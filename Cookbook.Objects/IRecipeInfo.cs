using System;
using System.Collections.Generic;

namespace Cookbook.Objects {
    public interface IRecipeInfo {
        int Servings { get; set; }
        TimeSpan Duration { get; set; }
        ICollection<ITag> Tags { get; set; }
        float EstimatedPrice { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        IUser CreatedBy { get; set; }
        IUser UpdatedBy { get; set; }

    }
}
