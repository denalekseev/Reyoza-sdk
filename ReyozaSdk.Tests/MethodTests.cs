using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ReyozaSdk.DataContracts;
using NUnit.Framework;

namespace ReyozaSdk.Tests
{
    [TestFixture]
    public class MethodTests
    {
        private TestClient Client { get; } = new TestClient("7f3a9b2e5c8d1f4a6b9e2c5d8f1a4b7e0c3d6f9a2b5e8c1d4f7a0b3e6c9d2f5a8");

        [Test, Ordered]
        public void GetOrders()
        {
            var orders = Client.GetOrders(new DataContracts.Documents.GetOrdersRequest(), null, null);
            Assert.That(orders, Is.Not.Null);
            ////Assert.That(regions, Is.Not.Null);
            ////Assert.That(regions.Items.Count, Is.GreaterThan(0));
        }
    }
}