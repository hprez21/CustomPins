using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinsSample
{
    public class Place
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class PlacesRepository
    {
        public List<Place> Places { get; set; }

        public PlacesRepository()
        {
            Places = new List<Place>
            {
                new Place
                {
                    Name = "Lugar 1",
                    Latitude = 37.79752,
                    Longitude = -122.40183
                },
                new Place
                {
                    Name = "Lugar 2",
                    Latitude = 37.80752,
                    Longitude = -122.40183
                }
            };
        }
    }
}
