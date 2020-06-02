using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        // null Ratings should return 0
        [TestMethod]
        public void ProductModel_AverageRating_Ratings_Null_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = null;

            // Act
            int avg = result.AverageRating();

            // Assert
            Assert.AreEqual(0, avg);
        }

        // when total is 0, should return 0
        [TestMethod]
        public void ProductModel_AverageRating_Total_Zero_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { 0 };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        // when count is 0, should return 0
        [TestMethod]
        public void ProductModel_AverageRating_Count_Zero_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        // no-args ctor should return 5
        [TestMethod]
        public void ProductModel_AverageRating_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_ToString_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            string str1 = JsonSerializer.Serialize<ProductModel>(result);

            // Assert
            Assert.AreEqual(str1, result.ToString());
        }

        // if we set desc to "abc", then get desc, it should return "abc"
        [TestMethod]
        public void ProductModel_set_Description_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "abc";

            // Assert
            Assert.AreEqual(result.Description, "abc");
        }

        // if we set Id to "a", then get Id, it should return "a"
        [TestMethod]
        public void ProductModel_set_Id_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "a";

            // Assert
            Assert.AreEqual("a", result.Id);
        }

        // if we set Image to "qwerty", then get Image, it should return "qwerty"
        [TestMethod]
        public void ProductModel_set_Image_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "qwerty";

            // Assert
            Assert.AreEqual(result.Image, "qwerty");
        }

        // if we set Maker to "Mark", then get Maker, it should return "Mark"
        [TestMethod]
        public void ProductModel_set_Maker_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "Mark";

            // Assert
            Assert.AreEqual("Mark", result.Maker);
        }

        // if we set Sequence to "12345", then get Sequence, it should return "12345"
        [TestMethod]
        public void ProductModel_set_Sequence_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "12345";

            // Assert
            Assert.AreEqual("12345", result.Sequence);
        }

        // if we set Title to "Looney Tunes", then get Title, it should return "Looney Tunes"
        [TestMethod]
        public void ProductModel_set_Title_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "Looney Tunes";

            // Assert
            Assert.AreEqual("Looney Tunes", result.Title);
        }

        // if we set Url to "www.bob.com", then get Url, it should return "www.bob.com"
        [TestMethod]
        public void ProductModel_set_Url_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "www.bob.com";

            // Assert
            Assert.AreEqual("www.bob.com", result.Url);
        }
    }
}
