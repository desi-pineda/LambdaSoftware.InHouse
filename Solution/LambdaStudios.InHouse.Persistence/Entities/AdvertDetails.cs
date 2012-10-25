// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdvertDetails.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Advet details model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// Advet details model.
    /// </summary>
    public class AdvertDetails
    {
        /// <summary>
        /// Gets or sets the advert id.
        /// </summary>
        /// <value>
        /// The advert id.
        /// </value>
        private int AdvertId { get; set; }

        /// <summary>
        /// Gets or sets the advert.
        /// </summary>
        /// <value>
        /// The advert.
        /// </value>
        private Advert Advert { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertDetails" /> class.
        /// </summary>
        protected AdvertDetails()
        {
            Attachments = new List<Attachment>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertDetails" /> class.
        /// </summary>
        /// <param name="advert">The advert.</param>
        public AdvertDetails(Advert advert)
        {
            Attachments = new List<Attachment>();
            Advert = advert;
        }

        /// <summary>
        /// Gets or sets the address one.
        /// </summary>
        /// <value>
        /// The address one.
        /// </value>
        public virtual string AddressOne { get; set; }

        /// <summary>
        /// Gets or sets the address two.
        /// </summary>
        /// <value>
        /// The address two.
        /// </value>
        public virtual string AddressTwo { get; set; }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public virtual string ZipCode { get; set; }

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

        /// <summary>
        /// Gets or sets the map link.
        /// </summary>
        /// <value>
        /// The map link.
        /// </value>
        public virtual string MapLink { get; set; }

        /// <summary>
        /// Gets the attachments.
        /// </summary>
        /// <value>
        /// The attachments.
        /// </value>
        public virtual IList<Attachment> Attachments { get; private set; } 
    }
}
