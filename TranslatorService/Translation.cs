using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace TranslatorService
{
    public class Translation
    {
        //string path = @"C:\Users\Lenovo\source\repos\Translator\Translator\XML\words.xml";
        //string path3 = System.Web.HttpContext.Current.Server.MapPath("./XML/words.xml");
        string path3 = HttpContext.Current.Server.MapPath("~/XML/words.xml");

        TranslatorObject obj;

        public TranslatorObject TranslateWord(string sentence)
        {
            obj = new TranslatorObject();

            if (String.IsNullOrEmpty(sentence)) //If the value is empty returns back the empty translated value
            {
                string  newWord = "";
                obj.fromText = sentence;
                obj.timeStamp = DateTime.Today;
                obj.toText = newWord;
                return obj;
            }
            else
            {
                string  toValue = "";
                bool val = checkIfExists(sentence, out toValue); 
               /*Checks whether sentenc e already exists in words.xml file
                If does, toValue variable recieves a translated value
                else writeNewElementToXml method is calling*/

                if (!val)
                {
                    writeNewElementToXml(sentence);
                    return obj;
                }
                else
                {
                    string newWord = toValue;
                    obj.fromText = sentence;
                    obj.timeStamp = DateTime.Today;
                    obj.toText = newWord;
                    return obj;
                }
            }
        }

        public void writeNewElementToXml(string sentence)
        {

            TranslatorServiceReference.TranslateWebServiceSoapClient client = new TranslatorServiceReference.TranslateWebServiceSoapClient();
            string  newWord = client.Translate(sentence); // calls the TranslateWebService which will translate the sentence
           
            obj.fromText = sentence;
            obj.timeStamp = DateTime.Now;
            obj.toText = newWord;
       
            if (!File.Exists(path3)) // if xml file does not exist, it gets created and write the values of translation object
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create(path3, xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("translations");
     
                    xmlWriter.WriteStartElement("translation");
                    xmlWriter.WriteElementString("timestamp", obj.timeStamp.ToString());
                    xmlWriter.WriteElementString("from", obj.fromText);
                    xmlWriter.WriteElementString("to", obj.toText);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else // if file already exists it appends the new translation value
            { 
                XDocument xDocument = XDocument.Load(path3);
                XElement root = xDocument.Element("translations");
                IEnumerable<XElement> rows = root.Descendants("translation");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("translation",
                   new XElement("timestamp", obj.timeStamp.ToString()),
                   new XElement("from", obj.fromText),
                   new XElement("to", obj.toText)));
                xDocument.Save(path3);
            }
        }

        public bool checkIfExists(string sentence, out string toValue)
        {
            // string path3 = System.Web.HttpContext.Current.Server.MapPath("./XML/words.xml");
            string path4 = HttpContext.Current.Server.MapPath("~/XML/words.xml");
            foreach (XElement elementTranslation in XElement.Load(path4).Elements("translation")) // loops through each translation element in words.xml file
            {
                foreach (XElement fromElement in elementTranslation.Elements("from")) // loops through each from value and checks if its value is equal to new sentence
                {
                   if (sentence.ToUpper().Trim().Equals(fromElement.Value.ToString().ToUpper().Trim())) {
                        toValue = elementTranslation.Element("to").Value.ToString();
                        return true;
                    }
                }
            }
            toValue = "";
            return false; 
        }
    }

   
}
