using System;

namespace Cookbook.Objects {
    public interface IUser {
        string Name { get; set; }
        byte[] PasswordHash { get; set; }
        byte[] PasswordSalt { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
    }
}
