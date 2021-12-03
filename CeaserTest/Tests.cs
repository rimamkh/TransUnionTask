using NUnit.Framework;

using Ceaser_cipher;

namespace CeaserTest
{
    public class Tests
    {
       

        [Test]
        public void encrypt_test()
        {
            var ceaser = new CeaserClass() ;
            string encrypt = ceaser.Encipher("quick", 3);
            Assert.AreEqual(encrypt, "txlfn");

        }
    }
}