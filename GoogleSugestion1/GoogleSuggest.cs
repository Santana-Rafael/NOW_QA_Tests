using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

class GoogleSuggest
{
    string query_verify { get; set; }


    [Test]
    static void Main(string[] args)
    {
        // Create a new instance of the Firefox driver.
        // Note that it is wrapped in a using clause so that the browser is closed 
        // and the webdriver is disposed (even in the face of exceptions).

        // Also note that the remainder of the code relies on the interface, 
        // not the implementation.

        // Further note that other drivers (InternetExplorerDriver,
        // ChromeDriver, etc.) will require further configuration 
        // before this example will work. See the wiki pages for the
        // individual drivers at http://code.google.com/p/selenium/wiki
        // for further information.
        using (IWebDriver driver = new ChromeDriver())
        {
            driver.Manage().Window.Maximize();

            //Notice navigation is slightly different than the Java version
            //This is because 'get' is a keyword in C#
            driver.Navigate().GoToUrl("https://webportalpreprod.clarobrasil.mobi/");

            // Find the text input element by its name


            // Now submit the form. WebDriver will find the form for us from the element


            // Right do walkthrough      XPATH NÃO VÁLIDO
            // IWebElement query_right_walk = driver.FindElement(By.XPath("//button[@class='btn-nav btn-nav-right net-ico-arrow-right'].Click()"));

            // Left do walkthrough
            // IWebElement query_left_walk = driver.FindElement(By.XPath("//button[@class='btn-nav btn-nav-left net-ico-arrow-left'].Click()"));

            // Escondido no momento
            // query.Submit();

            // Close walkthrough




            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            IWebElement query_close_walk = wait.Until(d => d.FindElement(By.XPath("//button[@class='btn btn-default btn-close-modal net-ico-modal-close']")));

            Boolean check_close_walk = query_close_walk.Displayed;

            Console.WriteLine("Walk: " + check_close_walk);

            query_close_walk.Click();



            // Close Intervention
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            IWebElement query_close_intervention = wait.Until(d => d.FindElement(By.XPath("//button[@class='btn btn-default btn-close-intervention net-ico-modal-close']")));

            Console.WriteLine("intervention: " + query_close_intervention);

            query_close_intervention.Click();




            // IWebElement query_close_walk = driver.FindElement(By.XPath("//button[@class='btn btn-default btn-close-modal net-ico-modal-close']"));
            // driver.FindElement(By.XPath("//button[@class='btn btn-default btn-close-modal net-ico-modal-close']")).Click();

            // Dot do walkthrough
            // IWebElement query = driver.FindElement(By.XPath("//ul[@class='slider-controls']"));
            // IList<IWebElement> query_dot_walk = driver.FindElements(By.XPath("//*[@class = 'slider-controls']/li"));
            /*
            foreach (var item in query_dot_walk)
            {

                item.Click();
            }
            */

            // Click Login Begin Page
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromMinutes(3));
            IWebElement query_login_begin_page = wait1.Until<IWebElement>(d => d.FindElement(By.XPath("//button[@class='btn btn-featured btn-login']")));


            //WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromMinutes(3));
            //IWebElement query_login_begin_page = wait1.Until<IWebElement>(d => d.FindElement(By.XPath("//button[@class='btn btn-featured btn-login']")));
            // IWebElement query_login_begin_page = driver.FindElement(By.XPath(("//div[@class='btn-content'] //*[@class='btn-content-label']")));
            driver.FindElement(By.XPath(("//button[@class='btn btn-featured btn-login']"))).Click();

            //Começar walkthrough
            /*
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            IWebElement query_begin_walk = wait.Until<IWebElement>(d => d.FindElement(By.XPath("//button[@class = 'btn btn-featured'].Click()")));
            */

            // Desnecessário nessa forma atual
            // query_begin_walk.Click();

            // Login Net
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            IWebElement query_login_net = (driver.FindElement(By.XPath("//li[@class='login-options-item gtm-element-event'] //*[@alt='NET']")));



            // Login Claro TV
            /*wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            IWebElement query_login_tvclaro = driver.FindElement(By.XPath("//li[@data-gtm-event-label= 'tipo-login:claro-tv']"));
            query_login.Click();

            // Login Claro Móvel
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            IWebElement query_login_mobile = driver.FindElement(By.XPath("//li[@data-gtm-event-label= 'tipo-login:claro']"));
            query_login.Click();

            // Login Degustação
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            IWebElement query_login_voucher = driver.FindElement(By.XPath("//li[@data-gtm-event-label= 'tipo-login:voucher']"));
            query_login.Click();

            // Assine Net
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            IWebElement query_login_buy_net = driver.FindElement(By.XPath("//*[@id='app']/div/div[1]/div[1]/div/div[1]/div/div/div/div[2]/div[1]/div[2]/div/a"));
            query_login.Click();

            // Close modal Login
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            IWebElement query_login_close = driver.FindElement(By.XPath("//button[@class= 'btn btn-default btn-close-modal net-ico-modal-close']"));
            query_login.Click();
            */

            // Input Username
            WebDriverWait wait_user = new WebDriverWait(driver, TimeSpan.FromMinutes(15));
            IWebElement query_login_username = wait_user.Until<IWebElement>(dd => dd.FindElement(By.XPath("//input[@name='username']")));
            driver.FindElement(By.XPath("//input[@name='username']")).Clear();
            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys("nowmultiscreen1");

            // Input Password
            WebDriverWait wait_pass = new WebDriverWait(driver, TimeSpan.FromMinutes(5));
            IWebElement query_login_password = driver.FindElement(By.XPath("//div[@class='input-group-form'] //input[@name='password']"));
            driver.FindElement(By.XPath("//div[@class='input-group-form'] //input[@name='password']")).Clear();
            driver.FindElement(By.XPath("//div[@class='input-group-form'] //input[@name='password']")).SendKeys("nowmulti1");
            //query_login_password.SendKeys("nowmulti1");

            // Show Password
            // IWebElement query_login_show_pass = driver.FindElement(By.XPath("//span[@class='input-form-show-password hide-eye']"));

            // Button Começar Login
            IWebElement query_login_begin = driver.FindElement(By.XPath("//button[@type='submit']"));

            // Button No-ar Begin page
            IWebElement query_live_at_begin = driver.FindElement(By.XPath("//*[@href= '/no-ar']"));

            // Live Channels at EPG
            /* IList < IWebElement > query_live_all_at_epg = driver.FindElements(By.XPath("//*[contains(@class, 'live')]"));

            foreach (var item in query_live_all_at_epg)
            {
                item.Click();
            }
            */

            // TNT Live
            IWebElement query_tnt_live_at_begin = driver.FindElement(By.XPath("//*[contains (@class, '25631')] [contains(@class, 'live')]"));

            // Play on details page
            IWebElement query_page_live_details_tnt = driver.FindElement(By.XPath("//div[(@class='schedule-details-cover')]//div[(@class = 'wrap-play ')] //button[(@class = 'btn-play net-ico net-ico-play ')]"));


            // Click at No-ar in player
            IWebElement query_login4 = driver.FindElement(By.XPath("//div[(@class= 'live-acoes')]"));

            // Click at Sair in player
            IWebElement query_player_out = driver.FindElement(By.XPath("//div[(@class= 'btn btn-default btn-voltar net-ico-player_voltar')]"));

            // Click play on hero banner Live
            IWebElement query_play_on_herobanner = driver.FindElement(By.XPath("//div[(@class='hero-details-container hero-live highlights-item-container')]//div[(@class = 'wrap-play ')] //button[(@class = 'btn-play net-ico net-ico-play ')]"));

            // Click at Recomendados in Begin page
            IWebElement query_recommended_begin_page = driver.FindElement(By.XPath("//div[(@class= 'poster poster-horizontal scale-center-left ')] //div[(@class= 'channel-name-container')] "));

            // Click at continuar assistindo in Begin Page
            IWebElement query_follow_show = driver.FindElement(By.XPath("//div[(@class='poster poster-horizontal poster-horizontal-in-progress')] //div[(@class = 'wrap-play ')] //button[(@class = 'btn-play net-ico net-ico-play ')]"));



            // query.Submit();

            // Metodo de fechar a modal
            /* 
            void CloseModal ()
            {
                query = driver.FindElement(By.PartialLinkText("close-modal"));
            }  
            */





            // Google's search is rendered dynamically with JavaScript.
            // Wait for the page to load, timeout after 10 seconds
            /*
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            wait.Until(d => d.Title.StartsWith("cheese", StringComparison.OrdinalIgnoreCase));
            */

            // Should see: "Cheese - Google Search" (for an English locale)
            // Console.WriteLine("Page title is: " + driver.Title);
        }
    }
}


