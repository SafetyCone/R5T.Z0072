using System;

using R5T.T0131;


namespace R5T.Z0072.Z002
{
    /// <summary>
    /// Conceptually-named, derived, stringly-typed file extensions
    /// (un-opinionated).
    /// </summary>
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Z000.IFileExtensions _Raw => Z000.FileExtensions.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// The .NET assembly file extension.
        /// <para><inheritdoc cref="Z000.IFileExtensions.dll" path="descendant::value"/></para>
        /// </summary>
        public string Assembly => _Raw.dll;

        /// <summary>
        /// The C# code file extension.
        /// <para><inheritdoc cref="Z000.IFileExtensions.cs" path="descendant::value"/></para>
        /// </summary>
        public string CSharp_CodeFile => _Raw.cs;

        /// <summary>
        /// The Visual Studio C# project file extension.
        /// <para><inheritdoc cref="Z000.IFileExtensions.csproj" path="descendant::value"/></para>
        /// </summary>
        public string CSharp_ProjectFile => _Raw.csproj;

        /// <summary>
        /// The .NET assembly (or general dynamic-link library) file extension.
        /// <para><inheritdoc cref="Z000.IFileExtensions.dll" path="descendant::value"/></para>
        /// </summary>
        public string Dll => _Raw.dll;

        /// <summary>
        /// The JSON file extension.
        /// <para><inheritdoc cref="Z000.IFileExtensions.json" path="descendant::value"/></para>
        /// </summary>
        public string Json => _Raw.json;

        /// <summary>
        /// The Visual Studio solution file extension.
        /// <para><inheritdoc cref="Z000.IFileExtensions.sln" path="descendant::value"/></para>
        /// </summary>
        public string Solution_File => _Raw.sln;

        /// <summary>
        /// The text file extension.
        /// <para><inheritdoc cref="Z000.IFileExtensions.txt" path="descendant::value"/></para>
        /// </summary>
        public string Text => _Raw.txt;

        /// <inheritdoc cref="CSharp_ProjectFile"/>
        public string VisualStudio_CSharp_ProjectFile => this.CSharp_ProjectFile;

        /// <inheritdoc cref="Solution_File"/>
        public string VisualStudio_SolutionFile => this.Solution_File;

        /// <summary>
        /// The XML file extension.
        /// <para><inheritdoc cref="Z000.IFileExtensions.xml" path="descendant::value"/></para>
        /// </summary>
        public string Xml => _Raw.xml;
    }
}
