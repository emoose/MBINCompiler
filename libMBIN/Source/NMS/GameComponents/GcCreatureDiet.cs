namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9718AB53D13CDD7F, NameHash = 0xEF306B43D1C79D7F)]
    public class GcCreatureDiet : NMSTemplate
    {
        // size: 0x4
        public enum DietEnum {
            Carnivore,
            Omnivore,
            Herbivore,
            Robot
        }
        /* 0x0 */ public DietEnum Diet;
    }
}
