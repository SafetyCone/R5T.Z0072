using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0072.Z002
{
    /// <summary>
    /// Conceptually-named, derived, stringly-typed directory names
    /// (un-opinionated).
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private Z000.IDirectoryNames _Raw => Z000.DirectoryNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// The name of the Git-specific hiddent directory created and used by Git to make a regular filesystem directory into a Git repository.
        /// <para><inheritdoc cref="Z000.IDirectoryNames._git" path="descendant::value"/></para>
        /// </summary>
        public string Git_Repository_HiddenDirectoryName => _Raw._git;

        /// <summary>
        /// The name of the Visual Studio-specific hidden directory created by Visual Studio in any solution directory
        /// when the solution is opened.
        /// <para><inheritdoc cref="Z000.IDirectoryNames._vs" path="descendant::value"/></para>
        /// </summary>
        public string VisualStudio_Solution_HiddenDirectoryName => _Raw._vs;
    }
}
