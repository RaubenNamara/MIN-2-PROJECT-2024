using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace GpsGeolocator0._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void GetLocation()
        {
            Location Location = await Geolocation.GetLastKnownLocationAsync();

            if (Location == null)
            {
                Location = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                });
            }
            var placemarks = await Geocoding.GetPlacemarksAsync(Location.Latitude, Location.Longitude);
            var placemark = placemarks?.FirstOrDefault();


            var geocodeAddress =

                $"Country :         {placemark.CountryName}\n" +
                $"CountryCode :     {placemark.CountryCode}\n" +
                $"AdminArea :       {placemark.AdminArea}\n" +
                $"Feature Name:     {placemark.FeatureName}\n" +
                $"Locality :        {placemark.Locality}\n" +
                $"SubAdminArea :    {placemark.SubAdminArea}\n" +
                $"SubLocality :     {placemark.SubLocality}\n" +
                $"Latitude :        {placemark.Location.Latitude.ToString()}\n" +
                $"Longitude :       {placemark.Location.Longitude.ToString()}\n" +
                $"SubThoroughfare:  {placemark.SubThoroughfare}\n" +
                $"Thoroughfare:     {placemark.Thoroughfare}\n";

            txtLoc.Text = geocodeAddress;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            GetLocation();
        }

    }
}
