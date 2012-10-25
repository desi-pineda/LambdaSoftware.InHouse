// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AttachmentType.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   AttahcmentType model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// AttachmentType model.
    /// </summary>
    public class AttachmentType : Catalog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentType" /> class.
        /// </summary>
        public AttachmentType()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="AttachmentType" /> can be deleted.
        /// </summary>
        /// <value>
        /// <c>true</c> if can be deleted; otherwise, <c>false</c>.
        /// </value>
        public virtual bool Deletable { get; set; }

        /// <summary>
        /// Gets or sets the enabled extension.
        /// </summary>
        /// <value>
        /// The enabled extension.
        /// </value>
        public virtual string EnabledExtension { get; set; }
    }
}