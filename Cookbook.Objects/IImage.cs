using System;

namespace Cookbook.Objects {
    public interface IImage {
        byte[] ByteArray { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        IUser CreatedBy { get; set; }
        IUser UpdatedBy { get; set; }
    }
}
