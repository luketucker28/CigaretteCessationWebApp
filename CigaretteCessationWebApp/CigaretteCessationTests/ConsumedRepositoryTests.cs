using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CigaretteCessationWebApp.Repository;
using CigaretteCessationWebApp.Models;
using CigaretteCessationWebApp;
using System.Collections.Generic;


namespace CigaretteCessationTests
{

    [TestClass]
    public class ConsumedRepositoryTests
    {

        public static ConsumedRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new ConsumedRepository();
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
            repo.Dispose();
        }

        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }

        [TestMethod]
        public void TestAddToDatabase() //Valid
        {
           
            repo.Add(new Consumed("luket", new DateTime(2008, 12, 12), "4:30PM", "Home", " Stress", "fight"));
            Assert.AreEqual(1, repo.GetCount());
            repo.Clear();
        }
        [TestMethod]
        public void TestDeleteFromDatabase()
        {
            var tester = new Consumed("luket", new DateTime(), "4:30PM", "Home", " Stress", "fight");
            repo.Add(tester);
            repo.Delete(tester);
            Assert.AreEqual(0, repo.GetCount());
            repo.Clear();
        }
        //[TestMethod]
        //public void TestAllMethod()
        //{
        //    repo.Add(new Consumed("luket", new DateTime(2014, 2, 5), "4:30PM", "Home", " Stress", "fight"));
        //    repo.Add(new Consumed("john", new DateTime(2014, 2, 2), "4:30PM", "Home", " Stress", "fight"));
        //    repo.Add(new Consumed("luket", new DateTime(2014, 1, 2), "4:30PM", "Home", " Stress", "fight"));
        //    repo.Add(new Consumed("luket", new DateTime(2014, 4, 5), "4:30PM", "Home", " Stress", "fight"));
        //    repo.OrderByDate();
        //    Assert.AreEqual("luket", repo.FirstEntry().UserID);
        //    repo.Clear();

        //}

            [TestMethod]
            public void TestGetCount()
            {
                repo.Add(new Consumed("luket",new DateTime(2014, 2, 5), "4:30PM", "Home", " Stress", "fight"));
                 repo.Add(new Consumed("john",new DateTime(2014, 2, 2), "4:30PM", "Home", " Stress", "fight"));
                 repo.Add(new Consumed("luket",new DateTime(2014, 1, 2), "4:30PM", "Home", " Stress", "fight"));
                 repo.Add(new Consumed("luket",new DateTime(2014, 4, 5), "4:30PM", "Home", " Stress", "fight"));
                repo.OrderByDate();
                Assert.AreEqual(4, repo.GetCount());
                repo.Clear();
            }

            [TestMethod]
            public void TestClear()
            {
                repo.Add(new Consumed("luket", new DateTime(2014, 04, 25), "4:30PM", "Home", " Stress", "fight"));
                repo.Clear();
                Assert.AreEqual(0, repo.GetCount());
            }
            [TestMethod]
            public void GetByReasons()
            {
                repo.Clear();
                var a = new Consumed("luket",new DateTime(2014, 4, 4), "4:30PM", "Work", " Stress", "fight");
                var b = new Consumed("luket",new DateTime(2014, 4, 5), "5:30PM", "Work", " Stress", "fight");
                repo.Add(a);
                repo.Add(b);
                var c = repo.GetByLocation("Work");
                var d = c.Count;
                Assert.AreEqual(b.ToString(), c.ToString() );
                repo.Clear();

            }

            
        }
    }

   
