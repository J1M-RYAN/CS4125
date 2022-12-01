using CS4125.Data.AnimalData;
using Xunit;

namespace CS4125.Tests
{
    public class EweTests
    {
        [Fact]
        // Test on the wool value of a Ewe
        public void Set_WoolYield()
        {
            Ewe ewe1 = new Ewe(68, DateTime.Now, OvineBreed.Hampshire, 4.2);
            ewe1.SetWoolYield(10.4);
            
            var expected1 = 10.4;
            
            var actual1 = ewe1.GetWoolYield();

            Assert.Equal(expected1, actual1);
        }

        [Fact]
        // Test on the Pregnancy methods for a Ewe
        public void Set_IsPregnant()
        {
            Ewe ewe2 = new Ewe(15, DateTime.Now, OvineBreed.Hampshire, 18.5);
            ewe2.ArtificialInsemination();
            
            bool expected2 = true;
            
            bool actual2 = ewe2.TestPregnancy();
            
            Assert.Equal(expected2, actual2);
        }
    }
}