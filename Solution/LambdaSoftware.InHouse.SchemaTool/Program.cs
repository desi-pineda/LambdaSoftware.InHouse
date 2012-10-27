// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Data;
using System.IO;
using NHibernate;

namespace LambdaSoftware.InHouse.SchemaTool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LambdaStudios.InHouse.Persistence.Configurations;

    /// <summary>
    /// Tool to generate the schema and execute any sql command directly to the database.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Class <see cref="ISession"/> instance.
        /// </summary>
        private static ISession _session;

        /// <summary>
        /// Valid operation for the command tool.
        /// </summary>
        private static readonly IList<string> Options = new List<string> {"-bootstrap"};

        /// <summary>
        /// Exec path.
        /// </summary>
        private static string Path;

        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            StringBuilder instructions = new StringBuilder();
            instructions.AppendLine("Options:");
            instructions.AppendLine(string.Format("{0}: will drop all database object and create the schema.", Options[0]));
            string option = string.Empty;
            int operation;
            if (args == null || string.IsNullOrWhiteSpace(option = args[0]) ||
                (operation = Options.IndexOf(option)) < 0)
            {
                Console.WriteLine(instructions.ToString());
                return;
            }

            Path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            ISessionFactory sessionFactory = NHConfiguration.Configure();
            _session = sessionFactory.OpenSession();
            switch (operation)
            {
                case 1: // -bootstrapping
                    BootstratSchema();
                    break;
                case 2: // -fill
                    break;
                case 3: // -run command
                    break;
                case 4: // -bootstrappingfill
                    break;
            }
        }

        /// <summary>
        /// Bootstrats the schema.
        /// </summary>
        private static void BootstratSchema()
        {
            DeleteAllRelationships();
            DeleteAllTables();
        }

        /// <summary>
        /// Deletes all tables.
        /// </summary>
        private static void DeleteAllTables()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes all relationships.
        /// </summary>
        private static void DeleteAllRelationships()
        {
            Console.WriteLine("DELETING ALL RELATIONSHIPS IN DATABASE......");
            string command = File.ReadAllText(string.Format("{0}\\SqlCommands\\00-delete-all-fkeys.sql", Path));
            IDbConnection connection = _session.Connection;
            IDbCommand databaseCommand = connection.CreateCommand();
            try
            {
                connection.Open();
                databaseCommand.CommandText = command;
                databaseCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                PrintException(e);
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Prints the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        private static void PrintException(Exception exception)
        {
            StringBuilder builder = new StringBuilder();
            do
            {
                builder.AppendLine(exception.Message);
                builder.AppendLine(exception.StackTrace);
                builder.AppendLine("--------------------------------------------------------------");
                exception = exception.InnerException;
            }
            while (exception != null);
            Console.WriteLine(builder.ToString());
        }
    }
}