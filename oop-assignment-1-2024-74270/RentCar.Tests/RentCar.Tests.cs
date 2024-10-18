using Xunit;  // Importing XUnit framework
using RentCar.Domain;  // Import the namespace where RentalCar class is located

namespace RentCar.Tests
{
    public class RentalCarTests
    {
        // Test for the Borrow method
        [Fact]
        public void TestBorrow()
        {
            // Arrange
            var car = new EconomyRentalCar("Toyota", "Corolla", "HatchBack", "ABC123", 120.0, false);

            // Act
            car.Borrow();

            // Assert
            Assert.True(car.CheckBorrowed(), "The car should be marked as borrowed.");
        }

        // Test for returning a rental car
        [Fact]
        public void TestReturnRentalCar()
        {
            // Arrange
            var car = new EconomyRentalCar("Toyota", "Corolla", "HatchBack", "ABC123", 120.0, true);

            // Act
            car.ReturnRentalCar();

            // Assert
            Assert.False(car.CheckBorrowed(), "The car should be marked as returned.");
        }

        // Test for changing the price
        [Fact]
        public void TestChangePrice()
        {
            // Arrange
            var car = new EconomyRentalCar("Toyota", "Corolla", "HatchBack", "ABC123", 120.0, false);

            // Act
            car.ChangePrice(150.0);

            // Assert
            Assert.Equal(150.0, car.CheckPrice());
        }

        // Test for checking the price
        [Fact]
        public void TestCheckPrice()
        {
            // Arrange
            var car = new EconomyRentalCar("Toyota", "Corolla", "HatchBack", "ABC123", 120.0, false);

            // Act
            var price = car.CheckPrice();

            // Assert
            Assert.Equal(120.0, price);
        }

        // Test for checking if the car is borrowed
        [Fact]
        public void TestCheckBorrowed()
        {
            // Arrange
            var car = new EconomyRentalCar("Toyota", "Corolla", "HatchBack", "ABC123", 120.0, true);

            // Act
            var isBorrowed = car.CheckBorrowed();

            // Assert
            Assert.True(isBorrowed);
        }

        // Visual test for displaying car details
        [Fact]
        public void TestDisplay()
        {
            // Arrange
            var car = new EconomyRentalCar("Toyota", "Corolla", "HatchBack", "ABC123", 120.0, false);

            // Act
            car.Display();

            // Assert
            // No assert is needed; visual validation is expected
        }
    }
}
