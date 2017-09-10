using System;

namespace Cookbook.Objects {
    public interface ITag {
        string Name { get; set; }
        ITagCategory Category { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        IUser CreatedBy { get; set; }
        IUser UpdatedBy { get; set; }

    }
}
