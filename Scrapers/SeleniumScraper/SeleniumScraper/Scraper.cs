using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumScraper
{
    public class Scraper
    {
        IWebDriver driver;
        public Scraper()
        {
            driver = new ChromeDriver("C:\\Users\\chris\\Downloads\\chromedriver_win32-78");
        

        }

        public void Scrape()
        {
            driver.Url = "http://www.reddit.com";
            IReadOnlyCollection<IWebElement> titles = driver.FindElements(By.TagName("h3"));

            Console.WriteLine(titles.ToString());
          




            driver.Close();


        }
    }

}
