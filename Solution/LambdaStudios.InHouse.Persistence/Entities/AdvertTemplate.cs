// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdvertTemplate.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Advert template model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// Advert template model.
    /// </summary>
    public class AdvertTemplate : Catalog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertTemplate" /> class.
        /// </summary>
        public AdvertTemplate()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        public virtual string Header { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public virtual string Body { get; set; }

        /// <summary>
        /// Gets or sets the footer.
        /// </summary>
        /// <value>
        /// The footer.
        /// </value>
        public virtual string Footer { get; set; }
    }
}