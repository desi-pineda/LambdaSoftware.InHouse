// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBootstrapper.cs" company="Lambda Studios">
//   InHouse
//   2012
// </copyright>
// <summary>
//   Contract for all the classes that configure a services at ApplicationStart.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LambdaStudios.InHouse.Persistence
{
    /// <summary>
    /// Contract for all the classes that configure a services at ApplicationStart.
    /// </summary>
    public interface IBootstrapper
    {
        /// <summary>
        /// Executes this instance.
        /// </summary>
        void Execute();
    }
}
