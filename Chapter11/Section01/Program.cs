using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01
{
    class Program
    {
        static void Main(string[] args)
        {

            var xdoc = XDocument.Load("novelists.xml");
           // var xelements = xdoc.Root.Elements()
              //                          .Where(x =>((DateTime)x.Element("birth")).Year >= 1900);
            //var xelements = xdoc.Root.Elements()
              //                          .OrderByDescending(x => (string)(x.Element("name").Attribute("kana")));
            
            foreach (var xnovelist in xdoc.Root.Elements())
            {

                var xname = xnovelist.Element("name");
                // var xkana = xname.Attribute("kana");
                //var xbirth = (DateTime)xnovelist.Element("birth");
                var works = xnovelist.Element("masterpieces")
                                            .Elements("title")
                                            .Select(x => x.Value);
                Console.WriteLine("{0} - {1}" ,xname.Value,string.Join(",",works));
            }
        }
    }
}
