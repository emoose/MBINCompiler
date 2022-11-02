namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xABF33D845CD18EF5, NameHash = 0x3239FD75543805A7)]
    public class GcRemoteWeapons : NMSTemplate
    {
        // size: 0x16
        public enum RemoteWeaponTypeEnum {
            Laser,
            VehicleLaser,
            AIMechLaser,
            ShipLaser,
            ShipLaser2,
            RailLaser,
            NumLasers,
            BoltCaster,
            Shotgun,
            Cannon,
            Burst,
            MineGrenade,
            BounceGrenade,
            StunGrenade,
            VehicleCanon,
            AIMechCanon,
            ShipPhoton,
            ShipShotgun,
            ShipMinigun,
            ShipPlasma,
            ShipRocket,
            None
        }
        /* 0x0 */ public RemoteWeaponTypeEnum RemoteWeaponType;
    }
}
