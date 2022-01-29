using NLog;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace What_APITest
{
    public class API_BaseTest
    {
        public Logger log = LogManager.GetCurrentClassLogger();

        [SetUp]
        public void LogBeforeEachTest()
        {
            var context = TestContext.CurrentContext;
            var testName = context.Test.FullName;
            log.Info($"{testName} start ...");
        }

        [TearDown]
        public void LogAfterEachTest()
        {
            var context = TestContext.CurrentContext;
            var testName = context.Test.FullName;

            if (context.Result.Outcome.Status != TestStatus.Passed)
            {
                foreach (var assertion in context.Result.Assertions)
                {
                    log.Error($"{testName} {assertion.Status}:{Environment.NewLine}{assertion.Message}");
                }
            }

            log.Info($"{testName} {context.Result.Outcome.Status}" +
                $"{Environment.NewLine}----------------------------------------------------------");
        }
    }
}