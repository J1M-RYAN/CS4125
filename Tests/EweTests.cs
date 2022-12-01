using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class EweTests
    {
        [Fact]
        public void Set_WoolYield()
        {
            Ewe ewe1 = new Ewe(68, DateTime.Now, OvineBreed.HAMPSHIRE, 4.2);
            ewe1.SetWoolYield(10.4);

            // Arrange
            var expected1 = 10.4;

            // Act
            var actual1 = ewe1.GetWoolYield();

            // Assert
            Assert.Equal(expected1, actual1);
        }

        [Fact]
        public void Set_IsPregnant()
        {
            Ewe ewe2 = new Ewe(15, DateTime.Now, OvineBreed.HAMPSHIRE, 18.5);
            ewe2.ArtificialInsemination();
            
            // Arrange
            bool expected2 = true;
            
            // Act
            bool actual2 = ewe2.TestPregnancy();
            
            // Assert
            Assert.Equal(expected2, actual2);
        }
    }
}