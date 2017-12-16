using System;
using System.Collections.Generic;

using OpenQA.Selenium;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Core;

namespace InfallibleEngine
{
	public class Engine
	{
		private IWebDriver driver;

		public Engine ()
		{
			//TODO: Should parse the database.config file however, poc is hardcorded mongo data
		}

		public IWebElement GetWebElement(List<Tuple<string, string>> documentLocators, IWebDriver driver)
		{
            this.driver = driver;
            MongoClient client = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase db = client.GetDatabase("test1");
            IMongoCollection<PageElement> pageElementCollection = db.GetCollection<PageElement>("testObject");
            string findString = "{ ";

            foreach (Tuple<string, string> documentLocator in documentLocators)
            {
                findString += documentLocator.Item1 + ": \"" + documentLocator.Item2 + "\"";
            }
            findString += " }";

            long collectCount = pageElementCollection.Find(findString).Count();
            PageElement webPageElement = new PageElement();

            if (collectCount > 2 && collectCount < 0)
            {
                webPageElement = pageElementCollection.Find(findString).First();
            }
            else if (collectCount > 1)
            {
                Console.WriteLine("Too Many Elemenets Retrieved From Mongo");
            }
            else
            {
                Console.WriteLine("No Elements Found In Mongo");
            }


            Tuple<int, IWebElement> foundElemnetsLists;
                
            if (webPageElement.Alt != null)
            {
                IList<IWebElement> possibleElementList = FindElements("alt", webPageElement.Alt.ToString());
                if (possibleElementList != null)
                {
                    foundElemnetsLists = AddToMasterList(foundElemnetsLists, )
                }
            }
			if (webPageElement.Tagname != null)
			{
				IList<IWebElement> possibleElementList = FindElements("name", webPageElement.Tagname.ToString());
			}


            return highestConfidenceElement;

            //TODO:Use the locators to identify the elements needed in mongo
            //TODO:Use the mongo provided data to get one or many lists of matching objects
            //TODO:Determine the confidence level
            //TODO:Return the object with the highest confidenc
        }
        private IList<IWebElement> FindElements(string propertyType, string propertyValue)
        {
            IList<IWebElement> oysterPoison = driver.FindElements(By.XPath("//*[@" + propertyType + "=\"" + propertyValue + "\"]"));
            if (oysterPoison.Count != 0)
            {
                return oysterPoison;
            }
            else
            {
                return null;
            }
        }

        private Tuple<int,IWebElement> AddToMasterList(Tuple<int, IWebElement> masterList, IList<IWebElement> new_list)
        {
            
        }

        /*public List<IWebElement> GetAllWebElements(Dictionary<string, string> documentLocator, IWebDriver driver)
        {
            //TODO:Take in a dictionary of locators
            //TODO:Use the locators to identify the elements needed in mongo
            //TODO:Use the mongo provided data to get one or many lists of matching objects
            //TODO:Determine the confidence level
            //TODO:Return all the located objects
        }*/
    }
}