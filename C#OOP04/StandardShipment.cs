using C_OOP04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP_2
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05M;
        }

        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5);

        public string GetTrackingStatus()
        {
            return $"Shipment: {TrackingCode} is Ready" ;
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Standared Shipment");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
     
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
