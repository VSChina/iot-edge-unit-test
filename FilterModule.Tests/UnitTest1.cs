using Microsoft.Azure.Devices.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilterModule;

namespace FilterModule.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MessageStringTest()
        {
            var message = new Message(new byte[] { 97, 98, 99 });
            var messageString = Program.getMessageString(message);
            Assert.AreEqual("abc", messageString);
        }
    }
}
