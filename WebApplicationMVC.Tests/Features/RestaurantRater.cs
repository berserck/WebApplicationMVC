using System.Linq;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Tests.Features
{
    internal class RestaurantRater
    {
        private Restaurant _restaurant;

        public RestaurantRater(Restaurant restaurant)
        {
            this._restaurant = restaurant;
        }

        public RatingResult ComputeRating( int numberOfReviews)
        {
            var result = new RatingResult();
            result.Rating = (int) _restaurant.Reviews.Average(r => r.Rating);
            return result;
        }
    }
}