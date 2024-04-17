namespace CAExceptions
{
    public class DeliveryService
    {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Delivered(delivery);
            }
            catch (InvalidAddressException ex)
            {
                System.Console.WriteLine($"The parcel cannot be reached to the desired location and :{ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }
            catch (AccidentException ex)
            {
                //inform the user 
                //Log the exception
                // Ducking (rethrow) the exception => throw;

                System.Console.WriteLine($"There was an Accident At {ex.Location} :{ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Cannot Deliver due to: {ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }
        }
        private void Process(Delivery delivery)
        {
            FakeIt("Processing");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Unable to process the item");
            }
            delivery.DeliveryStatus = DeliveryStatus.PROCESSED;
        }
        private void Ship(Delivery delivery)
        {
            FakeIt("Shipping");
            if (random.Next(1, 5) == 2)
            {
                throw new InvalidOperationException("Parcel damaged during loading process");
            }
            delivery.DeliveryStatus = DeliveryStatus.SHIPPED;
        }
        private void Transit(Delivery delivery)
        {
            FakeIt("On Its way");
            if (random.Next(1, 10) == 9)
            {
                throw new AccidentException("EL-Mataria", "Accident Happened");
            }
            delivery.DeliveryStatus = DeliveryStatus.INTRANSIT;
        }
        private void Delivered(Delivery delivery)
        {
            FakeIt("Delivering");
            if (random.Next(1, 10) == 5)
            {
                throw new InvalidAddressException("The Address Cannot be reached");
            }
            delivery.DeliveryStatus = DeliveryStatus.DELIVERED;
        }
        private void FakeIt(string title)
        {
            System.Console.Write(title);
            System.Threading.Thread.Sleep(300);
            System.Console.Write('.');
            System.Threading.Thread.Sleep(300);
            System.Console.Write('.');
            System.Threading.Thread.Sleep(300);
            System.Console.Write('.');
            System.Threading.Thread.Sleep(300);
            System.Console.Write('.');
            System.Threading.Thread.Sleep(300);
            System.Console.Write('.');
            System.Threading.Thread.Sleep(300);
            System.Console.Write('.');
            System.Threading.Thread.Sleep(300);
            System.Console.Write(".\n");
        }
    }
}