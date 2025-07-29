using System;
using System.Diagnostics;
using System.Linq;
using Tikshuv.FrontEnd;
using Xunit;

namespace Tikshuv.SignatureTests
{
    public class LocalAIHelperPerformanceTests
    {
        [Fact]
        public void Performance_LocalModel_ShouldMeetSLA()
        {
            // Arrange: create the AI helper and set test input
            var helper = new LocalAIHelper();
            string prompt = "מה מצב הציוד?";
            var times = new long[3];

            // Act: measure execution time 3 times
            for (int i = 0; i < times.Length; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                // Call the private method using reflection
                string result = helper
                    .GetType()
                    .GetMethod("GetPredictedFormName", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .Invoke(helper, new object[] { prompt }) as string;

                sw.Stop();
                times[i] = sw.ElapsedMilliseconds;
            }

            double avg = times.Average();

            // Assert: ensure average response time is within SLA (≤ 500 ms)
            Assert.True(avg <= 500, $"Local model response too slow: {avg:F1} ms");
        }
    }
}
