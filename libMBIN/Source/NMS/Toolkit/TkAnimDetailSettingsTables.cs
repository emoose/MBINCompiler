using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x85F77700B1E65850, NameHash = 0x8E27B20D)]
    public class TkAnimDetailSettingsTables : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimDetailSettingsTable> Tables;
    }
}
