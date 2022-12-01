using CS4125.Data.AnimalData;
using Xunit;


namespace CS4125.Tests
{
    public class AnimalFactoryTests
    {
        [Fact]
        public void CreateAnimal_WithValidAnimalType_ReturnsAnimal()
        {
            // Arrange
            var expected1 = new Bull(235, DateTime.Now, BovineBreed.HOLSTEIN);

            // Act
            var actual1 = AnimalFactory.CreateAnimal("Bull","HOLSTEIN");

            // Assert
            Assert.Equal(expected1.GetType(), actual1.GetType());
        }
    }
}