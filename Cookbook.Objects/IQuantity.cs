using System;

namespace Cookbook.Objects {
    public interface IQuantity {
        string Name { get; set; }
        string ShortName { get; set; }
        float Multiplier { get; set; }
        IQuantityType QuantityType { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        IUser CreatedBy { get; set; }
        IUser UpdatedBy { get; set; }
    }
}