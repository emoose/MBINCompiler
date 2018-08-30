using System;
using System.Collections.Generic;
using System.IO;

using libMBIN;
using libMBIN.Models;
using libMBIN.Models.Structs;

namespace MBINCompiler
{
    using static CommandLineOptions;

    internal static class Convert
    {

        public static ErrorCode ConvertFileList( string inputDir, string outputDir, List<string> fileList, bool force )
        {
            var errorCode = ErrorCode.Success;
            foreach ( var fileIn in fileList ) {
                try {

                    string fileOut = fileIn;
                    if ( outputDir != null ) fileOut = fileOut.Replace( inputDir, outputDir );

                    var code = ConvertFile( fileIn, fileOut, InputFormat, OutputFormat );
                    if ( code == ErrorCode.Success ) continue;
                    if ( !force ) return code;
                    if ( errorCode == ErrorCode.Success ) errorCode = code;

                } catch ( Exception e ) {
                    if ( !force ) throw e;
                    e = e.GetBaseException();
                    Console.ShowError( $"{fileIn}\n\n{e.Message}\n\nStacktrace:\n\n{e.StackTrace}\n", wait: false );
                    errorCode = ErrorCode.Unknown;
                }
            }

            return errorCode;
        }

        public static ErrorCode ConvertFile( string fileIn, string fileOut, FormatType inputFormat, FormatType outputFormat )
        {
            fileOut = ChangeFileExtension( fileOut, outputFormat );

            FileMode fileMode = GetFileMode( fileOut );
            if ( fileMode == 0 ) return ErrorCode.FileExists;

            Directory.CreateDirectory( Path.GetDirectoryName( fileOut ) );

            try {
                using ( var fIn = new FileStream( fileIn, FileMode.Open, FileAccess.Read ) )
                using ( var ms = new MemoryStream() ) {

                    if ( inputFormat == FormatType.MBIN ) {
                        var mbin = new MBINFile( fIn );
                        if ( !mbin.Load() || !mbin.Header.IsValid ) return ErrorCode.FileInvalid;
                        var sw = new StreamWriter( ms );
                        sw.Write( EXmlFile.WriteTemplate( mbin.GetData() ) );
                        sw.Flush();
                    } else if ( inputFormat == FormatType.EXML ) {
                        var data = EXmlFile.ReadTemplateFromStream( fIn );
                        if (data is TkGeometryData) fileOut += ".PC";
                        var mbin = new MBINFile( ms ) { Header = new MBINHeader() };
                        mbin.Header.SetDefaults( data.GetType() );
                        mbin.SetData( data );
                        mbin.Save();
                    }

                    ms.Flush();
                    using ( var fOut = new FileStream( fileOut, fileMode, FileAccess.Write ) ) ms.WriteTo( fOut );
                }
            } catch ( Exception e ) {
                File.Delete( fileOut );
                throw e;
            }

            return ErrorCode.Success;
        }

        private static string ChangeFileExtension( string file, FormatType format )
        {
            string ext = format.ToString().ToUpper();
            if ( Path.HasExtension( file ) ) {
                string x = Path.GetExtension( file ).ToUpper();
                if ( x == ".PC" ) file = Path.ChangeExtension( file, null );
                return Path.ChangeExtension( file, ext );
            }
            return file + $".{ext}";
        }

        /// <summary>
        /// Gets the appropriate file mode based on the Overwrite option setting.
        /// For output files. If file exists and Overwrite is Prompt, the user will be asked
        /// how to handle the file.
        /// </summary>
        /// <param name="file">The file path to check.</param>
        /// <returns>A FileMode enum. The value is 0 if the user opted to keep the existing file.</returns>
        private static FileMode GetFileMode( string file )
        {
            if ( Overwrite == OverwriteMode.Always ) {
                return FileMode.Create;
            } else if ( Overwrite == OverwriteMode.Prompt ) {
                if ( File.Exists( file ) ) {
                    if ( !Utils.PromptOverwrite( file, ref OptionBackers.optOverwrite ) ) return (FileMode) 0;
                    return FileMode.Create;
                }
            }
            return FileMode.CreateNew; // OverwriteMode.Never or file doesn't exist
        }

    }

}
