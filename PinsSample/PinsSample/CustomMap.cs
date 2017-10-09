using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace PinsSample
{
    public class CustomMap : Map
    {
        public CustomMap() : base(MapSpan.FromCenterAndRadius(new Position(37, -122), Distance.FromMiles(0.3)))
        {
            
        }
        public List<CustomPin> CustomPins { get; set; }
    }
}
