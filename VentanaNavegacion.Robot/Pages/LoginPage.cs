using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanaNavegacion.Robot.Pages
{
    public class LoginPage: Base
    {
        readonly By UserNameDropdown = By.Id("field-userName");


        readonly By LanguajeFieldDropdown = By.Id("field-language");

        readonly By LoginButton = By.Id("btn-login"); 


        public LoginPage(IWebDriver driver) : base(driver)
        {

        }


        public void Login()
        {
            SelectFromDropDown(UserNameDropdown, "admin");

            SelectFromDropDown(LanguajeFieldDropdown, "es_ES");

            Click(LoginButton);
        }
    }
}
