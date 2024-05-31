using System;

using R5T.T0131;


namespace R5T.Z0072.Z000
{
    /// <summary>
    /// Absolutely-named, fundamental, stringly-typed directory names
    /// (unopionated).
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>_framework</value></para>
        /// </summary>
        public string _framework => "_framework";

        /// <summary>
        /// <para><value>.git</value></para>
        /// </summary>
        public string _git => ".git";

        /// <summary>
        /// <para><value>.vs</value></para>
        /// </summary>
        public string _vs => ".vs";

        /// <summary>
        /// <para><value>bin</value></para>
        /// </summary>
        public string bin => "bin";

        /// <summary>
        /// <para><value>obj</value></para>
        /// </summary>
        public string obj => "obj";

        /// <summary>
        /// <para><value>node_modules</value></para>
        /// </summary>
        public string node_modules => "node_modules";

        /// <summary>
        /// <para><value>wwwroot</value></para>
        /// </summary>
        public string wwwroot => "wwwroot";

#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>Components</value></para>
        /// </summary>
        public string Components => "Components";

        /// <summary>
        /// <para><value>Pages</value></para>
        /// </summary>
        public string Pages => "Pages";

        /// <summary>
        /// <para><value>Properties</value></para>
        /// </summary>
        public string Properties => "Properties";

        /// <summary>
        /// <para><value>Shared</value></para>
        /// </summary>
        public string Shared => "Shared";
    }
}
