using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartonDetailTest
{	
	[TestFixture]
	public class CartonDetailTestClass
	{
		public Medicine medicine;
		public Program program;
		[SetUp]
		public void init()
		{
			program = new Program();

			medicine = new Medicine()
			{
				Name = "Name",
				GenericMedicineName = "GenericMedicineName",
				Composition = "Composition",
				ExpiryDate = new DateTime(2021, 12, 1),
				PricePerStrip = 10
			};
		}

		[Test]
		[TestCase(10, "06/10/2021", "retailerAddress")]
		public void CreateCartonDetail_WhenInvoked_ReturnObject(int medicineStripCount, DateTime launchDate, string retailerAddress)
		{


			var result = program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine);

			Assert.IsInstanceOf<CartonDetail>(result);

			Assert.That(result.MedicineStripCount, Is.EqualTo(medicineStripCount));
			Assert.That(result.LaunchDate, Is.EqualTo(launchDate));
			Assert.That(result.RetailerAddress, Is.EqualTo(retailerAddress));
			


		}

		[Test]
		[TestCase(-10, "06/10/2021", "retailerAddress")]

		public void CreateCartonDetail_NegativeStripCount_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress)
		{

			var result = Assert.Throws<Exception>(() => program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine));
			Assert.AreEqual("Incorrect strip count. Please check", result.Message);

		}
		[Test]
		[TestCase(10, "02/10/2021", "retailerAddress")]

		public void CreateCartonDetail_LaunchDateLessThanCurrentDate_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress)
		{


			var result = Assert.Throws<Exception>(() => program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine));
			Assert.AreEqual("Incorrect launch date. Please provide valid value", result.Message);

		}

		[Test]
		[TestCase(10, "02/10/2021", "retailerAddress", null)]
		public void CreateCartonDetail_EmptyMedicine_ReturnsEmptyCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress, Medicine medicine)
		{

			CartonDetail result = program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine);
			Assert.That(result, Is.EqualTo(null));

		}
	}
}
