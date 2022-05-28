

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Create new chrome browser instane
var driver = new ChromeDriver();

//navigate to wikipedia
driver.Url = "https://wikipedia.org";

System.Console.WriteLine("CURRENT TITLE: " + driver.Title);

//Locate Search field by ID
var searchField = driver.FindElement(By.Id("searchInput"));

//Click On element
searchField.Click();

//FIll Qa And Press Enter
searchField.SendKeys("QA" + Keys.Enter);

System.Console.WriteLine("TITLE AFTER SEARCH: " + driver.Title);
//Close browser
driver.Quit();