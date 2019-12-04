using System;
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

        public string Scrape(string url)
        {
            driver.Url = url;

            string title = driver.Title;


            driver.Close();

            return title;

        }
    }

}
