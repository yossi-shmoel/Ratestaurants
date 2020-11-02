using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratestaurants.API.Models
{
    public class RestaurantDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public List<ImageDto> Images{ get; set; }
    }

    public class Location
    {
        public string Address { get; set; }
        public string Country { get; set; }
        public int Lat { get; set; } 
        public int lng { get; set; } 
    }
}
