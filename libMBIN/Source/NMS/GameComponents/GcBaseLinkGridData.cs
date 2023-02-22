using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8F66D1290EEC0E7, NameHash = 0x3FBB55C99E667F9E)]
    public class GcBaseLinkGridData : NMSTemplate
    {
        /* 0x00 */ public GcBaseLinkGridConnectionData Connection;
        /* 0x38 */ public int Rate;
        /* 0x3C */ public int Storage;
        // size: 0x3
        public enum DependsOnEnvironmentEnum {
            None,
            DayNight,
            Storms,
        }
        /* 0x40 */ public DependsOnEnvironmentEnum DependsOnEnvironment;
        // size: 0x4
        public enum DependsOnHotspotsEnum {
            None,
            Power,
            Mineral,
            Gas,
        }
        /* 0x44 */ public DependsOnHotspotsEnum DependsOnHotspots;
        /* 0x48 */ public List<GcBaseLinkGridConnectionDependency> DependentConnections;
    }
}
