namespace libMBIN.Models.Structs
{
    public class GcMissionConditionLocation : NMSTemplate
    {
        public int MissionPlayerLocation;
        public string[] MissionPlayerLocationValues()
        {
            return new[] { "OnPlanet", "OnPlanetInVehicle", "InShipLanded" , "InShipInPlanetOrbit" , "InShipInSpace",
             "InSpaceStation", "InFreighter"};
        }
    }
}
