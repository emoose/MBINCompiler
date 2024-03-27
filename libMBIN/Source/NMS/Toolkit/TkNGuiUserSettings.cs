namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEEB4228A1493C3FB, NameHash = 0x40643395614391FA)]
    public class TkNGuiUserSettings : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 LastLoadedModel;
        /* 0x100 */ public NMSString0x100 LastActiveLayout;
        [NMS(Size = 0xA)]
        /* 0x200 */ public NMSString0x100[] FileBrowserRecents;
    }
}
