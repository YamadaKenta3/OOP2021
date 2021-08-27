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
                                        .OrderBy(x =>((int)x.Element("firstplayed")));
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
            
        }
    }
}
