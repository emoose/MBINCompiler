using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBINCompilerTests {

    using DebugLevel = Logger.DebugLevel;

    internal static class RunSettings {

        private const string OPT_LOG_LEVEL              = "LogLevel";
        private const string OPT_ROOT_DATA_DIR          = "RootDataDir";
        private const string OPT_GAMEDATA_DIR           = "GameDataDir";
        private const string OPT_GAMEDATA_VERSION       = "GameDataVersion";
        private const string OPT_MAX_CONCURRENT_THREADS = "MaxConcurrentThreads";
        private const string OPT_CURRENT_DATA_VERSION   = "CurrentDataVersion";
        private const string OPT_COMPARE_DATA_VERSION   = "CompareDataVersion";

        public static string ProjectDir { get; private set; }
        public static string LogResultsDir { get; private set; }

        public static System.Version GameDataVersion { get; private set; }
        public static string GameDataDir { get; private set; }
        public static int MaxConcurrentThreads { get; private set; }

        public static System.Version CurrentDataVersion { get; private set; }
        public static System.Version CompareDataVersion { get; private set; }

        public static string RootDataDir { get; private set; }
        public static string CurrentDataDir { get; private set; }
        public static string CompareDataDir { get; private set; }

        public static void Initialize( TestContext context ) {
            // ( back out of bin\[Debug|Release] directories )
            ProjectDir = Path.GetFullPath( Path.Combine( Directory.GetCurrentDirectory(), "..", ".." ) );
            LogResultsDir = Path.Combine( context.TestRunDirectory, ".." );

            Logger.Level = GetEnumProperty<DebugLevel>( context, OPT_LOG_LEVEL, DebugLevel.Info );

            RootDataDir = GetStringProperty( context, OPT_ROOT_DATA_DIR, "Data" );
            if ( !Path.IsPathRooted( RootDataDir ) ) RootDataDir = Path.Combine( ProjectDir, RootDataDir );

            GameDataVersion = GetVersionProperty( context, OPT_GAMEDATA_VERSION, libMBIN.Version.NMSVersion );
            GameDataDir = GetStringProperty( context, OPT_GAMEDATA_DIR, "" );
            MaxConcurrentThreads = GetIntProperty( context, OPT_MAX_CONCURRENT_THREADS, 4 );

            CurrentDataVersion = GetVersionProperty( context, OPT_CURRENT_DATA_VERSION, GameDataVersion );
            CompareDataVersion = GetVersionProperty( context, OPT_COMPARE_DATA_VERSION, CurrentDataVersion );
            // if not specified, get the last version prior to CurrentDataVersion
            if (CompareDataVersion == CurrentDataVersion) {
                CompareDataVersion = new System.Version();
                if ( Directory.Exists( RootDataDir ) ) {
                    foreach ( string path in Directory.GetDirectories( RootDataDir ) ) {
                        System.Version version = new System.Version( Path.GetFileName( path ) );
                        if ( version >= CurrentDataVersion ) continue;
                        if ( version > CompareDataVersion ) CompareDataVersion = version;
                    }
                }
            }

            CurrentDataDir = Path.Combine( RootDataDir, CurrentDataVersion.ToString() );
            Directory.CreateDirectory( CurrentDataDir ); // create the directory path if it doesn't exist

            CompareDataDir = Path.Combine( RootDataDir, CompareDataVersion.ToString() );
            //if ( !Directory.Exists( CompareDataDir ) ) throw new PathNotFoundException( OPT_COMPARE_DATA_VERSION, CompareDataDir );
        }

        #region Validation
        public class NotConfiguredException : Exception {
            public NotConfiguredException( string parameter )
            : base( $"{parameter} not configured?\n"
                    + "You must configure and use a .runsettings file with these unit tests.\n"
                    + "See the comments in the Config/example.runsettings file for details." ) { }
        }

        public class PathNotFoundException : Exception {
            public PathNotFoundException( string parameter, string path )
            : base( "Path not found.\n"
                    + $"Invalid {parameter} parameter specified in runsettings.\n"
                    + $"\"{path}\"" ) { }
        }

        public static void ValidateGameDataPath() {
            if ( String.IsNullOrEmpty( GameDataDir ) ) throw new NotConfiguredException( OPT_GAMEDATA_DIR );
            if ( !Directory.Exists( GameDataDir ) ) throw new PathNotFoundException( OPT_GAMEDATA_DIR, GameDataDir );
        }
        #endregion

        #region Property helpers
        public static string GetStringProperty( TestContext context, string parameter, string defaultValue ) {
            string value = (string) context.Properties[parameter];
            if ( value == null ) return defaultValue;
            return value;
        }

        public static bool GetBoolProperty( TestContext context, string parameter, bool defaultValue ) {
            string value = (string) context.Properties[parameter];
            if ( value == null ) return defaultValue;
            return bool.Parse( value );
        }

        public static T GetEnumProperty<T>( TestContext context, string parameter, T defaultValue ) where T : struct {
            string value = (string) context.Properties[parameter];
            if ( value == null ) return defaultValue;
            return (T) Enum.Parse( typeof( T ), value, true );
        }

        public static int GetIntProperty( TestContext context, string parameter, int defaultValue ) {
            string value = (string) context.Properties[parameter];
            if ( value == null ) return defaultValue;
            return int.Parse( value );
        }

        public static System.Version GetVersionProperty( TestContext context, string parameter, System.Version defaultValue ) {
            string value = (string) context.Properties[parameter];
            if ( value == null ) return defaultValue;
            return System.Version.Parse( value );
        }

        #endregion

    }

}
