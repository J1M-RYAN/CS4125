using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class CowTests
    {
        [Fact]
        // Test that the Milk Yield is correct
        public void Set_MilkProduction()
        {
            Cow cow1 = new Cow(43, DateTime.Now, BovineBreed.Brown, 23.5);
            cow1.SetMilkProduction(12.5);
            
            double expected1 = 12.5;
            
            double actual1 = cow1.GetMilkProduction();
            
            Assert.Equal(expected1, actual1);
        }
        
        [Fact]
        // Test on the Pregnancy methods for a Cow
        public void Get_IsPregnant()
        {
            Cow cow2 = new Cow(63, DateTime.Now, BovineBreed.Brown, 23.5);
            cow2.ArtificialInsemination();
            
            bool expected2 = true;
            
            bool actual2 = cow2.TestPregnancy();
            
            Assert.Equal(expected2, actual2);
        }
    }
}