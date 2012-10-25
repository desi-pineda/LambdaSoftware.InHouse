// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Interaction.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Interaction model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// Interaction model.
    /// </summary>
    public class Interaction : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Interaction" /> class.
        /// </summary>
        public Interaction()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the advert.
        /// </summary>
        /// <value>
        /// The advert.
        /// </value>
        public virtual Advert Advert { get; set; }

        /// <summary>
        /// Gets or sets the visitor.
        /// </summary>
        /// <value>
        /// The visitor.
        /// </value>
        public virtual Visitor Visitor { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public virtual InteractionType Type { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public virtual string Comment { get; set; }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>
        /// The rate.
        /// </value>
        public virtual int? Rate { get; set; }
    }
}