using Chapter06;

namespace Chapter06Tests
{
    [TestClass]
    public class UtilsTests
    {
        // Test that GetInitials() returns initials as expected
        [TestMethod]
        public void GetInitialsHasCorrectOutput()
        {
            string message = "GetInitials() returns only initials when given a full name";
            string expected = "GH";
            string actual = Utils.GetInitials("Grace Hopper");
            Assert.AreEqual(expected, actual, message);
        }
    }
}
