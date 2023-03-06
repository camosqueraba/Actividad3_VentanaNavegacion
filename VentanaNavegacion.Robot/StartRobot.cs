using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using VentanaNavegacion.Robot.Pages;

namespace Actividad1_Bancolombia
{
    public class StartRobot
    {
        static void Main(string[] args)
        {
            const string URL = "https://demo.us.espocrm.com/";

            ChromeDriver driver = new ChromeDriver();

            //IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(URL);

            //WebDriverWait waitForBanner = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            

           

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login();

            

            MenuPage menuPage = new MenuPage(driver);
            menuPage.ClickOnPosiblesCliente();

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            PosiblesClientesPage posiblesClientesPage = new PosiblesClientesPage(driver);
            posiblesClientesPage.GetNumeroClientes();


        }
    }
}