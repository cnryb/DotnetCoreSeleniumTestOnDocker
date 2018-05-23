using OpenQA.Selenium.Chrome;
using System;

namespace DotnetCoreSeleniumTestOnDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.baidu.com/");
                Console.WriteLine(driver.Title);

            }
        }
    }
}
