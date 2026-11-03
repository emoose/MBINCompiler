using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using libMBIN;

namespace libMBIN
{
    /// <summary>
    /// Container class for general file loading methods.
    /// </summary>
    public class FileIO
    {
        /// <summary>
        /// Loads a file and returns an NMSTemplate which can be either used as-is, or cast to a specific type.
        /// The path to either an .mxml or .mbin can be provided here and the correct method will be selected automatically.
        /// </summary>
        /// <param name="file">File path to the .mxml or .mbin to be loaded into memory.</param>
        /// <returns>NMSTemplate</returns>
        public static NMSTemplate LoadFile(string file)
        {
            NMSTemplate data = null;
            if (Path.HasExtension(file))
            {
                string x = Path.GetExtension(file).ToUpper();
                if (x == ".MXML")
                {
                    data = LoadMxml(file);
                }
                else if (x == ".MBIN" || x == ".PC")
                {
                    data = LoadMbin(file);
                }
                else
                {
                    throw new InvalidDataException($"{file} does not have a supported file type. File type must be one of .mxml or .mbin");
                }
            }
            return data;
        }

        /// <summary>
        /// Loads an .mbin file and returns an NMSTemplate which can be either used as-is, or cast to a specific type.
        /// </summary>
        /// <param name="path">File path to the .mbin to be loaded into memory.</param>
        /// <returns>NMSTemplate</returns>
        public static NMSTemplate LoadMbin(string path)
        {
            MBINFile mbin = new MBINFile(path);
            if (!mbin.Load() || !mbin.Header.IsValid) throw new InvalidDataException("Not a valid MBIN file!");

            NMSTemplate data = null;
            try
            {
                data = mbin.GetData();
                if (data is null) throw new InvalidDataException("Invalid MBIN data.");
            }
            catch (Exception e)
            {
                throw new MbinException($"Failed to read {mbin.Header.GetXMLTemplateName()} from MBIN.", e, path);
            }
            mbin.Dispose();
            return data;
        }

        /// <summary>
        /// Loads an .mxml file and returns an NMSTemplate which can be either used as-is, or cast to a specific type.
        /// </summary>
        /// <param name="path">File path to the .mxml to be loaded into memory.</param>
        /// <returns>NMSTemplate</returns>
        public static NMSTemplate LoadMxml(string path)
        {
            return MXmlFile.ReadTemplate(path);
        }
    }
}
