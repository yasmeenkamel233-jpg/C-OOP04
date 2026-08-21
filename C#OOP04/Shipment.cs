using System;

namespace C_OOP_2
{
   
    internal abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }

            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; }

        public abstract decimal EstimatedCost{ get; }
        

        // Constructor 1
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }

        // Constructor 2
        public Shipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public abstract void PrintShipment();
        //{
        //    Console.WriteLine($"Tracking Code: {TrackingCode}");
        //    Console.WriteLine($"Description: {Description}");
        //    Console.WriteLine($"Weight: {Weight} KG");
        //    Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
        //    Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
