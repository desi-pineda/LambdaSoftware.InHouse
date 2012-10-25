// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Entity.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Base entity for all the model related to database schema.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence
{
    using System;

    /// <summary>
    /// Base entity for all the model related to database schema.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        public virtual DateTime CreatedAt { get; protected set; }
    }
}
