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
            // ARRANGE
            string expected = "GH";
            // ACT
            string actual = Utils.GetInitials("Grace Hopper");
            // ASSERT
            string message = "GetInitials() returns only initials when given a full name";
            Assert.AreEqual(expected, actual, message);
        }
    }
}
