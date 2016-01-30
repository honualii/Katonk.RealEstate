using Katonk.RealEstate.Zillow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Driver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.RunAsync(args[0]).Wait();
        }

        async Task RunAsync(string zwsId)
        {
            Csillow csillow = new Csillow(zwsId);
            SimpleProperty[] properties = await csillow.GetSearchResultsAsync("2114 Bigelow Ave", "Seattle, WA");

            foreach (SimpleProperty property in properties)
            {
                Console.WriteLine(property.Address.Street);
            }

            DetailedProperty detailedProperty = await csillow.GetZestimateAsync("48749425");
            Console.WriteLine(detailedProperty.Address.Street);
        }
    }
}
