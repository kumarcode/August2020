﻿using August2020.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace August2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Init and define driver
            IWebDriver driver = new ChromeDriver();                 

            // Login page object init and definition
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);

            // Home page object init and definition
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // TM page object init and definition
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);

            // Edit existing TM test
            tmObj.EditTM(driver);

            // Delete existing TM test
            tmObj.DeleteTM(driver);
        }
    }
}
