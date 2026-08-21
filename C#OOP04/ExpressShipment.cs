using C_OOP04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP_2
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;
        public decimal ExtraFee
        {
            get { return extraFee; }

            set
            {

                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

       
    
        

        
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override decimal EstimatedCost
        {
            get
            {

                return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;

            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Express Shipment");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"ExtraFee: {ExtraFee}");
       
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus()
        {
            return $"Shioment {TrackingCode} is Out for Delivery";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08M;
        }
    }
}
