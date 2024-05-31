using System;

using R5T.T0131;


namespace R5T.Z0072.Z000
{
    /// <summary>
    /// Absolutely-named, fundamental, stringly-typed file extensions
    /// (unopionated).
    /// </summary>
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>bin</value></para>
        /// </summary>
        public string bin => "bin";

        /// <summary>
        /// <para><value>bmp</value></para>
        /// </summary>
        public string bmp => "bmp";

        /// <summary>
        /// <para><value>cs</value></para>
        /// </summary>
        public string cs => "cs";

        /// <summary>
        /// <para><value>csproj</value></para>
        /// </summary>
        public string csproj => "csproj";

        /// <summary>
        /// <para><value>dat</value></para>
        /// </summary>
        public string dat => "dat";

        /// <summary>
        /// <para><value>dll</value></para>
        /// </summary>
        public string dll => "dll";

        /// <summary>
        /// <para><value>exe</value></para>
        /// </summary>
        public string exe => "exe";

        /// <summary>
        /// <para><value>jpeg</value></para>
        /// </summary>
        public string jpeg => "jpeg";

        /// <summary>
        /// <para><value>jpg</value></para>
        /// </summary>
        public string jpg => "jpg";

        /// <summary>
        /// <para><value>json</value></para>
        /// </summary>
        public string json => "json";

        /// <summary>
        /// <para><value>png</value></para>
        /// </summary>
        public string png => "png";

        /// <summary>
        /// <para><value>resx</value></para>
        /// </summary>
        public string resx => "resx";

        /// <summary>
		/// <para><value>sln</value></para>
		/// </summary>
		public string sln => "sln";

        /// <summary>
        /// <para><value>txt</value></para>
        /// </summary>
        public string txt => "txt";

        /// <summary>
        /// <para><value>tmp</value></para>
        /// </summary>
        public string tmp => "tmp";

        /// <summary>
        /// <para><value>xml</value></para>
        /// </summary>
        public string xml => "xml";

#pragma warning restore IDE1006 // Naming Styles
    }
}
