// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Visitor.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Model of a visitor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// Model of a visitor.
    /// </summary>
    public class Visitor : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Visitor" /> class.
        /// </summary>
        public Visitor()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>
        /// The user id.
        /// </value>
        public virtual int? UserId { get; set; }

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
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public virtual string Email { get; set; }
    }
}