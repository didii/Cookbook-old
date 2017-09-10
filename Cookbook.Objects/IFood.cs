using System;

namespace Cookbook.Objects {
    public interface IFood {
        string Name { get; set; }
        string NamePlural { get; set; }
        string Description { get; set; }
        IImage Image { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        IUser CreatedBy { get; set; }
        IUser UpdatedBy { get; set; }
    }
}