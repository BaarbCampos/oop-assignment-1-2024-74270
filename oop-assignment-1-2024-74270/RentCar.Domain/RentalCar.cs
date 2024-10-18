namespace RentCar.Domain
{
    // Abstract class RentalCar
    public abstract class RentalCar
    {
        // Public attributes
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public string RegistrationNumber { get; set; }
        public double Price { get; set; }
        public bool Borrowed { get; set; }

        // Constructor
        public RentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price, bool borrowed)
        {
            Manufacturer = manufacturer;
            Model = model;
            BodyType = bodyType;
            RegistrationNumber = registrationNumber;
            Price = price;
            Borrowed = borrowed;
        }

        // Abstract method to implement validation in the derived classes
        public abstract void Validate();

        // Method to borrow the car
        public void Borrow()
        {
            if (!Borrowed)
            {
                Borrowed = true;
                Console.WriteLine($"{Model} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Model} is already on loan.");
            }
        }

        // Method to return the car
        public void ReturnRentalCar()
        {
            Borrowed = false;
            Console.WriteLine($"{Model} has been returned.");
        }

        // Method to change the price
        public void ChangePrice(double newPrice)
        {
            Price = newPrice;
            Console.WriteLine($"The price for {Model} has been updated to {Price}.");
        }

        // Method to check the price
        public double CheckPrice()
        {
            return Price;
        }

        // Method to check if the car is borrowed
        public bool CheckBorrowed()
        {
            return Borrowed;
        }

        // Display method to print the car details in a nice format
        public virtual void Display()
        {
            Console.WriteLine("**************************");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Body Type: {BodyType}");
            Console.WriteLine($"Registration Number: {RegistrationNumber}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Borrowed: {Borrowed}");
            Console.WriteLine("**************************\n");
        }
    }

    // Concrete class that inherits from RentalCar
    public class EconomyRentalCar : RentalCar
    {
        public EconomyRentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price, bool borrowed)
            : base(manufacturer, model, bodyType, registrationNumber, price, borrowed)
        {
        }

        // Implement the abstract Validate method
        public override void Validate()
        {
            // Custom validation logic here (if any)
        }
    }
}
