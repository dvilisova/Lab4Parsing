using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using RabotaSBDLib;


namespace Lab4Parsing
{
    class Program
    {

        static void Main(string[] args)
        {
            
        Console.WriteLine("Запуск браузера");
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl(@"https://thesims.cc/threads/blog-upravlenie-zhilem-pod-sdachu-v-dopolnenii-the-sims-4-sdaetsja.4223337/");
            Console.WriteLine("Запуск поиска по ID");
            List<IWebElement> acticle = new List<IWebElement>(driver.FindElements(By.XPath("//article[@class='message message--post js-post js-inlineModContainer  ']")));
            foreach (var item in acticle)
            {
                var name = item.GetAttribute("data-author");
                var number = item.FindElement(By.XPath(".//ul[@class='message-attribution-opposite message-attribution-opposite--list ']//li[2]")).Text;
                var content = item.FindElement(By.XPath(".//div[@class='bbWrapper']")).Text;
                Console.WriteLine($"{number} {name} {content}");

                //string result = new Class1().Add(number, name, content);
                //var name = driver.FindElement(By.XPath("//h4[@class='message-name']")).Text;
                //Console.WriteLine(result);

            }
            driver.Quit();
        }
    }
}
