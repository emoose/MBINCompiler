using libMBIN;

namespace MBINCompiler
{

    internal class Version {

        /// <summary>Get the version info for a specified MBIN <paramref name="file"/>.</summary>
        /// <param name="file">The MBIN file to display the version info for.</param>
        /// <param name="quiet">
        ///     If true then a plain, script-friendly version string is displayed.
        ///     If false then a human-friendly message is displayed.
        /// </param>
        public static string GetMBINVersion(MBINFile file, bool quiet = false) {
            System.Version mbinVersion = file.Header.GetMBINVersion();
            string versionString = mbinVersion.ToString();

            return !quiet
                ? ( versionString != "0.0.0.0" )
                ? "Compiled with MBINCompiler v" + versionString
                : "Unknown MBIN version!\nNot compiled by MBINCompiler."
                : versionString;
        }

        /// <summary>
        /// Get the version string for both MBINCompiler and libMBIN.
        /// Human-friendly formatted.
        /// </summary>
        public static string GetVersionStringVerbose() => $"MBINCompiler v{libMBIN.Version.GetString()}";

        /// <summary>
        /// Get the version string without any decoration (just "X.X.X.X").
        /// Plainly formatted.
        /// </summary>
        public static string GetVersionStringCompact() => libMBIN.Version.AssemblyVersion.ToString();

        /// <summary>Get the version string in either long (verbose) or short (compact) format.</summary>
        /// <param name="quiet">
        /// If quiet = false (default), then display a long-format, human-friendly version string.
        /// Otherwise display a short-format, computer-friendly version string.
        /// </param>
        /// <returns>A long or short formatted version string.</returns>
        public static string GetVersionString( bool quiet = false ) => quiet ? GetVersionStringCompact() : GetVersionStringVerbose();

    }

}
