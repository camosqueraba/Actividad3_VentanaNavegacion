using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanaNavegacion.Robot.Pages
{
    public class MenuPage: Base
    {
        //By LinkToPosiblesClientes = By.CssSelector("li[data-name='lead']");

        By LinkToPosiblesClientes = By.CssSelector("a[href='#Lead']");

        public MenuPage(IWebDriver driver) : base(driver)
        {

        }

        public void ClickOnPosiblesCliente()
        {
            Click(LinkToPosiblesClientes);
        }
    }
}
