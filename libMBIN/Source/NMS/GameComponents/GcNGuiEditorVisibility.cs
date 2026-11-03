namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC887F73BBF77B1E5, NameHash = 0x6A6241DE)]
    public class GcNGuiEditorVisibility : NMSTemplate
    {
        // size: 0x3
        public enum EditorVisibilityEnum : uint {
            UseData,
            Visible,
            Hidden,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EditorVisibilityEnum EditorVisibility;
    }
}
