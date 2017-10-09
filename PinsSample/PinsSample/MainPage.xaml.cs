using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PinsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var customMap = new CustomMap           
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            parentStack.Children.Add(customMap);

            customMap.CustomPins = new List<CustomPin>();
            

            foreach (var place in new PlacesRepository().Places)
            {
                var pin = new CustomPin
                {
                    Pin = new Pin
                    {
                        Type = PinType.Place,
                        Position = new Position(place.Latitude, place.Longitude),
                        Label = place.Name,
                        Address = place.Name,                        
                    },
                    Id = "Xamarin",
                    Url = "http://xamarin.com/about/"                 
                };

                customMap.CustomPins.Add(pin);
                //customMap.Pins.Add(pin.Pin);

            }
            

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));
        }
    }
}
