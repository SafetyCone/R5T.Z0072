using System;

using R5T.T0131;


namespace R5T.Z0072
{
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker,
        Z004.IFileExtensions
    {
#pragma warning disable IDE1006 // Naming Styles
        public Z002.IFileExtensions _Strings => Z002.FileExtensions.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
