using NUnit.Framework;

namespace ReyozaSdk.Tests
{
    public class TestClient : ReyozaClient
    {
        public TestClient(string apiKey) : base(apiKey)
        {
            Tracer = TestContext.Progress.WriteLine;
        }
    }
}
