using System.Configuration;
using NUnit.Framework;
using tSQLt.Client.Net;

namespace TDD.Examples.TestRunner
{
    [TestFixture]
    public class AddNumberTests
    {
        private readonly tSQLtTestRunner _runner;
        private readonly string _connString;

        public AddNumberTests()
        {
            _connString = ConfigurationManager.ConnectionStrings["tSQLt"].ConnectionString;
            _runner = new tSQLtTestRunner(_connString);
        }

        [Test]
        public void AddNumberReturnsSumOfParameters()
        {
            var result = _runner.Run("AddNumberTests", "test_AddNumberReturnsSumOfParameters");
            Assert.IsTrue(result.Passed(), result.FailureMessages());
        }
    }
}
