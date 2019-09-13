using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Xml.XmlConfiguration;
using System.Xml.XPath;
using System.Xml;
using System.Xml.Xsl;
using OpenQA.Selenium.Interactions;
using System.Threading;
using NUnit.Framework;

namespace Now.Methods
{

    public class Create_drive
    {
        private IWebDriver _mydriver = null;
        protected WebDriverWait _mywait = null;
        public By button;
        public Create_drive() { }
        IWebElement element;
        string queryReturn;
        public By Button { get { return button; } set { this.button = button; } }
        
        private string username;
        private string password;
        private string query;

        public IWebDriver Get_driver()
        {
            if (_mydriver == null)
            {
                _mydriver = new ChromeDriver();
                // _mydriver.Manage().Window.Maximize();
                // _mydriver.Navigate().GoToUrl("https://www.nowonline.com.br/");
            }
            return _mydriver;
        }

        public WebDriverWait Get_wait
        {
            get
            {
                if (_mywait == null)
                {
                    _mywait = new WebDriverWait(_mydriver, TimeSpan.FromMinutes(1));
                }
                return _mywait;
            }
            
        }
        
        /*
        public string WaitButton(string query)
        {
            element = _mywait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(query)));
            queryReturn = query;
            return queryReturn;
        }  
        */
        
        public void ClickButton(string query)
        {
            IWebElement elementClick = _mywait.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(query)));
            Actions active = new Actions(_mydriver);
            active
                .MoveToElement(elementClick)
                .Click(elementClick)
                .Build()
                .Perform();
        }

        public void ClickDot(string query_dot)
        {
            IWebElement elementClick = _mywait.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(query_dot)));
            IList<IWebElement> dot_list = _mydriver.FindElements(By.XPath(query_dot));
            foreach (IWebElement item in dot_list)
            {
                item.Click();
                Thread.Sleep(100);
                //Verifica(query_dot);
            }
        }
        
        public void Submit_box(string WaitButton, string text)
        {
            IWebElement element_submit_box = _mywait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(WaitButton)));
            element_submit_box.SendKeys(text);
            element_submit_box.Submit();
        }

        public void Verifica(string query)
        {
            Assert.NotNull(_mydriver.FindElement(By.XPath(query)));
        }

        public Boolean isValida(string query, string text)
        {
            return temBotao(query) && temImagem(query);
        }

        private Boolean temBotao(string query)
        {
            return _mydriver.FindElement(By.XPath(query)) != null;
        }

        private Boolean temImagem(string query)
        {
            return _mydriver.FindElement(By.XPath(query)) != null;
        }

        private Boolean Validation (string query1, string query2)
        {
            return temBotao(query1) && temImagem(query2);
        }

        /*
            IWebElement presence_button = _mywait.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(query)));
            if (presence_button != null)
            {
                IWebElement query_click = _mydriver.FindElement(By.XPath(query));
                query_click.Click();
                presence_button = null;
                
            }
        */

    }
}



