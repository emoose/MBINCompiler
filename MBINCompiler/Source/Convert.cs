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

                    ConvertFile( fileIn, fileOut, InputFormat, OutputFormat );

                } catch ( Exception e ) {
                    if ( !force ) throw;
                    e = e.GetBaseException();
                    CommandLine.ShowError( $"{e.Message}\n{fileIn}\n", wait: false );
                    using ( var indent = new Logger.IndentScope() ) {
                        Logger.LogMessage( $"{e.GetType()}:" );
                        Logger.LogMessage( $"\n{e.StackTrace}" );
                    }
                    errorCode = ErrorCode.Unknown;
                }
            }

            return errorCode;
        }

        public static void ConvertFile( string fileIn, string fileOut, FormatType inputFormat, FormatType outputFormat )
        {
            Logger.LogInfo( $"Converting {fileIn}" );

            fileOut = ChangeFileExtension( fileOut, outputFormat );

            FileMode fileMode = GetFileMode( fileOut );

            Directory.CreateDirectory( Path.GetDirectoryName( fileOut ) );

            Logger.Indent();
            try {
                using ( var fIn = new FileStream( fileIn, FileMode.Open, FileAccess.Read ) )
                using ( var ms = new MemoryStream() ) {

                    if ( inputFormat == FormatType.MBIN ) {
                        var mbin = new MBINFile( fIn );
                        if ( !mbin.Load() || !mbin.Header.IsValid ) throw new InvalidDataException( "Not a valid MBIN file!" );
                        Logger.LogMessage( "INFO", $"MBIN\tversion:\t{mbin.Header.GetMBINVersion()}\tguid:\t{mbin.Header.TemplateGUID:X}\ttemplate:\t{mbin.Header.TemplateName}\tsize:\t{fIn.Length}" );

                        var sw = new StreamWriter( ms );
                        var data = mbin.GetData();
                        if ( data is null ) throw new InvalidDataException( $"Failed to read {mbin.Header.GetXMLTemplateName()} from MBIN." );
                        sw.Write( EXmlFile.WriteTemplate( data ) );
                        sw.Flush();
                        if ( ms.Length == 0 ) throw new InvalidDataException( $"Failed serializing {mbin.Header.GetXMLTemplateName()} to EXML." );

                    } else if ( inputFormat == FormatType.EXML ) {
                        var data = EXmlFile.ReadTemplateFromStream( fIn );
                        if ( data is null ) throw new InvalidDataException( $"Failed to deserialize EXML." );
                        if (data is TkGeometryData) fileOut += ".PC";
                        var mbin = new MBINFile( ms ) { Header = new MBINHeader() };
                        mbin.Header.SetDefaults( data.GetType() );
                        mbin.SetData( data );
                        mbin.Save();
                    }

                    ms.Flush();
                    using ( var fOut = new FileStream( fileOut, fileMode, FileAccess.Write ) ) ms.WriteTo( fOut );
                }
            } finally {
                Logger.Unindent();
            }

        }

        private static string ChangeFileExtension( string file, FormatType format )
        {
            string ext = format.ToString().ToUpper();
            if ( Path.HasExtension( file ) ) {
                string x = Path.GetExtension( file ).ToUpper();
                if ( x == ".PC" ) file = Path.ChangeExtension( file, null );
                x = Path.GetExtension( file ).ToUpper();
                if (x == ".MBIN") return Path.ChangeExtension( file, ext );
                if (x == ".EXML") return Path.ChangeExtension( file, ext );
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
                    if ( Utils.PromptOverwrite( file, ref OptionBackers.optOverwrite ) ) return FileMode.Create;
                    throw new IOException( "The destination file already exists!" );
                }
            }
            return FileMode.CreateNew; // OverwriteMode.Never or file doesn't exist
        }

    }

}
