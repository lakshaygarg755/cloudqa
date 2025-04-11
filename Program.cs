using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Input;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest {
   class Program {
      static void Main() {
	  
         IWebDriver driver = new ChromeDriver();

         driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

         driver.Manage().Window.Maximize();

         IWebElement webElement = driver.FindElement(By.XPath("//iframe[@src='/Home/IFrame']"));
         driver.SwitchTo().Frame(webElement);
         IWebElement element = driver.FindElement(By.Id("fname"));
         element.SendKeys("Text entered in first name field of iframe");

         element = driver.FindElement(By.Id("lname"));
         element.SendKeys("Text entered in last name field of iframe");

         IWebElement radioButton = driver.FindElement(By.XPath("//input[@type='radio' and @value='Male']"));
        radioButton.Click();

      }
   }
}