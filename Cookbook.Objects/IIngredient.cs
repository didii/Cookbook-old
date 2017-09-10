using System;

namespace Cookbook.Objects {
    public interface IIngredient {
        IFood Food { get; set; }
        IQuantity Quantity { get; set; }
        float QuantityValue { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
        IUser CreatedBy { get; set; }
        IUser UpdatedBy { get; set; }
    }
}