using System;

namespace CSharp7
{
    // BC, clash
    public class TupleLiteralsSample
    {
        private StoreLocator _storeLocator = new StoreLocator();
        public double GetNearestStoreClassic(double lat, double lon, out Store store)
        {
            store = _storeLocator.FindNearest(lat, lon);

            if (store == null)
            {
                return -1;
            }

            return _storeLocator.DistanceFrom(store, lat, lon);
        }

        public Tuple<double, Store> GetNearestStoreTuple(double lat, double lon)
        {
            var store = _storeLocator.FindNearest(lat, lon);
            var distance = _storeLocator.DistanceFrom(store, lat, lon);

            return new Tuple<double, Store>(distance, store);
        }

        public (double distance, Store store) GetNearestStore(double lat, double lon)
        {
            var store = _storeLocator.FindNearest(lat, lon);
            var distance = _storeLocator.DistanceFrom(store, lat, lon);

            return (distance, store);
        }

        public class StoreLocator
        {
            public Store FindNearest(double lat, double lon)
            {
                return new Store();
            }

            public double DistanceFrom(Store store, double lat, double lon)
            {
                return 100;
            }
        }

        public class Store
        {
        }
    }
}
