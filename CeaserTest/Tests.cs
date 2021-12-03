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
        [Test]
        public void cipher_test()
        {
            var ceaser = new CeaserClass();
            char encrypt = ceaser.cipher('q',3);
            Assert.AreEqual(encrypt,'t');

        }
    }
}