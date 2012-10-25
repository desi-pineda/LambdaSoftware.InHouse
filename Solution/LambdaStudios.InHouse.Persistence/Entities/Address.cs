// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Address model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// Address model.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        public Address()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public virtual AppUser User { get; set; }

        /// <summary>
        /// Gets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        public virtual DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or sets the part one.
        /// </summary>
        /// <value>
        /// The part one.
        /// </value>
        public virtual string PartOne { get; set; }

        /// <summary>
        /// Gets or sets the part two.
        /// </summary>
        /// <value>
        /// The part two.
        /// </value>
        public virtual string PartTwo { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public virtual string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public virtual State State { get; set; }
    }
}