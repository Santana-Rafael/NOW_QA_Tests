using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Now.Pages
{
    class Begin_Page
    {
        /* 
        
        // PÁGINA WALKTHROUGH

        // Close intervention Game of thrones
        string query_close_intervention = "//button[@class='btn btn-default btn-close-intervention net-ico-modal-close']";

        // Dot from walkthrough
        string query_dot_walk = "//*[@class = 'slider-controls']/li";

        // Navigation walkthrough
        string right_walk_navigation = "//div[@id='app']//*[@class='btn-nav btn-nav-right net-ico-arrow-right']";
        string left_walk_navigation = "//div[@id='app']//*[@class='btn-nav btn-nav-left net-ico-arrow-left']";

        // Close modal Walkthrough e modal Login
        string query_close_walk = "//button[@class='btn btn-default btn-close-modal net-ico-modal-close']";

        //Começar walkthrough
        string query_walk_begin = "//button[@class = 'btn btn-featured']";

        
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

        // Close Modal
        // string query_walk_begin

        // Username
        string query_modal_login_username = "//input[@name='username']";

        // Password
        string query_modal_login_password = "//div[@class='input-group-form'] //input[@name='password']";

        // Show Password
        string query_show_password = "//span[@class='input-form-show-password hide-eye']";

        // Button Começar Login
        string query_modal_login_begining = "//button[@type='submit']";



        // Inicio Page
        
        // Login na pagina de inicio
        string query_login_begin_page = "//button[@class='btn btn-featured btn-login']";

        // Click na tela
        string query_click_on_screen = "//div[@class='overlay-walkthought-tooltip'][@id='tooltip-walkthrough']";

        // Busca
        string search_in_beginPage = "//header[contains(@class, 'main-header')]//button[@class='header-top-search-icon set-search']";

        // Assine Net na tela Inicio
        string assineNet_inBegin = "//header[contains(@class, 'main-header')]//div[@class='default-link ']";

        // Inicio Button
        string button_Inicio = "//a[@class='header-menu-list-item-link active']";

        // Button No-ar Begin page
        string query_beginPage_noAr_carroussel = "//*[@class = 'header-menu-list-item-link'][@href= '/no-ar']";

        // Carroussel Live Channels
        IList < IWebElement > live_carroussel = driver.FindElements(By.XPath("//*[contains(@id,'carousel-no-ar')]//button[@class='btn-play net-ico net-ico-play ']"));
        // Navigation Left-Right Carroussel Live
        string left_walk_navigation = "//div[@id='carousel-8614-67']//*[@class='nav nav-left net-ico-arrow-left']";
        string right_walk_navigation = "//div[@id='carousel-8614-67']//*[@class='nav nav-right net-ico-arrow-right']";
        // Dot Carroussel Live Channels
        IList < IWebElement > dot_live_carroussel = driver.FindElements(By.XPath("//div[@id='carousel-8614-67'] //ol[@class='now-carousel-dots']"));

        // Carroussel Continuar assistindo
        IList < IWebElement > caroussel_continuar_assistindo = driver.FindElements(By.XPath("//div[@id='carousel-8613-8']//button[@class='btn btn-play net-ico net-ico-play ']";
        // Dot Carroussel Novidades
        IList < IWebElement > dot_continuar_assistindo_carroussel = driver.FindElements(By.XPath("//div[@id='carousel-8613-8'] //ol[@class='now-carousel-dots']"));


        // Carrossel Recomendados - Método provavelmente está errado mas o XPath certo guarda os childNode para o clique em cada um dos itens do carrossel
        // Metodo para extrair e clicar em cada um dos nós deve ser pesquisado. Tudo o que consegui até agora foi isso:
        // https://stackoverflow.com/questions/53832847/how-to-get-attribute-from-child-node-through-selenium-and-c-sharp
        // https://stackoverflow.com/questions/6359737/xpath-how-do-you-select-the-child-elements-of-a-node
        // https://stackoverflow.com/questions/558870/xpath-selectnodes-in-net
        IList < IWebElement > dot_recomendados_carroussel = driver.FindElements(By.XPath("//div[@id='carousel-6920-30'] //div[@class='container-items']"));









        // TNT Live
        string query_tnt_live_at_begin = "//*[contains (@class, '25631')] [contains(@class, 'live')]";

        // Play on details page
        string query_page_live_details_tnt = "//div[(@class='schedule-details-cover')]//div[(@class = 'wrap-play ')] //button[(@class = 'btn-play net-ico net-ico-play ')]";

        // Click at No-ar in player
        string query_noAr_player = "//div[(@class= 'live-acoes')]";

        // Click at Sair in player
        string query_player_out = "//div[(@class= 'btn btn-default btn-voltar net-ico-player_voltar')]";

        // Click play on hero banner Live
        string query_play_on_herobanner = "//div[(@class='hero-details-container hero-live highlights-item-container')]//div[(@class = 'wrap-play ')] //button[(@class = 'btn-play net-ico net-ico-play ')]";

        // Click at Recomendados in Begin page
        string query_recommended_begin_page = "//div[(@class= 'poster poster-horizontal scale-center-left ')] //div[(@class= 'channel-name-container')] ";

        // Click at continuar assistindo in Begin Page
        string query_follow_show = "//div[(@class='poster poster-horizontal poster-horizontal-in-progress')] //div[(@class = 'wrap-play ')] //button[(@class = 'btn-play net-ico net-ico-play ')]";





        

        // Começar in walkthrough
        string query_comecar_walk = "//div[@class='walkthough-content']//button[@class='btn btn-featured']";

        
        // Começar in modal Login
        string query_modal_login_comecar = "//div[@class='trial-content']//*[@type='submit']";

        //
        //
        //
        //


        //
        //
        //
        //

        Pagina walkthrough

        Dot walkthrough  = "//main[@role='main']//div[@class='walkthough-container undefined'] //ul[@class='slider-controls']";

        Seta esquerda walkthrough = "//div[@class='walkthough-container undefined'] //div[@class='slider-container']//button[@class='btn-nav btn-nav-left net-ico-arrow-left']";

        Seta direita walkthrough  = "//div[@class='walkthough-container undefined'] //div[@class='slider-container']//button[@class='btn-nav btn-nav-right net-ico-arrow-right']";

        Close walkthrough       =   "//div[@class='walkthough-container undefined'] //button[@class='btn btn-default btn-close-modal net-ico-modal-close']";

        Abrir a modal login [(>)Começar] do walkthrough = 


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



        // PÁGINA INICIO    
        // Inicio Page
        
        // Login na pagina de inicio
        string query_login_begin_page = "//button[@class='btn btn-featured btn-login']";

        // Click na tela
        string query_click_on_screen = "//div[@class='overlay-walkthought-tooltip'][@id='tooltip-walkthrough']";

        // Busca
        string search_in_beginPage = "//header[contains(@class, 'main-header')]//button[@class='header-top-search-icon set-search']";

        // Assine Net na tela Inicio
        string assineNet_inBegin = "//header[contains(@class, 'main-header')]//div[@class='default-link ']";

        // Botão Inicio(home)
        string button_home = "//a[@class='header-menu-list-item-link active']";
        
        Botão No-ar  =   "//*[@class = 'header-menu-list-item-link'][@href= '/no-ar']";

        Botão Programas de TV   =  "//div[@class='header-menu desktop-menu'] //a[@href='/programas-de-tv']";

        Botão Cinema   =   "//div[@class='header-menu desktop-menu'] //a[@href='/cinema']";

        Botão séries   =   "//div[@class='header-menu desktop-menu'] //a[@href='/series']";

        Botão kids  =   "//div[@class='header-menu desktop-menu'] //a[@href='/series']";

        Botão Now Clube =   "//div[@class='header-menu desktop-menu'] //a[@href='/now-clube']";

        Click no hero banner (Lista sendo que o primeiro e o ultimo podem ser desconsiderados)  =   "//div[@id='heroBannerHome'] //a[@class='hightlight-link']";
        
        Dot do herobanner  = "//span[@class='input-form-show-password hide-eye']";

        Dot carrossel No-ar = "//div[@id='carousel-no-ar'] /following-sibling::ol[@class='now-carousel-dots']"

        Lista de todos os carrosséis da página início  =  ("//*[@class='carousel-container  ']")

        Carrossel No-ar primeiro item  =  "//div[@id='carousel-no-ar']//div[@class='content content-horizontal content-horizontal-two-row']//button[@class='btn-play ']";

        Carrossel continuar-assistindo =  "//div[@id='carousel-continuar-assistindo'] //div[@class='content content-horizontal'] //button[@class='btn btn-play ']";

        Carrossel recomendados  =  "//div[@id='carousel-recomendados']//div[@class='content content-horizontal content-horizontal-two-row']";

        Carrossel canais    =   "//div[@id='carousel-canais']//div[@class='content content-horizontal content-horizontal-two-row']";

        Carrossel novidades = "//div[@id='carousel-novidades']//div[@class='content content-horizontal content-horizontal-two-row']";

        Carrossel conteúdos em degustação   =   "//div[@id='carousel-contedos-em-degustao']//div[@class='content content-horizontal content-horizontal-two-row']";

        Carrossel Lancamentos = $x("//div[@id='carousel-lanamentos'] /descendant-or-self:: *[@class='content content-vertical']")

        Carrossel lançamentos em promoção = ("//div[@id='carousel-lanamentos-em-promoo'] //div[@class='box carousel-item']");
        
        Dots lançamentos em promoção ("//div[@id='carousel-lanamentos-em-promoo'] /following-sibling::ol[@class='now-carousel-dots']");

        Carrossel disponível para a compra = ("//div[@id='carousel-filmes-disponveis-para-compra'] //div[@class='box carousel-item']");

        ***********
        * *********
        * *********
        * X-path Geral para Dots da maioria das páginas = ("//main[@role='main'] //div[@class='overflow-container'] //div[contains(.,'NOME_DO_CARROSSEL_BEM_ESPECIFICO')] //ol[@class='now-carousel-dots']")
                    
        Carrossel Kids diminuido = $x("//div[@id = 'carousel-kids'] //div[@class='container-items'] /descendant-or-self:: *[@class='content content-horizontal content-horizontal-two-row']")




        

        */
    }
}
