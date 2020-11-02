using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratestaurants.API.Models
{
    public class MenuItemDto
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }

        public List<ImageDto> Images { get; set; }
    }
}
