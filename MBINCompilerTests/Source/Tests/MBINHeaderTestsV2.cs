using System;
using libMBIN.Models;
using libMBIN.Models.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace libMBIN.UnitTests {

    [TestClass]
    public class MBINHeaderTestsV2 {

        private const ushort FORMAT_V2 = 2;
        private const uint FORMAT_ID = (MBINHeader.MBIN_VERSION & 0xFFFF) | (FORMAT_V2 & 0xFFFF) << 16;

        private static readonly string NMS_VERSION_STRING = Version.NMSVersion.ToString();
        private static readonly string API_VERSION_STRING = Version.AssemblyVersion.ToString();

        private const uint NMS_VERSION_ID = 0x00003B01;
        private const uint API_VERSION_ID = 0x02003B01;

        private const ulong VERSION_ID = (NMS_VERSION_ID & 0xFFFFFFFF) | (((ulong) API_VERSION_ID & 0xFFFFFFFF) << 32);

        private const ulong  TEMPLATE_GUID = 0x0F1E2D3C4B5A6978;

        private const string TEMPLATE_NAME = "templateName";
        private const ulong  METAOFFSET    = 0ul;

        private static readonly NMSAttribute[] attrTkGeometryData = (NMSAttribute[]) typeof( TkGeometryData ).GetCustomAttributes( typeof( NMSAttribute ), false );
        private static readonly ulong TKGEOMETRYDATA_GUID = ((attrTkGeometryData?.Length ?? 0) != 0) ? attrTkGeometryData[0].GUID : 0;

        private MBINHeader CreateMockHeader(
                    uint magic        = MBINHeader.MBIN_MAGIC,
                    uint formatID     = FORMAT_ID,
                    ulong versionID   = VERSION_ID,
                    ulong guid        = TEMPLATE_GUID,
                    string name       = TEMPLATE_NAME,
                    ulong metaOffset  = METAOFFSET
        ) {
            return new MBINHeader() {
                MagicID       = magic,
                FormatID      = formatID,
                VersionID     = versionID,
                TemplateGUID  = guid,
                TemplateName  = name,
                MetaOffset    = metaOffset
            };
        }

        private MBINHeader HeaderCommon => CreateMockHeader();
        private MBINHeader HeaderTkGeometryData => CreateMockHeader( magic: MBINHeader.MBIN_MAGIC_PC );

        [TestMethod]
        public void TestIsValid() {
            Assert.IsTrue( HeaderCommon.IsValid );
            Assert.IsTrue( HeaderTkGeometryData.IsValid );
        }

        [TestMethod]
        public void TestGetFormat() {
            Assert.AreEqual( 2, HeaderCommon.GetFormat() );
            Assert.AreEqual( 2, HeaderTkGeometryData.GetFormat() );
        }

        [TestMethod]
        public void TestIsFormatV0() {
            Assert.IsFalse( HeaderCommon.IsFormatV0 );
            Assert.IsFalse( HeaderTkGeometryData.IsFormatV0 );
        }

        [TestMethod]
        public void TestIsFormatV1() {
            Assert.IsFalse( HeaderCommon.IsFormatV1 );
            Assert.IsFalse( HeaderTkGeometryData.IsFormatV1 );
        }

        [TestMethod]
        public void TestIsFormatV2() {
            Assert.IsTrue( HeaderCommon.IsFormatV2 );
            Assert.IsTrue( HeaderTkGeometryData.IsFormatV2 );
        }

        [TestMethod]
        public void TestCreateHeaderCommon() {
            Assert.AreEqual( MBINHeader.MBIN_MAGIC,     HeaderCommon.MagicID );
            Assert.AreEqual( FORMAT_ID,                 HeaderCommon.FormatID );
            Assert.AreEqual( VERSION_ID,                HeaderCommon.VersionID );
            Assert.AreEqual( TEMPLATE_GUID,             HeaderCommon.TemplateGUID );
            Assert.AreEqual( TEMPLATE_NAME,             HeaderCommon.TemplateName );
            Assert.AreEqual( METAOFFSET,                HeaderCommon.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION,   HeaderCommon.FormatNMS );
            Assert.AreEqual( FORMAT_V2,                 HeaderCommon.FormatAPI );

            Assert.AreEqual( NMS_VERSION_ID,            HeaderCommon.VersionID_NMS );
            Assert.AreEqual( API_VERSION_ID,            HeaderCommon.VersionID_API );

            Assert.AreEqual( NMS_VERSION_STRING,        HeaderCommon.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,        HeaderCommon.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestCreateHeaderTkGeometryData() {
            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC,  HeaderTkGeometryData.MagicID );
            Assert.AreEqual( FORMAT_ID,                 HeaderTkGeometryData.FormatID );
            Assert.AreEqual( VERSION_ID,                HeaderTkGeometryData.VersionID );
            Assert.AreEqual( TEMPLATE_GUID,             HeaderTkGeometryData.TemplateGUID );
            Assert.AreEqual( TEMPLATE_NAME,             HeaderTkGeometryData.TemplateName );
            Assert.AreEqual( METAOFFSET,                HeaderTkGeometryData.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION,   HeaderTkGeometryData.FormatNMS );
            Assert.AreEqual( FORMAT_V2,                 HeaderTkGeometryData.FormatAPI );

            Assert.AreEqual( NMS_VERSION_STRING,        HeaderTkGeometryData.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,        HeaderTkGeometryData.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsV2Common() {
            var header = new MBINHeader();
            header.SetDefaultsV2();

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,   header.MagicID );
            Assert.AreEqual( FORMAT_ID,               header.FormatID );
            Assert.AreEqual( VERSION_ID,              header.VersionID );
            Assert.AreEqual( 0ul,                     header.TemplateGUID );
            Assert.AreEqual( "",                      header.TemplateName );
            Assert.AreEqual( 0ul,                     header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION, header.FormatNMS );
            Assert.AreEqual( FORMAT_V2,               header.FormatAPI );

            Assert.AreEqual( NMS_VERSION_STRING,      header.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,      header.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsV2TkGeometry() {
            var header = new MBINHeader();
            header.SetDefaultsV2( typeof( TkGeometryData ) );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC, header.MagicID );
            Assert.AreEqual( FORMAT_ID,                header.FormatID );
            Assert.AreEqual( VERSION_ID,               header.VersionID );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,      header.TemplateGUID );
            Assert.AreEqual( "",                       header.TemplateName );
            Assert.AreEqual( 0ul,                      header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION,  header.FormatNMS );
            Assert.AreEqual( FORMAT_V2,                header.FormatAPI );
                                                       
            Assert.AreEqual( NMS_VERSION_STRING,       header.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,       header.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsCommon() {
            var header = new MBINHeader();
            header.SetDefaults( format: MBINHeader.Format.V2 );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,   header.MagicID );
            Assert.AreEqual( FORMAT_ID,               header.FormatID );
            Assert.AreEqual( VERSION_ID,              header.VersionID );
            Assert.AreEqual( 0ul,                     header.TemplateGUID );
            Assert.AreEqual( "",                      header.TemplateName );
            Assert.AreEqual( 0ul,                     header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION, header.FormatNMS );
            Assert.AreEqual( FORMAT_V2,               header.FormatAPI );

            Assert.AreEqual( NMS_VERSION_STRING,      header.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,      header.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsTkGeometry() {
            var header = new MBINHeader();
            header.SetDefaults( typeof( TkGeometryData ), MBINHeader.Format.V2 );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC, header.MagicID );
            Assert.AreEqual( FORMAT_ID,                header.FormatID );
            Assert.AreEqual( VERSION_ID,               header.VersionID );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,      header.TemplateGUID );
            Assert.AreEqual( "",                       header.TemplateName );
            Assert.AreEqual( 0ul,                      header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION,  header.FormatNMS );
            Assert.AreEqual( FORMAT_V2,                header.FormatAPI );

            Assert.AreEqual( NMS_VERSION_STRING,       header.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,       header.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsImplicitCommon() {
            var header = new MBINHeader();
            header.SetDefaults();

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,   header.MagicID );
            Assert.AreEqual( FORMAT_ID,               header.FormatID );
            Assert.AreEqual( VERSION_ID,              header.VersionID );
            Assert.AreEqual( 0ul,                     header.TemplateGUID );
            Assert.AreEqual( "",                      header.TemplateName );
            Assert.AreEqual( 0ul,                     header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION, header.FormatNMS );
            Assert.AreEqual( FORMAT_V2,               header.FormatAPI );

            Assert.AreEqual( NMS_VERSION_STRING,      header.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,      header.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsImplicitTkGeometry() {
            var header = new MBINHeader();
            header.SetDefaults( typeof( TkGeometryData ) );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC, header.MagicID );
            Assert.AreEqual( FORMAT_ID,                header.FormatID );
            Assert.AreEqual( VERSION_ID,               header.VersionID );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,      header.TemplateGUID );
            Assert.AreEqual( "",                       header.TemplateName );
            Assert.AreEqual( 0ul,                      header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION,  header.FormatNMS );
            Assert.AreEqual( FORMAT_V2,                header.FormatAPI );

            Assert.AreEqual( NMS_VERSION_STRING,       header.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,       header.VersionAPI.ToString() );
        }

    }

}
