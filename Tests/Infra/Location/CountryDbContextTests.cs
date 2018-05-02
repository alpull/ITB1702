﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Infra.Location;

namespace Open.Tests.Infra.Location {

    [TestClass]
    public class CountryDbContextTests : CountryDbTests<LocationDbContext> {

        [TestMethod]
        public void CountriesTest() {
            Assert.IsNotNull(db.Countries);
        }
    }
}