// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InteractionMap.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Mapping for <see cref="Interaction" /> model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Mappings
{
    using Entities;
    using FluentNHibernate.Mapping;
    
    /// <summary>
    /// Mapping for <see cref="Interaction"/> model.
    /// </summary>
    public class InteractionMap : ClassMap<Interaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionMap" /> class.
        /// </summary>
        public InteractionMap()
        {
            Id(x => x.Id).GeneratedBy.HiLo("nhHiLo", "Interaction", "1024");
            Map(x => x.Comment).Nullable().Length(1024);
            Map(x => x.Rate).Nullable();
            References(x => x.Type).Not.Nullable();
        }
    }
}
