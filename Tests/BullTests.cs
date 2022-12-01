using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class BullTests
    {
        [Fact]
        public void Set_BullHasBullRing()
        {
            Bull bull1 = new Bull(235, DateTime.Now, BovineBreed.HOLSTEIN);
            bull1.SetHasBullRing(true);

            // Arrange
            bool expected1 = true;

            // Act
            bool actual1 = bull1.GetHasBullRing();

            // Assert
            Assert.Equal(expected1, actual1);
        }

        [Fact]
        public void Set_BullIsCastrated()
        {
            Bull bull2 = new Bull(235, DateTime.Now, BovineBreed.HOLSTEIN);
            bull2.Castrate();

            // Arrange
            // change to true if castrated, issue with the setter
            bool expected2 = true;
            
            // Act
            var actual2 = bull2.IsCastrated;
            
            // Assert
            Assert.Equal(expected2, actual2);
        }
    }
}