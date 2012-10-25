// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Company.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Company model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// Company model.
    /// </summary>
    public class Company : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        public Company()
        {
            CreatedAt = DateTime.UtcNow;
            Users =  new List<AppUser>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the contact.
        /// </summary>
        /// <value>
        /// The name of the contact.
        /// </value>
        public virtual string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the contact email.
        /// </summary>
        /// <value>
        /// The contact email.
        /// </value>
        public virtual string ContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public virtual IList<AppUser> Users { get; set; }
    }
}
