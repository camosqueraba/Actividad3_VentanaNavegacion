using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VentanaNavegacion.Robot.Pages
{
    public class PosiblesClientesPage: Base
    {
        By RegistroPrimerCliente = By.XPath("//*[@id=\"main\"]/div[3]/div[2]/table/tbody/tr[1]/td[2]");

        By NumeroClientesSpan = By.ClassName("total-count-span");

        int NumeroClientes { get; set; }


        public PosiblesClientesPage(IWebDriver driver) : base(driver)
        {

        }

        public int GetNumeroClientes()
        {
            int numeroClientes;

            string strNumeroClientesSpan = GetText(NumeroClientesSpan);

            if (Int32.TryParse(strNumeroClientesSpan, out  numeroClientes))
            {
                Console.WriteLine("Numero de clientes {0}", numeroClientes);
            }
            else
            {
                Console.WriteLine("Error conviertiendo a int.");
            }
            return numeroClientes;
        }


    }
}
