// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Role.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Role model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Role model.
    /// </summary>
    public class Role : Catalog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        public Role()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public virtual IList<AppUser> Users { get; set; } 
    }
}
