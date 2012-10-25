// --------------------------------------------------------------------------------------------------------------------
// <copyright file="State.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   State model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    using System;

    /// <summary>
    /// State model.
    /// </summary>
    public class State : Catalog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="State" /> class.
        /// </summary>
        public State()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}