﻿using System.Collections.Generic;
using Open.Data.Country;

namespace Open.Domain.Country {

    public class CountryObjectsList : List<CountryObject> {

        public CountryObjectsList(IEnumerable<CountryDbRecord> l) {
            if (l is null) return;
            foreach (var e in l) {
                Add(new CountryObject(e));
            }
        }
    }
}
