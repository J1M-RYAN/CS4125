using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class CowTests
    {
        [Fact]
        public void Set_MilkProduction()
        {
            Cow cow1 = new Cow(245, DateTime.Now, BovineBreed.BROWN, 23.5);
            cow1.SetMilkProduction(12.5);
            
            // Arrange
            double expected1 = 12.5;
            
            // Act
            double actual1 = cow1.GetMilkProduction();
            
            // Assert
            Assert.Equal(expected1, actual1);
        }
        
        [Fact]
        public void Get_IsPregnant()
        {
            Cow cow2 = new Cow(245, DateTime.Now, BovineBreed.BROWN, 23.5);
            cow2.ArtificialInsemination();
            
            // Arrange
            bool expected2 = true;
            
            // Act
            bool actual2 = cow2.TestPregnancy();
            
            // Assert
            Assert.Equal(expected2, actual2);
        }
    }
}