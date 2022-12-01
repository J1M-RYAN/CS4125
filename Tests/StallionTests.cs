using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class StallionTests
    {
        [Fact]
        public void Set_StallionIsCastrated()
        {
            Stallion stallion1 = new Stallion(235, DateTime.Now, EquineBreed.ARABIAN);
            stallion1.SetIsCastrated(true);

            // Arrange
            // change to true if castrated, issue with the setter
            bool expected2 = true;

            // Act
            var actual2 = stallion1.GetIsCastrated();

            // Assert
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void Set_StudPrice()
        {
            Stallion stallion2 = new Stallion(35, DateTime.Now, EquineBreed.ARABIAN);
            stallion2.SetStudPrice(3500);
            
            // Arrange
            var expected2 = 3500;
            
            // Act
            var actual2 = stallion2.GetStudPrice();
            
            // Assert
            Assert.Equal(expected2, actual2);
        }
    }
}
