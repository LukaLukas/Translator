using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;

namespace Translator
{
    /// <summary>
    /// Summary description for TranslateWebService
    /// </summary>
    [WebService(Namespace = "http://luka.com/webservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TranslateWebService : System.Web.Services.WebService
    {
       
        [WebMethod(Description ="This method returns translated sentence")]
        public string Translate(string sentence)
        {
            string[] wordList = sentence.Split(' '); // makes an array of words
            string returnValue = "";
            Dictionary<string, string> dictionary = returnDictionary(); // read every input-output value from dictionary.xml file

            foreach(string word in wordList) // for every word of sentence
            {
                foreach(string key in dictionary.Keys)
                {
                    if (word.Trim().ToUpper().Equals(key.ToUpper())) // checking whether there is a translated value for every word of sentence
                    {
                        returnValue += " " + dictionary[key]; 
                        break;
                    }
                }
            }
            if (String.IsNullOrEmpty(returnValue))
            {
                returnValue = "doesn't have a translation"; // returns this if there is no translation for this sentence
            }

            return returnValue;
        }

        public Dictionary<string, string> returnDictionary()
        {
           
            string path3 = Server.MapPath("./dictionary.xml");
        
            Dictionary<string, string> inputWords = new Dictionary<string, string>();
            foreach (XElement wordElement in XElement.Load(path3).Elements("word")) // loops through each word element in xml file
            {
                string input = wordElement.Element("input").Value.ToString();
                string output = wordElement.Element("output").Value.ToString();
                inputWords.Add(input, output);
            }
            return inputWords;
        }
    }
}

