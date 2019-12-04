using System;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumScraper;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicScrapeTest()
        {
            Scraper scraper = new Scraper();
            string expectedResult = "Google";
            string input = $"http://www.google.com";
            Assert.AreEqual(scraper.Scrape(input), expectedResult);
        }
    }
}
