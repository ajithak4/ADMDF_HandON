using MyFoodSupply;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyDetailTest
{
    public class SupplyDetailsTestClass
    {
		public FoodDetail foodDetail;
		public Program program;
		[SetUp]
		public void init()
		{
			program = new Program();

			foodDetail = new FoodDetail()
			{
				Name = "Name",
				DishType = (FoodDetail.Category)1,
				 ExpiryDate = new DateTime(2021, 12, 1),
				Price = 100
			
			};
		}

		[Test]
		[TestCase(10, "06/10/2021", "sellerName",15)]
		public void CreateSupplyDetail_WhenInvoked_ReturnObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
		{


			var result = program.CreateSupplyDetail( foodItemCount, requestDate,  sellerName,  packingCharge,foodDetail);

			Assert.IsInstanceOf<SupplyDetail>(result);
			Assert.IsNotNull(result);

			Assert.That(result.Count, Is.EqualTo(foodItemCount));
			Assert.That(result.RequestDate, Is.EqualTo(requestDate));
			Assert.That(result.SellerName, Is.EqualTo(sellerName));
		



		}

		[Test]
		[TestCase(-10, "06/10/2021", "sellerName", 15)]

		public void CreateSupplyDetail_NegativeFoodItemCOunt_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
		{

			var result = Assert.Throws<Exception>(() => program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail));
			Assert.AreEqual("Incorrect food item count. Please check", result.Message);

		}
		[Test]
		[TestCase(10, "02/10/2021", "sellerName", 15)]

		public void CreateSupplyDetail_RequestDateLessThanCurrentDate_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
		{


			var result = Assert.Throws<Exception>(() => program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail));
			Assert.AreEqual("Incorrect food request date. Please provide valid value", result.Message);

		}

		[Test]
		[TestCase(10, "06/10/2021", "sellerName", 15)]
		public void CreateSupplyDetail_EmptyFoodItemObject_ReturnsEmptyCartonObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
		{

			SupplyDetail result = program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail);
			Assert.That(result, Is.EqualTo(null));

		}
	}
}
