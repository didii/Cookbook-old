using System;

namespace Cookbook.Objects {
    /// <summary>
    ///     A user
    /// </summary>
    public interface IUser : ITracable {
        /// <summary>
        ///     The name of the user
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     The hash of the password of the user
        /// </summary>
        byte[] PasswordHash { get; set; }

        /// <summary>
        ///     The salt to be prepended to the password
        /// </summary>
        byte[] PasswordSalt { get; set; }
    }
}