using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Russian_Roullete_assiment
{
    class tests
    {
        
        [TestCase]
        public void score_test()
        {
            shooter test_pos = new shooter();
            Assert.AreEqual(1, test_pos.spined(6));
        }


        [TestCase]
        public void score_test_neg()
        {
            shooter  test_neg = new shooter();
            Assert.AreNotEqual(2, test_neg.spined(5));

        }
    }
}
