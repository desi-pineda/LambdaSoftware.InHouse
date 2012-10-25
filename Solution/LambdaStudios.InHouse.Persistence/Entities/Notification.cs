// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Notification.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Notification model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// Notification model.
    /// </summary>
    public class Notification : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        public Notification()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public virtual NotificationType Type { get; set; }

        /// <summary>
        /// Gets or sets the destiny.
        /// </summary>
        /// <value>
        /// The destiny.
        /// </value>
        public virtual AppUser Destiny { get; set; }
    }
}
