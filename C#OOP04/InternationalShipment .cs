using C_OOP04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP_2
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string destinationCountry;
        private decimal customFee;
        public string DestinationCountry { get
            {
                return destinationCountry;
            }
            set {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)){

                    destinationCountry = value;
                }

            }
        }
        public decimal CustomsFee
        {
            get
            {
                return customFee;
            }
            set
            {
                if (value >= 0)
                {
                    customFee = value;
                }
            }
        }
    


        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination,  string destinationCountry,  decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;


        }

        public override decimal EstimatedCost
        {

            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + CustomsFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"International Shipment");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
  
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus()
        {
            return $"Shioment {TrackingCode} has been Deliverd";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12M;
        }
    }
}
