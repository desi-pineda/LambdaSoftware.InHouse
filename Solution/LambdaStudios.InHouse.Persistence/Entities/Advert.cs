// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Advert.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Add model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Add model.
    /// </summary>
    public class Advert : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Advert" /> class.
        /// </summary>
        public Advert()
        {
            CreatedAt = DateTime.UtcNow;
            Interactions = new List<Interaction>();
        }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        /// <value>
        /// The owner.
        /// </value>
        public virtual AppUser Owner { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public virtual AdvertType Type { get; set; }

        /// <summary>
        /// Gets or sets the interactions.
        /// </summary>
        /// <value>
        /// The interactions.
        /// </value>
        public virtual IList<Interaction> Interactions { get; set; }
    }
}
