using RentCar.Domain;

namespace RentCar.Console
{
    public class RentalCarDriver
    {
        public static void Main(string[] args)
        {
            // Creating 4 rental car objects using EconomyRentalCar
            var car1 = new EconomyRentalCar("Toyota", "Corolla", "Saloon", "ABC123", 120.0, false);
            var car2 = new EconomyRentalCar("BMW", "X5", "CrossOver", "XYZ456", 250.0, true);
            var car3 = new EconomyRentalCar("Audi", "A4", "Convertible", "DEF789", 150.0, false);
            var car4 = new EconomyRentalCar("Ford", "Fiesta", "HatchBack", "GHI321", 80.0, false);

            // Display details of all cars using the display method
            System.Console.WriteLine("Initial Car Details:");
            car1.Display();
            car2.Display();
            car3.Display();
            car4.Display();

            // Test borrowing and returning cars
            System.Console.WriteLine("Testing Borrow and Return Functions:");
            car1.Borrow();  // Car1 should be borrowed now
            System.Console.WriteLine($"Car 1 borrowed status: {car1.CheckBorrowed()}");  // Expected: true

            car1.ReturnRentalCar();  // Returning car1
            System.Console.WriteLine($"Car 1 borrowed status after return: {car1.CheckBorrowed()}");  // Expected: false

            // Test price change functionality
            System.Console.WriteLine("Testing Price Change Function:");
            System.Console.WriteLine($"Original price of Car 2: {car2.CheckPrice()}");
            car2.ChangePrice(300.0);  // Changing price of car2
            System.Console.WriteLine($"New price of Car 2: {car2.CheckPrice()}");  // Expected: 300.0

            // Test validation of borrowed status for car3 (not borrowed)
            System.Console.WriteLine("Testing Borrow Status:");
            car3.Borrow();  // Borrow car3
            System.Console.WriteLine($"Car 3 borrowed status: {car3.CheckBorrowed()}");  // Expected: true

            // Display final details of all cars after changes
            System.Console.WriteLine("Final Car Details After Updates:");
            car1.Display();
            car2.Display();
            car3.Display();
            car4.Display();
        }
    }
}
