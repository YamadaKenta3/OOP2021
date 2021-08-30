using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Execise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("-------------");
            Exercise1_2(file);
            Console.WriteLine("-------------");
            Exercise1_3(file);
            Console.WriteLine("-------------");
            Exercise1_4(file);
            Console.WriteLine("-------------");


        }

        private static void Exercise1_4(string file)
        {


            var newfail = "sports.xml";
            var xdoc = XDocument.Load(file);
            var element = new XElement("ballsports",
                new XElement("name", "サッカー",
                new XAttribute("kanji", "蹴球")),
                new XElement("teammembers", "11"),
                 new XElement("firstplayed", "1863")
                 );
            xdoc.Root.Add(element);
            xdoc.Save(newfail);

        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            foreach (var competition in xdoc.Root.Elements())
            {
                var xname = competition.Element("name");
                var xmember = competition.Element("teammembers");
                Console.WriteLine("{0} - {1}人", xname.Value, xmember.Value);
            }

        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var competition = xdoc.Root.Elements()
                                        .OrderByDescending(x =>((int)x.Element("firstplayed")));
            foreach (var sport in competition)
            {
                var xname = sport.Element("name");
                XAttribute xkanji = xname.Attribute("kanji");
                var play = (int)sport.Element("firstplayed");

                Console.WriteLine("{0} - {1}", xkanji?.Value, play.ToString());
            }
            



        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);

            var maxmember = xdoc.Root.Elements()
                                     .Select(x => new
                                     {
                                         Name = x.Element("name").Value,
                                         Teammembers = x.Element("teammembers").Value

                                     })
                                        .OrderByDescending(x => int.Parse(x.Teammembers))
                                        .First();
            Console.WriteLine("{0}",maxmember.Name);

            
        }
        
    }
}
