using Android.App;
using Android.Content;
using Android.Telephony;
using Yepa.Droid.Implementations;
using Yepa.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(PhoneNumberService))]

namespace Yepa.Droid.Implementations {
    public class PhoneNumberService : IPhoneNumberService {
        public string GetSimCountryIso() {
            TelephonyManager telephonyManager = Application.Context.GetSystemService(Context.TelephonyService) as TelephonyManager;
            string CountryCode = telephonyManager.SimCountryIso;
            return CountryCode;
        }
        
        public string GetNetworkCountryIso() {
            TelephonyManager telephonyManager = Application.Context.GetSystemService(Context.TelephonyService) as TelephonyManager;
            string CountryCode = telephonyManager.NetworkCountryIso;
            return CountryCode;
        }
    }
}