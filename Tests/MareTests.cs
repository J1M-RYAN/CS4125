using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class MareTests
    {
        [Fact]
        public void Get_IsPregnant()
        {
            Mare mare1 = new Mare(245, DateTime.Now, EquineBreed.ARABIAN, true);
            mare1.ArtificialInsemination();
            
            // Arrange
            bool expected2 = true;
            
            // Act
            bool actual2 = mare1.TestPregnancy();
            
            // Assert
            Assert.Equal(expected2, actual2);
        }
        
        [Fact]
        public void Set_IsSurrigate()
        {
            Mare mare2 = new Mare(245, DateTime.Now, EquineBreed.ARABIAN, true);
            mare2.SetIsSurrogate(false);
            
            // Arrange
            bool expected2 = false;

            // Act
            bool actual2 = mare2.GetIsSurrogate();
            
            // Assert
            Assert.Equal(expected2, actual2);
        }
    }
}