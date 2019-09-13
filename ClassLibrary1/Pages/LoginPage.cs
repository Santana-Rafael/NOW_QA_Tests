using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LoginPage
{
    public class SourcesLoginPage
    {
        [FindsBy(How = How.Id, Using = "//main[@role='main']//div[@class='walkthough-container undefined'] //ul[@class='slider-controls']")]
        public string _dotWalk { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='app']//*[@class='btn-nav btn-nav-right net-ico-arrow-right']")]
        public string _rightNavigationWalk { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='app']//*[@class='btn-nav btn-nav-left net-ico-arrow-left']")]
        public string _leftNavigationWalk { get; set; }

        [FindsBy(How = How.Id, Using = "//button[@class='btn btn-default btn-close-modal net-ico-modal-close']")]
        public string _closeWalk { get; set; }

        [FindsBy(How = How.Id, Using = "//button[@class = 'btn btn-featured']")]
        public string _buttonBeginWalk { get; set; }

        [FindsBy(How = How.Id, Using = "//li[@class='login-options-item gtm-element-event'] //*[@alt='NET']")]
        public string _modalLoginNet { get; set; }

        [FindsBy(How = How.Id, Using = "//li[@data-gtm-event-label= 'tipo-login:voucher']")]
        public string _modalLoginVoucher { get; set; }

        [FindsBy(How = How.Id, Using = "//*[@id='app']//*[contains(@class, 'login-sign-item')] //*[contains(@href, 'https://assine.net.com.br')]")]
        public string _modalLoginAssineNet { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@class='walkthough-content']//button[@class='btn btn-featured']")]
        public string _submitLogin { get; set; }

        [FindsBy(How = How.Id, Using = "//button[@class='btn btn-featured btn-login']")]
        public string _query_login_begin_page { get; set; }
        
        [FindsBy(How = How.Id, Using = "//div[@class='login-modal'] //div[@class='btn-back net-ico-arrow-left']")]
        public string _voltarWalk { get; set; }

        [FindsBy(How = How.Id, Using = "//input[@name='username']")]
        public string _usernameLogin { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@class='input-group-form'] //input[@name='password']")]
        public string _passwordLogin { get; set; }

        // REVER *********************
        [FindsBy(How = How.Id, Using = "//span[@class='input-form-show-password hide-eye']")]
        public string _showPassword { get; set; }

        [FindsBy(How = How.Id, Using = "//button[@type='submit']")]
        public string _iniciarLoginModal { get; set; }

        /*
        [FindsBy(How = How.Id, Using = "//li[@class='login-options-item gtm-element-event'] //*[@alt='NET']")]
        public IWebElement _modalLoginNet { get; set; }

        [FindsBy(How = How.Id, Using = "//li[@data-gtm-event-label= 'tipo-login:voucher']")]
        public IWebElement _modalLoginVoucher { get; set; }

        [FindsBy(How = How.Id, Using = "//*[@id='app']//*[contains(@class, 'login-sign-item')] //*[contains(@href, 'https://assine.net.com.br')]")]
        public IWebElement _modalLoginAssineNet { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@class='walkthough-content']//button[@class='btn btn-featured']")]
        public IWebElement _submitLogin { get; set; }


        public struct Images
        {
            string image1 = "//div[@class='walkthough-container undefined'] //img[@src='img/walkthrough/net_intro_001.gif?t=1567542338377 ']";
            string text = "//div[@class='walkthough-container undefined'] //div[@class='item-description']";
            string text_titulo = "//div[@class='walkthough-container undefined'] //h2[@class='item-title']";
            string image2 = "//div[@class='walkthough-container undefined'] //img[@src='img/walkthrough/net_intro_002.gif?t=1567543148583 ']";
            string image3 = "//div[@class='walkthough-container undefined'] //img[@src='img/walkthrough/net_intro_003.gif?t=1567543272968 ']";
            string image4 = "//div[@class='walkthough-container undefined'] //img[@src='img/walkthrough/net_intro_004.gif?t=1567543432498 ']";
        }
        */

    }
}

/*
 
// PÁGINA WALKTHROUGH

        // Voltar na modal login = "//div[@class='login-modal'] //div[@class='btn-back net-ico-arrow-left']";


        // Username
        string query_modal_login_username = "//input[@name='username']";

        // Password
        string query_modal_login_password = "//div[@class='input-group-form'] //input[@name='password']";

        // Show Password
        string query_show_password = "//span[@class='input-form-show-password hide-eye']";

        // Button Começar Login
        string query_modal_login_begining = "//button[@type='submit']";

        // Esqueci minha senha  =  "//div[@class='default-link '] //*[contains(text(), 'Esqueci minha senha')]";

        // Quero me cadastrar =  "//div[@class='default-link '] //*[contains(text(), 'Quero me cadastrar')]";

        // Voucher-quero me cadastrar  =  "//div[@class='highlight-link'] //a[contains(@href, 'cadastro/voucher')]";







// Close intervention Game of thrones
string query_close_intervention = "//button[@class='btn btn-default btn-close-intervention net-ico-modal-close']";

// Dot from walkthrough



// Username
string query_modal_login_username = "//input[@name='username']";

// Password
string query_modal_login_password = "//div[@class='input-group-form'] //input[@name='password']";

// Show Password
string query_show_password = "//span[@class='input-form-show-password hide-eye']";






// PAGE MODAL LOGIN

// Login NET
string query_modal_login_net = "//li[@class='login-options-item gtm-element-event'] //*[@alt='NET']";

// Login Claro TV
string query_login_claro = "//li[@data-gtm-event-label= 'tipo-login:claro-tv']";

// Login Claro Móvel
string query_login_mobil = "//li[@data-gtm-event-label= 'tipo-login:claro']";

// Login Degustação
string query_login_voucher = "//li[@data-gtm-event-label= 'tipo-login:voucher']";

// Assine Net
string query_login_assineNet = "//*[@id='app']//*[contains(@class, 'login-sign-item')] //*[contains(@href, 'https://assine.net.com.br')]";

// Close Modal login
// string query_close_modal = "//div[@class='modal-container modal-login-container'] //button[@class='btn btn-default btn-close-modal net-ico-modal-close']"

    */
