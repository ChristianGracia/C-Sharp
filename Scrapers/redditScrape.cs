using System;
using System.Collections.Generic;
using System.Linq;
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
            driver.Manage().Window.Maximize();
   
                



            IReadOnlyCollection<IWebElement> titles = driver.FindElements(By.TagName("h3"));

            foreach (var webElement in titles)
            {
                Console.WriteLine(webElement.Text);
            }



            driver.Close();


        }
    }

}