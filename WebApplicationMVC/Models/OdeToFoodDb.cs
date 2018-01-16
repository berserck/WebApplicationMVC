using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;

namespace WebApplicationMVC.Models
{

    public interface IOdeToFoodDb : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;
    }

    public class OdeToFoodDb : DbContext, IOdeToFoodDb
    {
        public OdeToFoodDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }

        IQueryable<T> IOdeToFoodDb.Query<T>()
        {
            return Set<T>();
        }
    }
}