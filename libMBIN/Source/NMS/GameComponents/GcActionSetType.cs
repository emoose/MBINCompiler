namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B1AA41A13BF3652, NameHash = 0x99FB64404DAF2DE7)]
    public class GcActionSetType : NMSTemplate
    {
        // size: 0x10
        public enum ActionSetTypeEnum : uint {
            None,
            FRONTEND,
            OnFootControls,
            OnFootQuickMenu,
            ShipControls,
            ShipQuickMenu,
            VehicleMode,
            GalacticMap,
            PhotoModeMenu,
            PhotoModeMvCam,
            AmbientMode,
            DebugMode,
            BuildMenuAnalogueRotate,
            TextChat,
            BuildMenuSelectionMode,
            BuildMenuPlacementMode,
        }
        /* 0x0 */ public ActionSetTypeEnum ActionSetType;
    }
}
