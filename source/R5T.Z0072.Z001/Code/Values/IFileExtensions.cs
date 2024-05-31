using System;

using R5T.T0131;
using R5T.T0252;
using R5T.T0252.Extensions;


namespace R5T.Z0072.Z001
{
    /// <summary>
    /// Absolutely-named, fundamental (for the strong-type, derived from the underlying string type), strong-typed file extensions
    /// (unopinionated opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Z000.IFileExtensions _Strings => Z000.FileExtensions.Instance;
#pragma warning restore IDE1006 // Naming Styles


#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="Z000.IFileExtensions.bin"/>
        public IFileExtension bin => _Strings.bin.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.bmp"/>
        public IFileExtension bmp => _Strings.bmp.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.csproj"/>
        public IFileExtension csproj => _Strings.csproj.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.dat"/>
        public IFileExtension dat => _Strings.dat.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.dll"/>
        public IFileExtension dll => _Strings.dll.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.jpeg"/>
        public IFileExtension jpeg => _Strings.jpeg.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.jpg"/>
        public IFileExtension jpg => _Strings.jpg.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.json"/>
        public IFileExtension json => _Strings.json.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.png"/>
        public IFileExtension png => _Strings.png.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.sln"/>
        public IFileExtension sln => _Strings.sln.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.tmp"/>
        public IFileExtension tmp => _Strings.tmp.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.txt"/>
        public IFileExtension txt => _Strings.txt.ToFileExtension();

        /// <inheritdoc cref="Z000.IFileExtensions.xml"/>
        public IFileExtension xml => _Strings.xml.ToFileExtension();

#pragma warning restore IDE1006 // Naming Styles
    }
}
