using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BC_IS413_Assignment4.Models
{
    public class RankedRestaurant
    {
        //Private property setting for Rank
        public RankedRestaurant(int rank)
        {
            Rank = rank;
        }

        [Required(ErrorMessage = "This field is required")]
        public int Rank { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's all tasty!";

        [Required(ErrorMessage = "This field is required")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        //regular expression to ensure a phone number is entered correctly
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
        public string? Website { get; set; } = "Coming soon";

        //method to get the top 5 restaurants and return them in an array
        public static RankedRestaurant[] GetRestaurants()
        {
            RankedRestaurant r1 = new RankedRestaurant(1)
            {
                RestaurantName = "Good Move Cafe",
                FavoriteDish = "Honey Bacon Club Sandwich",
                Address = "1 Center St. Suite 100, Provo UT 84601",
                Phone = "801-850-9113",
                Website = "goodmovecafe.com"
            };

            RankedRestaurant r2 = new RankedRestaurant(2)
            {
                RestaurantName = "Silver Dish Thai Cuisine",
                FavoriteDish = "Pad Thai",
                Address = "278 W Center St, Provo, UT 84601",
                Phone = "801-737-9540"
                //Missing website to propagate default value for the assignment
            };

            RankedRestaurant r3 = new RankedRestaurant(3)
            {
                RestaurantName = "Bianca’s La Petite French Bakery",
                FavoriteDish = "Kro-Nut",
                Address = "90 W Center Street, Provo UT 84601",
                Phone = "801-226-7870",
                Website = "biancaslapetitefrenchbakery.com"
            };

            RankedRestaurant r4 = new RankedRestaurant(4)
            {
                RestaurantName = "Two Jack's Pizza",
                FavoriteDish = "BBQ Chicken Pizza",
                Address = "80 West Center Street, Provo UT 84601",
                Phone = "801-491-2861",
                Website = "twojackspizza.com"
            };

            RankedRestaurant r5 = new RankedRestaurant(5)
            {
                RestaurantName = "Station 22 Cafe",
                //Missing favorite dish to propagate default value for the assignment
                Address = "22 W Center St, Provo UT 84601",
                Phone = "801-607-1803",
                Website = "station22cafe.com"
            };

            return new RankedRestaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
