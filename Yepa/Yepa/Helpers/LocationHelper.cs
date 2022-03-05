using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Yepa.Models;

namespace Yepa.Helpers 
{
    public static class LocationHelper 
    {
        private static List<AreaModel> Areas =  new List<AreaModel>();
        public static bool IsWorking { get; set; } = true;
        public static string Message { get; set; } = string.Empty;
        public static string TranslatedMessage { get; set; } = string.Empty;
        public static Placemark Placemark { get; set; } = new Placemark() 
        { 
            AdminArea = string.Empty,
            CountryCode = string.Empty,
            CountryName = string.Empty,
            FeatureName = string.Empty,
            Locality = string.Empty,
            Location = new Location(),
            PostalCode = string.Empty,
            SubAdminArea = string.Empty,
            SubLocality = string.Empty,
            SubThoroughfare = string.Empty,
            Thoroughfare = string.Empty,
        };

        /// <summary>
        /// Gets the distance between two LocationModels
        /// </summary>
        /// <param name="locationModelOne"></param>
        /// <param name="locationModelTwo"></param>
        /// <returns>It returns the distance in meters if it is less than 1000 (1 kilometer), if it is greater it returns it in kilometers.</returns>
        public static string GetDistanceToString(LocationModel locationModelOne, LocationModel locationModelTwo) 
        {
            double Distance;
            double Lat = (locationModelTwo.Latitude - locationModelOne.Latitude) * (Math.PI / 180);
            double Lon = (locationModelTwo.Longitude - locationModelOne.Longitude) * (Math.PI / 180);
            double a = Math.Sin(Lat / 2) * Math.Sin(Lat / 2) + Math.Cos(locationModelOne.Latitude * (Math.PI / 180)) * Math.Cos(locationModelTwo.Latitude * (Math.PI / 180)) * Math.Sin(Lon / 2) * Math.Sin(Lon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            Distance = 10000 * c;
            if (Distance < 1.0) 
            {
                return $"{Convert.ToInt32(Distance * 1000)} m"; 
            }
            else 
            {
                return $"{Math.Round(Distance,2)} km";
            }
        }

        public static string DistanceToString(double distance)
        {
            string getDistanceToString;
            if (distance < 1.0)
            {
                getDistanceToString = $"{Math.Round(distance * 1000,1)}m ({Math.Round(distance * 3280.84,1)}p)";
            }
            else
            {
                getDistanceToString = $"{Math.Round(distance, 2)}km ({Math.Round(distance * 0.621371,2)}m)";
            }
            return getDistanceToString;
        }

        public static async Task Localize() 
        {
            try 
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(1));
                var location = await Geolocation.GetLocationAsync(request);
                if (location != null) 
                {
                    await ReverseGeocoding(location);
                    IsWorking = true;
                }
                else  
                {
                    var KnowLocation = await Geolocation.GetLastKnownLocationAsync();
                    if (KnowLocation != null) 
                    {
                        await ReverseGeocoding(KnowLocation);
                        IsWorking = true;
                    }
                }
            }
            catch (FeatureNotSupportedException fnsEx) 
            {
                Message = fnsEx.Message;
                TranslatedMessage = "La función de Localización no es admitida";
                IsWorking = false;
            }
            catch (FeatureNotEnabledException fneEx) 
            {
                Message = fneEx.Message;
                TranslatedMessage = "La función de Localización no está habilitada";
                IsWorking = false;
            }
            catch (PermissionException pEx) 
            {
                Message = pEx.Message;
                TranslatedMessage = "No se ha otorgado permisos de Localización";
                IsWorking = false;
            }
            catch (Exception ex) 
            {
                Message = ex.Message;
                TranslatedMessage = Languages.LocationError;
                IsWorking = false;
            }
        }

