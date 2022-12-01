using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class RamTests
    {
        [Fact]
        public void Set_WoolYield()
        {
            Ram ram1 = new Ram(678, DateTime.Now, OvineBreed.HAMPSHIRE, 23.2);
            ram1.SetWoolYield(12.5);
            
            // Arrange
            var expected1 = 12.5;

            // Act
            var actual1 = ram1.GetWoolYield();

            // Assert
            Assert.Equal(expected1, actual1);
        }
        
        [Fact]
        public void Set_Castrated()
        {
            Ram ram2 = new Ram(265, DateTime.Now, OvineBreed.HAMPSHIRE, 13.2);
            ram2.Castrate();
            
            // Arrange
            // change to true if castrated, issue with the setter
            bool expected2 = true;

            // Act
            bool actual2 = ram2.IsCastrated;

            // Assert
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void Set_HornLength()
        {
            Ram ram3 = new Ram(12, DateTime.Now, OvineBreed.HAMPSHIRE, 31.2);
            ram3.SetHornLength(12.5);

            // Arrange
            double expected3 = 12.5;

            // Act
            double actual3 = ram3.GetHornLength();

            // Assert
            Assert.Equal(expected3, actual3);
        }
    }
}