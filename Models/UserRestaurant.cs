using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BC_IS413_Assignment4.Models
{ 
    public class UserRestaurant
    {
        [Required(ErrorMessage = "This field is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; } = "It's all tasty!";

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
    }
}
