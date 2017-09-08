namespace libMBIN.Models.Structs
{
    public class GcVehicleType : NMSTemplate
    {
        public int VehicleType;
        public string[] VehicleTypeValues()
        {
            return new[] { "Buggy", "Bike", "Truck"};
        }
    }
}
