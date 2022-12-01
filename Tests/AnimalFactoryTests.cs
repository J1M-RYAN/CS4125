using CS4125.Data.AnimalData;
using Xunit;


namespace CS4125.Tests
{
    public class AnimalFactoryTests
    {
        [Fact]
        // Test to see if the factory method returns a new instance of the correct type
        public void CreateAnimal_WithValidAnimalType_ReturnsAnimal()
        {
            var expected1 = new Bull(235, DateTime.Now, BovineBreed.Holstein);

            var actual1 = AnimalFactory.CreateAnimal("Bull","Holstein");

            Assert.Equal(expected1.GetType(), actual1.GetType());
        }
    }
}