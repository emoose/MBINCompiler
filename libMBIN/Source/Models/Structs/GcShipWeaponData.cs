namespace libMBIN.Models.Structs
{
    public class GcShipWeaponData : NMSTemplate
    {
        public int ShipWeapon;
        public string[] ShipWeaponValues()
        {
            return new[] { "Laser", "Projectile", "Shotgun", "Minigun", "Plasma", "Missile", "Rocket"};
        }
    }
}
