namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1AAB61A67E09934F, NameHash = 0x40643395614391FA)]
    public class TkNGuiUserSettings : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 LastLoadedModel;
        /* 0x100 */ public NMSString0x100 LastActiveLayout;
        [NMS(Size = 0xA)]
        /* 0x200 */ public NMSString0x100[] FileBrowserRecents;
    }
}
