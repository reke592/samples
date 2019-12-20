using System;

namespace patter.samples.strategy {
    public class AirCargoShipment : IShipmentStrategy
    {
        public string FlightNumber { get; private set; }
        public string Destination { get; private set; }

        public AirCargoShipment(string dest, string flight_num) {
            this.FlightNumber = flight_num;
            this.Destination = dest;
        }

        public void Ship()
        {
            Console.WriteLine($"Air shipment Flight#: ${ FlightNumber }");
            Console.WriteLine($"Destination: ${ Destination }");
        }
    }
}