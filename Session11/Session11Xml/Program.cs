using System;
using System.IO;
using System.Xml;

namespace Session11Xml
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument document = new XmlDocument();

            document.Load("Template.xml");

            // Loopa hela Xml-filen
            foreach (XmlElement productElement in document.DocumentElement.ChildNodes)
            {
                foreach (XmlElement propertyElement in productElement.ChildNodes)
                {
                    foreach (XmlNode innerElement in propertyElement.ChildNodes)
                    {
                        if (innerElement.HasChildNodes) continue;

                        if (propertyElement.Name == "Id")
                        {
                            // Läsa av egenskapen id
                            string value = innerElement.Value;

                            // Ändra egenskapen id
                            innerElement.Value = "New id";
                        }
                    }
                }
            }

            using (Stream stream = new FileStream("Template.xml", FileMode.Open, FileAccess.Read))
            {
                document.Load(stream);
            }

            // Skapa ett element
            XmlElement element = document.CreateElement("NewElement");

            // Sätt den inre texten
            element.InnerText = "My new value";

            // Lägg till elementet sist bland dokumentets barn.
            document.DocumentElement.AppendChild(element);



        }
    }
}
