using LeetCodeCountPrimes;
using NUnit.Framework;

namespace LeetCodeCountPrimesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //1 to 10 = 4
        [Test]
        public void Test10()
        {
            var prime = new Solution();
            int numPrime = prime.CountPrimes(10);

            Assert.AreEqual(4, numPrime);
        }

        //1 to 100 = 25
        [Test]
        public void Test100()
        {
            var prime = new Solution();
            int numPrime = prime.CountPrimes(100);

            Assert.AreEqual(25, numPrime);
        }

        //1 to 1,000 = 168
        [Test]
        public void Test1000()
        {
            var prime = new Solution();
            int numPrime = prime.CountPrimes(1000);

            Assert.AreEqual(168, numPrime);
        }

        //1 to 10,000 = 1,229
        [Test]
        public void Test10000()
        {
            var prime = new Solution();
            int numPrime = prime.CountPrimes(10000);

            Assert.AreEqual(1229, numPrime);
        }

        //1 to 1,000,000 =9,592
        [Test]
        public void Test100000()
        {
            var prime = new Solution();
            int numPrime = prime.CountPrimes(1000000);

            Assert.AreEqual(9592, numPrime);
        }

       // 1 to 10,000,000 = 78,492
        [Test]
        public void Test10000000()
        {
            var prime = new Solution();
            int numPrime = prime.CountPrimes(10000000);

            Assert.AreEqual(78492, numPrime);
        }


        // 1 to 1,000,000,000 = 6,64,579
        [Test]
        public void Test1000000000()
        {
            var prime = new Solution();
            int numPrime = prime.CountPrimes(100000);

            Assert.AreEqual(6640579, numPrime);
        }



    }
}