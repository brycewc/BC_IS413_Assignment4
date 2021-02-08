using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//temp storage class to store user added recommendations, top 5 are stored in an array in the class. 
namespace BC_IS413_Assignment4.Models
{
    public class TempStorage
    {
        private static List<UserRestaurant> apps = new List<UserRestaurant>();

        public static IEnumerable<UserRestaurant> App => apps;

        public static void AddApp(UserRestaurant app)
        {
            apps.Add(app);
        }
    }
}
