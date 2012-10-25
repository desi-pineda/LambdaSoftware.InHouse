// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Attachment.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Attachment model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// Attachment model.
    /// </summary>
    public class Attachment : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        public Attachment()
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
        /// Gets or sets the type of the attachment.
        /// </summary>
        /// <value>
        /// The type of the attachment.
        /// </value>
        public virtual AttachmentType AttachmentType { get; set; }

        /// <summary>
        /// Gets or sets the name of the user file.
        /// </summary>
        /// <value>
        /// The name of the user file.
        /// </value>
        public virtual string UserFileName { get; set; }

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        public virtual string FileExtension { get; set; }
    }
}