        public static async Task ReverseGeocoding(Location location) 
        {
            try 
            {
                var placemarks = await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude);
                var placemark = placemarks?.FirstOrDefault();
                if (placemark != null) 
                {
                    SetArea();
                    Placemark = placemark;
                }
            } 
            catch (FeatureNotSupportedException fnsEx) 
            {
                Console.WriteLine($"Something is wrong: {fnsEx.Message}");
            } 
            catch (Exception ex) 
            {
                Console.WriteLine($"Something is wrong: {ex.Message}");
            }
        }

        public static List<AreaModel> GetAreas() { return Areas; }
        public static Location GetLocation() { return Placemark.Location; }

        public static void SetArea()
        {
            double NormalDistance = 0.050;
            var longitud = Placemark.Location.Longitude;
            var latitude = Placemark.Location.Latitude;
            var Longitude0 = Math.Round(longitud / 5, 2) * 5;
            var Latitude0 = Math.Round(latitude / 5, 2) * 5;

            var Area = new LocationModel[4][]
            {
                new LocationModel[4] 
                {
                    new LocationModel(Math.Round(Latitude0-NormalDistance,2),Math.Round(Longitude0+NormalDistance,2)),
                    new LocationModel(Latitude0,Math.Round(Longitude0+NormalDistance,2)),
                    new LocationModel(Latitude0,Longitude0),
                    new LocationModel(Math.Round(Latitude0-NormalDistance,2),Longitude0),
                },
                new LocationModel[4] 
                {
                    new LocationModel(Latitude0,Math.Round(Longitude0+NormalDistance,2)),
                    new LocationModel(Math.Round(Latitude0+NormalDistance,2),Math.Round(Longitude0+NormalDistance,2)),
                    new LocationModel(Math.Round(Latitude0+NormalDistance,2),Longitude0),
                    new LocationModel(Latitude0,Longitude0),
                },
                new LocationModel[4] 
                {
                    new LocationModel(Latitude0,Longitude0),
                    new LocationModel(Math.Round(Latitude0+NormalDistance,2),Longitude0),
                    new LocationModel(Math.Round(Latitude0+NormalDistance,2),Math.Round(Longitude0-NormalDistance,2)),
                    new LocationModel(Latitude0,Math.Round(Longitude0-NormalDistance,2)),
                },
                new LocationModel[4]
                {
                    new LocationModel(Math.Round(Latitude0-NormalDistance,2),Longitude0),
                    new LocationModel(Latitude0,Longitude0),
                    new LocationModel(Latitude0,Math.Round(Longitude0-NormalDistance,2)),
                    new LocationModel(Math.Round(Latitude0-NormalDistance,2),Math.Round(Longitude0-NormalDistance,2)),
                }
            };

            var MiddleArea = new LocationModel[4]
            {
                new LocationModel(Math.Round(Latitude0-(NormalDistance/2),3),Math.Round(Longitude0+(NormalDistance/2),3)),//1
                new LocationModel(Math.Round(Latitude0+(NormalDistance/2),3),Math.Round(Longitude0+(NormalDistance/2),3)),//2
                new LocationModel(Math.Round(Latitude0+(NormalDistance/2),3),Math.Round(Longitude0-(NormalDistance/2),3)),//3
                new LocationModel(Math.Round(Latitude0-(NormalDistance/2),3),Math.Round(Longitude0-(NormalDistance/2),3)),//4
            } ;

            for (int i = 0; i < 4; i++)
            {
                var getItem = MiddleArea[i];
                var getDistance = Location.CalculateDistance(latitude, longitud, getItem.Latitude, getItem.Longitude, DistanceUnits.Kilometers);
                Areas.Add(new AreaModel(getDistance,Area[i]));
            }

            Areas = new List<AreaModel>(Areas.OrderBy(i => i.Distance));
        }
    }

    public class AreaModel
    {
        public double Distance { get; set; } = 0.0;
        public LocationModel[] Area { get; set; } = new LocationModel[4];

        public AreaModel(double distance, LocationModel[] area)
        {
            Distance = distance;
            Area = area;
        }
    }
}
