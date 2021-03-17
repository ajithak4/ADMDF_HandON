using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineTest
{
	[TestFixture]
	class MedicineTestClass
	{

		
		public Program program;
		[SetUp]
		public void init()
		{
			program = new Program();

		}


		[Test]
		[TestCase("Name", "GenericMedicineName", "composition", "10/01/2021", 100)]
		public void CreateMedicineDetails_WhenInvoked_ReturnObject(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
		{
			

			var result = program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);
			Assert.IsInstanceOf<Medicine>(result);
			Assert.IsNotNull(result);

			Assert.That(result.Name,Is.EqualTo(name));
			Assert.That(result.GenericMedicineName, Is.EqualTo(genericMedicineName));
			Assert.That(result.Composition, Is.EqualTo(composition));
			Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
			Assert.That(result.PricePerStrip, Is.EqualTo(pricePerStrip));


		}


		[Test]
		[TestCase("Name", "", "composition", "10/01/2021", 100)]
		[TestCase("Name", null, "composition", "10/01/2021", 100)]

		public void CreateMedicineDetail_EmptyName_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
		{
			


			var result = Assert.Throws<Exception>(() => program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
			Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", result.Message);

		}
		

		[Test]
		[TestCase("Name", "GenericMedicineName", "composition", "10/01/2021", 10)]
		
		public void CreateMedicineDetails_pricePerstripLessThanZero_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
		{
			


			var result = Assert.Throws<Exception>(() => program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
			Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", result.Message);

		}
		[Test]
		[TestCase("Name", "GenericMedicineName", "composition", "02/05/2021", 100)]

		public void CreateMedicineDetails_ExpiryDateLessThanCurrentDate_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
		{
			


			var result = Assert.Throws<Exception>(() => program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
			Assert.AreEqual("Incorrect expiry date. Please provide valid value", result.Message);

		}

	}
	}
