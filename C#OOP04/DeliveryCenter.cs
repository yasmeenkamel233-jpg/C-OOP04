using C_OOP_2;
using C_OOP04;

internal class DeliveryCenter
{
    public string CenterName
    {
        get; set;
    }

    private Shipment[] shipments = new Shipment[20];

    public DeliveryCenter(string centerName)
    {
        CenterName = centerName;
    }

    public Shipment this[int index]
    {
        get
        {
            if (index >= 0 && index < shipments.Length)
            {
                return shipments[index];
            }

            return default;
        }
        set
        {
            if (index >= 0 && index < shipments.Length)
            {
                shipments[index] = value;
            }
        }
    }

    public Shipment this[string trackingCode]
    {
        get
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    return shipments[i];
                }
            }

            return default;
        }
    }

    public bool AddShipment(Shipment shipment)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] == null)
            {
                shipments[i] = shipment;
                return true;
            }
        }

        return false;
    }

    public void RemoveShipment(string trackingCode)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] != null &&
                shipments[i].TrackingCode == trackingCode)
            {
                shipments[i] = null;
                return;
            }
        }
    }
    public void PrintTrackingStatus()
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] != null)
            {
                ITrackable shipment = (ITrackable)shipments[i];
                Console.WriteLine(shipment.GetTrackingStatus());
            }

        }
    }
    public void PrintAllShipments()
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] != null)
            {
                shipments[i].PrintShipment();
            }
        }
    }
}