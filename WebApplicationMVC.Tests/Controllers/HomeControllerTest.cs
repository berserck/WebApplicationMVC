using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationMVC;
using WebApplicationMVC.Controllers;
using WebApplicationMVC.Models;
using WebApplicationMVC.Tests.Fakes;

namespace WebApplicationMVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var db = new FakeOdeToFoodDb();
            db.AddSet(TestData.Restaurants);
            HomeController controller = new HomeController(db);
            controller.ControllerContext = new FakeControllerContext();
            // Act
            ViewResult result = controller.Index() as ViewResult;

            IEnumerable<RestaurantListViewModel> model = result.Model as IEnumerable<RestaurantListViewModel>;

            // Assert we get 10 restaurants in the list
            Assert.AreEqual(10, model.Count());

        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
