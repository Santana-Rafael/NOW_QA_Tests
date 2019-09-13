using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Now.Page_Inicio
{
    public partial class SourcesPageInicio
    {
        [FindsBy(How = How.Id, Using = "//div[@class='overlay-walkthought-tooltip'][@id='tooltip-walkthrough']")]
        public string _query_click_on_screen { get; set; }

        [FindsBy(How = How.Id, Using = "//header[contains(@class, 'main-header')]//button[@class='header-top-search-icon set-search']")]
        public string _search_in_beginPage { get; set; }

        [FindsBy(How = How.Id, Using = "//header[contains(@class, 'main-header')]//div[@class='default-link ']")]
        public string _assineNet_inBegin { get; set; }

        [FindsBy(How = How.Id, Using = "//a[@class='header-menu-list-item-link active']")]
        public string _button_Inicio { get; set; }

        [FindsBy(How = How.Id, Using = "//*[@class = 'header-menu-list-item-link'][@href= '/no-ar']")]
        public string _button_noAr_header { get; set; }

        [FindsBy(How = How.Id, Using = "//*[contains(@id,'carousel-no-ar')]//button[@class='btn-play net-ico net-ico-play ']")]
        public IList<IWebElement> _liveCarroussel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[(@class='schedule-details-cover')]//div[(@class = 'wrap-play ')] //button[(@class = 'btn-play net-ico net-ico-play ')]")]
        public string _page_live_details_tnt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[(@class= 'live-acoes')]")]
        public string _noAr_inPlayer { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[(@class='hero-details-container hero-live highlights-item-container')]//div[(@class = 'wrap-play ')] //button[(@class = 'btn-play net-ico net-ico-play ')]")]
        public string _playOnBannerLive { get; set; }

        [FindsBy(How = How.Id, Using = "//div[(@class= 'poster poster-horizontal scale-center-left ')] //div[(@class= 'channel-name-container')] ")]
        public string _recomendadosCarousel { get; set; }

        [FindsBy(How = How.Id, Using = "//button[@class='btn btn-featured btn-login']")]
        public string _loginPageInicio { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='overlay-walkthought-tooltip'][@id='tooltip-walkthrough']")]
        public string _clickOnScreen { get; set; }

        [FindsBy(How = How.Id, Using = "//header[contains(@class, 'main-header')]//button[@class='header-top-search-icon set-search']")]
        public string _buttonSearch { get; set; }

        [FindsBy(How = How.Id, Using = "//header[contains(@class, 'main-header')]//div[@class='default-link ']")]
        public string _assineNetPageInicio { get; set; }

        [FindsBy(How = How.Id, Using = "//a[@class='header-menu-list-item-link active']")]
        public string _buttonHome { get; set; }

        [FindsBy(How = How.Id, Using = "//*[@class = 'header-menu-list-item-link'][@href= '/no-ar']")]
        public string _buttonNoAr { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@class='header-menu desktop-menu'] //a[@href='/programas-de-tv']")]
        public string _buttonProgramas { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@class='header-menu desktop-menu'] //a[@href='/cinema']")]
        public string _buttonCinema { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@class='header-menu desktop-menu'] //a[@href='/series']")]
        public string _buttonSeries { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@class='header-menu desktop-menu'] //a[@href='/series']")]
        public string _buttonKids { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@class='header-menu desktop-menu'] //a[@href='/now-clube']")]
        public string _buttonNowClube { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='heroBannerHome'] //a[@class='hightlight-link']")]
        public string _clickAtHerobanner { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='heroBannerHome'] //button[@class='slick-arrow btn-prev-slider']")]
        public string _previewHerobanner { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='heroBannerHome'] //button[@class='slick-arrow btn-next-slider']")]
        public string _nextHerobanner { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='heroBannerHome'] //ul[@class='now-slider-dots']")]
        public string _dotHerobanner { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='carousel-no-ar']//div[@class='content content-horizontal content-horizontal-two-row']//button[@class='btn-play ']")]
        public string _noArCarousel { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='carousel-no-ar'] /following-sibling::ol[@class='now-carousel-dots']")]
        public string _dot_noArCarousel { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='carousel-no-ar'] /following-sibling::div[@class='carousel-nav'] //button[@class='nav nav-left net-ico-arrow-left']")]
        public string _preview_noArCarousel { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='carousel-no-ar'] /following-sibling::div[@class='carousel-nav'] //button[@class='nav nav-right net-ico-arrow-right']")]
        public string _next_noArCarousel { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='carousel-continuar-assistindo'] //div[@class='box carousel-item'][2] //button[@class='btn btn-play ']")]
        public string _continuarCarousel { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='carousel-continuar-assistindo'] /following-sibling::ol[@class='now-carousel-dots']")]
        public string _dot_continuarCarousel { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='carousel-continuar-assistindo'] /following-sibling::div[@class='carousel-nav'] //button[@class='nav nav-left net-ico-arrow-left']")]
        public string _preview_continuarCarousel { get; set; }

        [FindsBy(How = How.Id, Using = "//div[@id='carousel-continuar-assistindo'] /following-sibling::div[@class='carousel-nav'] //button[@class='nav nav-right net-ico-arrow-right']")]
        public string _next_continuarCarousel { get; set; }

        /*
        string carrossel_recomendados  =  "//div[@id='carousel-recomendados']//div[@class='content content-horizontal content-horizontal-two-row']";

        string dot_recomendados = "//div[@id='carousel-continuar-recomendados'] /following-sibling::ol[@class='now-carousel-dots']";

        string preview_recomendados = "//div[@id='carousel-recomendados'] /following-sibling::div[@class='carousel-nav'] //button[@class='nav nav-left net-ico-arrow-left']";

        string next_recomendados = "//div[@id='carousel-recomendados'] /following-sibling::div[@class='carousel-nav'] //button[@class='nav nav-right net-ico-arrow-right']";

        string carrossel_canais = "//div[@id='carousel-canais']//div[@class='content content-horizontal content-horizontal-two-row']";

        string carrossel_novidades = "//div[@id='carousel-novidades']//div[@class='content content-horizontal content-horizontal-two-row']";

        string carrossel_conteudos_degustação = "//div[@id='carousel-contedos-em-degustao']//div[@class='content content-horizontal content-horizontal-two-row']";

        string carrossel_lancamentos = "//div[@id='carousel-lanamentos'] /descendant-or-self:: *[@class='content content-vertical']";

        string carrossel_lançamentos_em_promocao = "//div[@id='carousel-lanamentos-em-promoo'] //div[@class='content content-horizontal content-horizontal-two-row']";
        
        string dots_lancamentos_em_promocao = "//div[@id='carousel-lanamentos-em-promoo'] /following-sibling::ol[@class='now-carousel-dots']";

        string carrossel_disponivel_compra = "//div[@id='carousel-filmes-disponveis-para-compra'] //div[@class='content content-horizontal content-horizontal-two-row']";

        string carrossel_series = "//div[@id='carousel-sries'] //div[@class='content content-horizontal content-horizontal-two-row']";

        string carrossel_programas_de_TV = "//div[@id='carousel-programas-de-tv'] //div[@class='content content-horizontal content-horizontal-two-row']";
        
        string dots_programas_de_TV = "//div[@id='carousel-programas-de-tv'] /following-sibling::ol[@class='now-carousel-dots']";

        string carrossel_musica = "//div[@id='carousel-msica'] //div[@class='content content-horizontal content-horizontal-two-row']";
        
        string dots_musica = "//div[@id='carousel-msica'] /following-sibling::ol[@class='now-carousel-dots']";

        string carrossel_personagens = "//div[@id='carousel-personagens'] //div[@class='content content-horizontal content-horizontal-two-row']";
        
        string dots_personagens = "//div[@id='carousel-personagens'] /following-sibling::ol[@class='now-carousel-dots']";

        string carrossel_kids = "//div[@id='carousel-kids'] //div[@class='content content-horizontal content-horizontal-two-row']";
        
        string dots_kids = "//div[@id='carousel-kids'] /following-sibling::ol[@class='now-carousel-dots']";

        string carrossel_HBO = "//div[@id='carousel-hbo'] //div[@class='content content-horizontal content-horizontal-two-row']";
        
        string dots_HBO = "//div[@id='carousel-hbo'] /following-sibling::ol[@class='now-carousel-dots']";

        string carrossel_Telecine = "//div[@id='carousel-telecine'] //div[@class='content content-horizontal content-horizontal-two-row']";
        
        string dots_Telecine = "//div[@id='carousel-telecine'] /following-sibling::ol[@class='now-carousel-dots']";

        string carrossel_variedades = "//div[@id='carousel-variedades'] //div[@class='content content-horizontal content-horizontal-two-row']";
        
        string dots_variedades = "//div[@id='carousel-variedades'] /following-sibling::ol[@class='now-carousel-dots']";

        // Página No-Ar

        // Play no herobanner
        string play_hero_live = "//div[@class='highlights hero-banner-list']//div[@class='highlights-metadata highlights-metadata-live']/preceding::button[@class='btn-play ']";


        // Hero banner lateral (Lista)
        string play_mini_hero_live = "//section[@class='page  no-highlight'] //div[@class='highlights hero-banner-list'] //ul[@class='hero-banner-list-itens'] //button[@class='btn-play ']";

        // Dia Hoje no EPG

        string button_hoje_epg = "//div[@class='epg-header']//ul[@class='list-days']//button[contains(text(),'HOJE')]";
        string button_days = "//div[@class='epg-header']//ul[@class='list-days']";

        string channel_epg = "//div[@class='epg-container'] //section[@class='program-list-live-container'] //div[@class='left-column']//div[@class='channel-cell']";

        string previous_time_epg = "//div[@class='epg-container'] //section[@class='program-list-live-container'] //div[@class='right-column']//button[@class='btn-nav-prev']";
        string next_time_epg = "//div[@class='epg-container'] //section[@class='program-list-live-container'] //div[@class='right-column']//button[@class='btn-nav-next']";

        string program_list_epg = "//div[@class='epg-container'] //section[@class='program-list-live-container'] //div[@class='right-column']//div[@class='cell']";
        string program_live_epg = "//div[@class='epg-container'] //section[@class='program-list-live-container'] //div[@class='right-column']//div[@class='cell']//div[@class[contains(.,'live')]]";
        string button_assista_epg = "//div[@class='epg-container'] //section[@class='program-list-live-container'] //div[@class='right-column']//div[@class='cell']//div[@class[contains(.,'live')]]//i[@class='net-ico net-ico-left net-ico-play']";
        string button_startover_epg = "//div[@class='epg-container'] //section[@class='program-list-live-container'] //div[@class='right-column']//div[@class='cell']//div[@class[contains(.,'live')]]//i[@class='net-ico net-ico-start-over']";
        string filtro_epg_genero = "//div[@class='epg-header'] //div[@class='epg-filter']//span[@class='select-label-text'][contains(.,'Gênero')]";
        string filtro_epg_ordem = "//div[@class='epg-header'] //div[@class='epg-filter']//span[@class='select-label-text'][contains(.,'Ordem')]";
        string busca_epg = "//div[@class='epg-header'] //div[@class='epg-filter-wrapper']//div[@class='epg-search-input-box']";
        string button_agora_epg = "//div[@class='epg-container']//button[@class='btn-now']";
        string 

        
        * ***********
        * *********
        * *********
        * X-path Geral para Dots da maioria das páginas = ("//main[@role='main'] //div[@class='overflow-container'] //div[contains(.,'NOME_DO_CARROSSEL_BEM_ESPECIFICO')] //ol[@class='now-carousel-dots']")
                    
        Carrossel Kids diminuido = $x("//div[@id = 'carousel-kids'] //div[@class='container-items'] /descendant-or-self:: *[@class='content content-horizontal content-horizontal-two-row']")

        Lista de todos os carrosséis da página início  =  ("//*[@class='carousel-container  ']")

        Como escrever uma busca bacana = $x("//div[@id [contains(., 'sucessos')]]")

        CSS SELECTOR DOTS Carrossel Variedades = "div > #carousel-variedades ~ ol.now-carousel-dots li:nth-child(1)";

        

        */
    }
}
