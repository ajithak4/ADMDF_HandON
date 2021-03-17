using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;

namespace FoodDetailsTest
{
	[TestFixture]
    public class FoodDetailsTestClass
    {
		public Program program;
		[SetUp]
		public void init()
		{
			program = new Program();

		}


		[Test]
		[TestCase("Name", 1,  "10/01/2021", 100)]
		public void CreateFoodDetail_WhenInvoked_ReturnObject(string name, int dishType, DateTime expiryDate, double price)
		{


			var result = program.CreateFoodDetail( name,  dishType,  expiryDate,  price);
			Assert.IsInstanceOf<FoodDetail>(result);
			Assert.IsNotNull(result);

			Assert.That(result.Name, Is.EqualTo(name));
			Assert.That(result.DishType, Is.EqualTo((FoodDetail.Category)dishType));
			Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
			Assert.That(result.Price, Is.EqualTo(price));
			


		}


		[Test]
		[TestCase("", 1, "10/01/2021", 100)]
		[TestCase(null, 1, "10/01/2021", 100)]
		public void CreateFoodDetail_EmptyName_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
		{



			var result = Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
			Assert.AreEqual("Dish name cannot be empty. Please provide valid value", result.Message);

		}


		[Test]
		[TestCase("Name", 1, "10/01/2021", -10)]

		public void CreateFoodDetail_priceLessThanZero_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
		{



			var result = Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
			Assert.AreEqual("Incorrect value for dish price. Please provide valid value", result.Message);

		}
		[Test]
		[TestCase("Name", 1, "02/01/2021", 100)]

		public void CreateFoodDetail_ExpiryDateLessThanCurrentDate_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
		{



			var result = Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
			Assert.AreEqual("Incorrect expiry date. Please provide valid value", result.Message);

		}
	}
}
