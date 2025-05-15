using Asterisk.MyTek.HackerRank;

namespace AsteriskTest.Hackerrank
{
    [TestClass]
    public class EcommerceTests
    {
        [TestMethod]
        public void FindLowestPrice_Testcase1()
        {
            var products = new List<List<string>>
            {
                (["100", "dcoupon1"]),
                (["50", "dcoupon1"]),
                (["30", "dcoupon1"]),
                (["100", "dcoupon2"]),
                (["50", "dcoupon2"]),
                (["30", "dcoupon2"])
            };

            var discounts = new List<List<string>>
            {
                (["dcoupon1", "0", "60"]),
                (["dcoupon1", "1", "30"]),
                (["dcoupon1", "1", "20"]),
                (["dcoupon2", "2", "20"]),
                (["dcoupon2", "1", "85"]),
                (["dcoupon2", "0", "15"])
            };

            int result = Ecommerce.FindLowestPrice(products, discounts);
            Assert.AreEqual(142, result);
        }

        [TestMethod]
        public void FindLowestPrice_Testcase2()
        {
            var products = new List<List<string>>
            {
                (["10", "d0", "d1"]),
                (["15", "EMPTY", "EMPTY"]),
                (["20", "d1", "EMPTY"])
            };

            var discounts = new List<List<string>>
            {
                (["d0", "1", "27"]),
                (["d1", "2", "5"])
            };

            int result = Ecommerce.FindLowestPrice(products, discounts);
            Assert.AreEqual(35, result);
        }

        [TestMethod]
        public void FindLowestPrice_Testcase3()
        {
            var products = new List<List<string>>
            {
                (["10", "sale", "january-sale"]),
                (["200", "sale", "EMPTY"])
            };

            var discounts = new List<List<string>>
            {
                (["sale", "0", "10"]),
                (["january-sale", "1", "10"])
            };

            int result = Ecommerce.FindLowestPrice(products, discounts);
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void FindLowestPrice_Testcase4()
        {
            var products = new List<List<string>>
            {
                (["100", "A"]),
                (["200", "B"]),
                (["150", "C"]),
                (["250", "D"])
            };

            var discounts = new List<List<string>>
            {
                (["A", "0", "80"]),
                (["B", "1", "20"]),
                (["C", "0", "120"]),
                (["D", "1", "15"])
            };

            int result = Ecommerce.FindLowestPrice(products, discounts);
            Assert.AreEqual(572, result);
        }
    }
}
