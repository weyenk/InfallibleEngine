using System;
using System.Text;
using System.Collections.Generic;

using OpenQA.Selenium;
using NUnit.Framework;
using InfallibleEngine;

namespace unitTest{

    [TestFixture]
    public class program{

        Engine eng = new Engine();
        private IWebDriver driver;

        [SetUp]
        public void setup()
        {
            eng = new Engine();
        }

        [Test]
        public void Atest()
        {
            driver.Url = "https://duckduckgo.com";
            Tuple<string, string> nana = new Tuple<string, string>("tagname", "a");
            var ListofNanas = new List<Tuple<string, string>>();
            //ListofNanas.Add(Tuple<string, string>("tagname", "a"));
            ListofNanas.Add(nana);

            eng.GetWebElement(ListofNanas, driver);    
        }
    }

}