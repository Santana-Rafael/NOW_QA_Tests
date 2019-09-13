using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Xml;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using Now.Methods;
using Now.Pages;

using LoginPage;
using Now.Page_Inicio;

namespace Now
{
    
    public class TestsNow
    {
        /// <summary>
        /// </summary>
        
        string query;
        public string query_verify
        {
            set { query_verify = query; }
            get { return this.query_verify; }
        }


        [Test]
        static void Main(string[] args)
        {
            Create_drive create_Drive = new Create_drive();
            IWebDriver webDriver = create_Drive.Get_driver();
            WebDriverWait webDriverWait = create_Drive.Get_wait;
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.nowonline.com.br/");
            string text;

            void _clickLoginPageInicio()
            {
                SourcesLoginPage queries = new SourcesLoginPage();
                SourcesPageInicio query_inicio = new SourcesPageInicio();
                Create_drive _methodDrive = new Create_drive();
                IWebDriver _getDrive = _methodDrive.Get_driver();
                _methodDrive.ClickButton(queries._closeWalk);
                _methodDrive.ClickButton(queries._query_login_begin_page);
                _methodDrive.ClickButton(queries._usernameLogin);
                _methodDrive.ClickButton(queries._passwordLogin);
                _methodDrive.ClickButton(queries._showPassword);
                _methodDrive.ClickButton(queries._iniciarLoginModal);
                _methodDrive.ClickButton(query_inicio._continuarCarousel);

                _getDrive.Close();
            }

            /*
            // Dot do walkthrough
            string query_dot_walkthrough = "//ul[@class='slider-controls']";
            // IWebElement query = webDriver.FindElement(By.XPath("//ul[@class='slider-controls']"));
            create_Drive.WaitButton(query_dot_walkthrough);
            IList<IWebElement> query_dot_walk = webDriver.FindElements(By.XPath("//*[@class = 'slider-controls']/li"));

            foreach (IWebElement item in query_dot_walk)
            {
                item.Click();
                Thread.Sleep(100);
            }

            */


        }


}
}


