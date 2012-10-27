// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NHConfiguration.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   NHibernate configurator and <see cref="SessionFactory" /> exposser.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence.Configurations
{
    using Entities;
    using FluentNHibernate.Cfg;
    using NHibernate;
    using NHibernate.Cfg;

    /// <summary>
    /// NHibernate configurator and <see cref="SessionFactory"/> exposser.
    /// </summary>
    public class NHConfiguration
    {
        /// <summary>
        /// Gets or sets the session factory.
        /// </summary>
        /// <value>
        /// The session factory.
        /// </value>
        private static ISessionFactory SessionFactory { get; set; }

        /// <summary>
        /// Configures this instance.
        /// </summary>
        /// <returns>
        /// The <see cref="SessionFactory"/> for the repository.
        /// </returns>
        public static ISessionFactory Configure()
        {
            if (SessionFactory == null)
            {
                Configuration configuration = new Configuration().Configure();
                SessionFactory = Fluently
                    .Configure(configuration)
                    .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(AppUser).Assembly))
                    .BuildSessionFactory(); 
            }

            return SessionFactory;
        }
    }
}
