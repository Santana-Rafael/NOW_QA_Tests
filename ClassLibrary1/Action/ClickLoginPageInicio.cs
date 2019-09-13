using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Now.Methods;
using LoginPage;
using OpenQA.Selenium;
using Now.Page_Inicio;
using Now.Pages;
using OpenQA.Selenium.Support.UI;

namespace Now.Action
{
    class ClickLoginPageInicio
    {
        static void ClickLogin()
        {
            Create_drive _methodDrive = new Create_drive();
            IWebDriver _getDrive = _methodDrive.Get_driver();
            WebDriverWait webDriverWait = _methodDrive.Get_wait;
            _getDrive.Manage().Window.Maximize();
            _getDrive.Navigate().GoToUrl("https://www.nowonline.com.br/");
            
            SourcesLoginPage queries = new SourcesLoginPage();
            SourcesPageInicio query_inicio = new SourcesPageInicio();
            
            _methodDrive.ClickButton(queries._closeWalk);
            _methodDrive.ClickButton(queries._query_login_begin_page);
            _methodDrive.ClickButton(queries._usernameLogin);
            _methodDrive.ClickButton(queries._passwordLogin);
            _methodDrive.ClickButton(queries._iniciarLoginModal);
            _methodDrive.ClickButton(query_inicio._continuarCarousel);
        }
    }
}
