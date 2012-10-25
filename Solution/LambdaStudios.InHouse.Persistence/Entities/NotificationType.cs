// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotificationType.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   NotificationType model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// NotificationType model.
    /// </summary>
    public class NotificationType : Catalog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationType" /> class.
        /// </summary>
        public NotificationType()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the template.
        /// </summary>
        /// <value>
        /// The template.
        /// </value>
        public virtual string Template { get; set; }
    }
}
