using System;

using R5T.T0131;
using R5T.T0252;


namespace R5T.Z0072.Z004
{
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Z001.IFileExtensions _Raw => Z001.FileExtensions.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// The .NET assembly file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.dll" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Assembly => _Raw.dll;

        /// <summary>
        /// The general binary file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.bin" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Binary => _Raw.bin;

        /// <summary>
        /// The bitmap file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.bmp" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Bitmap => _Raw.bmp;

        /// <summary>
        /// The Visual Studio C# project file extension.
        /// <para><inheritdoc cref="Z000.IFileExtensions.csproj" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension CSharp_ProjectFile => _Raw.csproj;

        /// <summary>
        /// The generaly data file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.dat" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Data => _Raw.dat;

        /// <summary>
        /// The .NET C# assembly (or general dynamic-link library) file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.dll" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Dll => _Raw.dll;


        /// <summary>
        /// The dynamic link library file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.dll" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension DynamicLinkLibrary => _Raw.dll;

        /// <summary>
        /// The JPEG image file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.jpeg" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Jpeg => _Raw.jpeg;

        /// <summary>
        /// The JPG image file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.jpg" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Jpg => _Raw.jpg;

        /// <summary>
        /// The PNG image file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.png" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Png => _Raw.png;

        /// <summary>
        /// The Visual Studio solution file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.sln" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Solution_File => _Raw.sln;

        /// <summary>
        /// The temporary file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.tmp" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Temporary => _Raw.tmp;

        /// <summary>
        /// The text file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.txt" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Text => _Raw.txt;

        /// <summary>
        /// The JSON file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.json" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Json => _Raw.json;

        /// <summary>
        /// The XML file extension.
        /// <para><inheritdoc cref="Z001.IFileExtensions.xml" path="descendant::value"/></para>
        /// </summary>
        public IFileExtension Xml => _Raw.xml;
    }
}
