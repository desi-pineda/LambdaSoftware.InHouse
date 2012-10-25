// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InteractionType.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Interaction type model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// Interaction type model.
    /// </summary>
    public class InteractionType : Catalog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionType" /> class.
        /// </summary>
        public InteractionType()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}