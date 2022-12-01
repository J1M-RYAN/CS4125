using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class BullTests
    {
        [Fact]
        // Testing the bull ring method unique to Bull
        public void Set_BullHasBullRing()
        {
            Bull bull1 = new Bull(235, DateTime.Now, BovineBreed.Holstein);
            bull1.SetHasBullRing(true);
            
            bool expected1 = true;
            
            bool actual1 = bull1.GetHasBullRing();
            
            Assert.Equal(expected1, actual1);
        }

        [Fact]
        // Testing the Castrate method on a Bull
        public void Set_BullIsCastrated()
        {
            Bull bull2 = new Bull(235, DateTime.Now, BovineBreed.Holstein);
            bull2.SetIsCastrated(true);
            
            bool expected2 = true;
            
            var actual2 = bull2.GetIsCastrated();
            
            Assert.Equal(expected2, actual2);
        }
    }
}