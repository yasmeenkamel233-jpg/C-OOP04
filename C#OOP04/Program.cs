using C_OOP_2;
using C_OOP04;
class Program
{
    static void Main(string[] args)
    {
        DeliveryCenter center =
            new DeliveryCenter("Cairo Center");


        StandardShipment standard = new StandardShipment(
            "SH001",
            "Laptop",
            3,
            80,
            new DeliveryAddress("Cairo", "Nasr City", 10)
        );


        ExpressShipment express = new ExpressShipment(
            "SH002",
            "Phone",
            2,
            60,
            new DeliveryAddress("Giza", "Dokki", 15),
            30
        );


        InternationalShipment international = new InternationalShipment(
            "SH003",
            "Clothes",
            8,
            120,
            new DeliveryAddress("Alexandria", "Smouha", 20),
            "Germany",
            100
        );


        center[0] = standard;
        center[1] = express;
        center[2] = international;


        Console.WriteLine("==========================================");
        Console.WriteLine("Delivery Center");
        Console.WriteLine("==========================================");

        standard.PrintShipment();

        Console.WriteLine("------------------------------------------");

        express.PrintShipment();

        Console.WriteLine("------------------------------------------");

        international.PrintShipment();


        Console.WriteLine("==========================================");
        Console.WriteLine("Tracking Status");
        Console.WriteLine("==========================================");

        center.PrintTrackingStatus();


        DeliveryReport report = new DeliveryReport();

        Console.WriteLine("==========================================");
        Console.WriteLine("Insurance");
        Console.WriteLine("==========================================");

        report.PrintInsurance(standard);
        report.PrintInsurance(express);
        report.PrintInsurance(international);


        Console.WriteLine("==========================================");
        Console.WriteLine("Interface Polymorphism - Tracking");
        Console.WriteLine("==========================================");

        ITrackable[] trackableShipments =
        {
        standard,
        express,
        international
    };

        foreach (ITrackable shipment in trackableShipments)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }


        Console.WriteLine("==========================================");
        Console.WriteLine("Interface Polymorphism - Insurance");
        Console.WriteLine("==========================================");

        IInsurable[] insurableShipments =
        {
        standard,
        express,
        international
    };

        foreach (IInsurable shipment in insurableShipments)
        {
            Console.WriteLine($"{shipment.CalculateInsurance()} EGP");
        }


        Console.WriteLine("==========================================");
        Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
    }
}