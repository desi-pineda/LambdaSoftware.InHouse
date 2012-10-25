// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppUser.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   User model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// User model.
    /// </summary>
    public class AppUser : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppUser" /> class.
        /// </summary>
        public AppUser()
        {
            CreatedAt = DateTime.UtcNow;
            Addresses = new List<Address>();
            Contacts = new List<Contact>();
            Roles = new List<Role>();
        }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>
        /// The company.
        /// </value>
        public virtual Company Company { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public virtual string LastName { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        /// <value>
        /// The addresses.
        /// </value>
        public virtual IList<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        /// <value>
        /// The contacts.
        /// </value>
        public virtual IList<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        /// <value>
        /// The roles.
        /// </value>
        public virtual IList<Role> Roles { get; set; }
    }
}
