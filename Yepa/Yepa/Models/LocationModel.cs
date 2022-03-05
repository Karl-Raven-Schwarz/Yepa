
using Xamarin.Essentials;

namespace Yepa.Models {
    public class LocationModel {
        public LocationModel(double latitude, double longitude) {
            Latitude = latitude;
            Longitude = longitude;
        }

        public LocationModel(Location location) {
            if (location != null) {
                Latitude = location.Latitude;
                Longitude = location.Longitude;
            }
        }

        public LocationModel() {
            Latitude = Longitude = 0;
        }

        public double Latitude { get; set; } = 0.0;
        public double Longitude { get; set; } = 0.0;
    }
}
