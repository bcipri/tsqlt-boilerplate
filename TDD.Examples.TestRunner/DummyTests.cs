using System.Configuration;
using NUnit.Framework;
using tSQLt.Client.Net;

namespace TDD.Examples.TestRunner
{
    [TestFixture]
    public class DummyTests
    {
        private readonly tSQLtTestRunner _runner;
        private readonly string _connString;

        public DummyTests()
        {
            _connString = ConfigurationManager.ConnectionStrings["tSQLt"].ConnectionString;
            _runner = new tSQLtTestRunner(_connString);
        }

        [Test]
        public void AddNumberReturnsSumOfParameters()
        {
            var result = _runner.Run("DummyTests", "testDummyFunction");
            Assert.IsTrue(result.Passed(), result.FailureMessages());
        }
    }
}
