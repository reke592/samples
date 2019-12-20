using System;

namespace patter.samples.strategy {
    public class SeaCargoShipment : IShipmentStrategy
    {
        public string Destination { get; private set; }
        public string VesselNumber { get; private set; }

        public SeaCargoShipment(string dest, string vessel_num) {
            this.Destination = dest;
            this.VesselNumber = vessel_num;
        }

        public void Ship()
        {
            Console.WriteLine($"Sea shipment Vessel#: ${ VesselNumber }");
            Console.WriteLine($"Destination: ${ Destination }");
        }
    }
}