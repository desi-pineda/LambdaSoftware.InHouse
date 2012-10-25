// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InteractionTypeMap.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Mapping for <see cref="InteractionType" /> model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Mappings
{
    using Entities;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Mapping for <see cref="InteractionType"/> model.
    /// </summary>
    public class InteractionTypeMap : ClassMap<InteractionType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionTypeMap" /> class.
        /// </summary>
        public InteractionTypeMap()
        {
            Id(x => x.Id).GeneratedBy.HiLo("nhHiLo", "InteractionType", "1024");
            Map(x => x.Name).Not.Nullable().Length(100).Unique();
            Map(x => x.Code).Not.Nullable().Length(10).Unique();
            Map(x => x.Enabled).Not.Nullable();
        }
    }
}
