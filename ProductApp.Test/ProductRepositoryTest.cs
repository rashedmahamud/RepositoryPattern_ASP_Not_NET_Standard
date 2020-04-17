using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductApp.Infrastructure;
using ProductApp.Core;

namespace ProductApp.Test
{
    /// <summary>
    /// Summary description for ProductRepositoryTest
    /// </summary>
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository Repo;

        [TestInitialize]
        public void TestSetup() {


            ProductInitalizeDB db = new ProductInitalizeDB();
            System.Data.Entity.Database.SetInitializer(db);
            Repo = new ProductRepository();

        }


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion



        [TestMethod]
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {

            var result = Repo.GetProducts();
            Assert.IsNotNull(result);
            var numberOfRecords = result.Count;

            Assert.AreEqual(2, numberOfRecords);
        }


        [TestMethod]
        public void IsRepositoryAdded() {


            Product productToadd = new Product {

                Id = 3,
                 inStock = true,
                  Name = "Laptop",
                   Price=100

            };

            Repo.Add(productToadd);
            var result = Repo.GetProducts();
            var numberOfrecords = result.Count;
            Assert.AreEqual(3, numberOfrecords);

        }
    }
}
