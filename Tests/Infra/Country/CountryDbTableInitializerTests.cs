﻿using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Infra.Location;

namespace Open.Tests.Infra.Country {
    
    [TestClass]
    public class CountryDbTableInitializerTests : CountryDbTests<object> {
        
        [TestInitialize]
        public override void TestInitialize() {
            base.TestInitialize();
            type = typeof(CountriesDbTableInitializer);
        }

        [TestMethod]
        public void CantInitializeTest() {
            Assert.AreEqual(count, db.Countries.Count());
            CountriesDbTableInitializer.Initialize(repository);
            Assert.AreEqual(count, db.Countries.Count());
        }
        
        [TestMethod]
        public void InitializeTest() {
            TestCleanup();
            CountriesDbTableInitializer.Initialize(repository);
            var l = SystemRegionInfo.GetRegionsList();
            for (var i = l.Count; i > 0; i--) {
                var c = l[i - 1];
                if (SystemRegionInfo.IsCountry(c)) continue;
                l.Remove(c);
            }
            Assert.AreEqual(l.Count, db.Countries.Count());
        }
    }
}
