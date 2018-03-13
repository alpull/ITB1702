﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Infra;
using Open.Infra.Country;

namespace Open.Tests.Infra.Country {
    [TestClass]
    public class CountryDbTableInitializerTests : BaseTests {
        [TestInitialize]
        public override void TestInitialize() {
            base.TestInitialize();
            type = typeof(CountriesDbTableInitializer);
        }

        [TestMethod]
        public void InitializeTest() {
            Assert.Inconclusive();
        }
    }
}
