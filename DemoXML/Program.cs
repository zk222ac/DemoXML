using System;
using System.Text;
using System.Xml;

namespace DemoXML
{
   class Program
   {
       static void Main(string[] args)
       {
           // If you enable this code 
           XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
           //XmlReader xmlReader = XmlReader.Create("AmbAir18022016.xml");
           while (xmlReader.Read())
           {
               // .........ON and OFF this lines of code.....................................................

               if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Cube"))
               {
                   if (xmlReader.HasAttributes)
                   {
                       Console.WriteLine(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));

                   }
               }
               
               // .........ON and OFF this lines of code.....................................................
               //if ((xmlReader.NodeType == XmlNodeType.Element))
               //{
               //    if (xmlReader.Name == "Maalested")
               //        Console.WriteLine(xmlReader.ReadInnerXml());
               //    if (xmlReader.Name == "StofNavn")
               //       Console.WriteLine(xmlReader.ReadInnerXml());
               //    if (xmlReader.Name == "RaaResultat")
               //        Console.WriteLine(xmlReader.ReadInnerXml());
               //}
           }

           Console.ReadKey();
       }
   }
}

