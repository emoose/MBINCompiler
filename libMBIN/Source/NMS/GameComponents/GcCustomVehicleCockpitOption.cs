namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x376F6FC940AF225A, NameHash = 0x2BC11981)]
    public class GcCustomVehicleCockpitOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 AssociatedDescriptorGroup;
        [NMS(Index = 1)]
        /* 0x10 */ public GcFilename CockpitFile;
    }
}
