using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class RamTests
    {
        [Fact]
        // Test on the wool value of a Ram
        public void Set_WoolYield()
        {
            Ram ram1 = new Ram(678, DateTime.Now, OvineBreed.Hampshire, 23.2);
            ram1.SetWoolYield(12.5);
            
            var expected1 = 12.5;

            var actual1 = ram1.GetWoolYield();

            Assert.Equal(expected1, actual1);
        }
        
        [Fact]
        // Testing the Castrate methods on a Ram
        public void Set_Castrated()
        {
            Ram ram2 = new Ram(265, DateTime.Now, OvineBreed.Hampshire, 13.2);
            ram2.SetIsCastrated(true);
            
            bool expected2 = true;

            bool actual2 = ram2.GetIsCastrated();

            Assert.Equal(expected2, actual2);
        }

        [Fact]
        // Testing the Horn length methods on a Ram
        public void Set_HornLength()
        {
            Ram ram3 = new Ram(12, DateTime.Now, OvineBreed.Hampshire, 31.2);
            ram3.SetHornLength(12.5);

            double expected3 = 12.5;

            double actual3 = ram3.GetHornLength();

            Assert.Equal(expected3, actual3);
        }
    }
}