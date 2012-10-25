// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdvertType.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Advert type model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// Advert type model.
    /// </summary>
    public class AdvertType : Catalog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertType" /> class.
        /// </summary>
        public AdvertType()
        {
            CreatedAt = DateTime.UtcNow;
            Adverts = new List<Advert>();
        }

        /// <summary>
        /// Gets or sets the template.
        /// </summary>
        /// <value>
        /// The template.
        /// </value>
        public virtual AdvertTemplate Template { get; set; }

        /// <summary>
        /// Gets the adverts.
        /// </summary>
        /// <value>
        /// The adverts.
        /// </value>
        public virtual IList<Advert> Adverts { get; private set; }
    }
}