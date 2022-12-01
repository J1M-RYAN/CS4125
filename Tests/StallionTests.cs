using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class StallionTests
    {
        [Fact]
        // Testing the Castrate methods on a Stallion
        public void Set_StallionIsCastrated()
        {
            Stallion stallion1 = new Stallion(235, DateTime.Now, EquineBreed.Arabian);
            stallion1.SetIsCastrated(true);

            bool expected2 = true;

            var actual2 = stallion1.GetIsCastrated();

            Assert.Equal(expected2, actual2);
        }

        [Fact]
        // Testing the Stud Price methods on a Stallion
        public void Set_StudPrice()
        {
            Stallion stallion2 = new Stallion(35, DateTime.Now, EquineBreed.Arabian);
            stallion2.SetStudPrice(3500);
            
            var expected2 = 3500;
            
            var actual2 = stallion2.GetStudPrice();
            
            Assert.Equal(expected2, actual2);
        }
    }
}
