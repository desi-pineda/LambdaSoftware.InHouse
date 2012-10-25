// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Catalog.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Catalog base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Entities
{
    /// <summary>
    /// Catalog base.
    /// </summary>
    public abstract class Catalog : Entity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public virtual string Code { get; set; }
    }
}
