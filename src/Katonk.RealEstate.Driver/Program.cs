using Katonk.RealEstate.Zillow;
using Katonk.RealEstate.Zillow.CompsQuery;
using Katonk.RealEstate.Zillow.UpdatedPropertyDetailsQuery;
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
            program.RunAsync(args[0], args[1]).Wait();
        }

        async Task RunAsync(string zwsId, string redfinRssUrl)
        {
            await RunCsillowAsync(zwsId);

            await RunCsedfinAsync(redfinRssUrl);
        }

        async Task RunCsillowAsync(string zwsId)
        {
            Csillow csillow = new Csillow(zwsId);
            SimpleProperty[] properties = await csillow.GetSearchResultsAsync("	3804 NE 93RD ST", "Seattle, WA");

            foreach (SimpleProperty property in properties)
            {
                Console.WriteLine(property.Address.Street);

                DetailedProperty detailedProperty = await csillow.GetZestimateAsync(property.ZpId);
                Console.WriteLine(Convert.ToInt32(detailedProperty.Zestimate.Amount.Value).ToString("c"));

                SimpleProperty[] deepSearchResults = await csillow.GetDeepSearchResultsAsync(property.Address.Street, property.Address.ZipCode);

                foreach (SimpleProperty deepSearchResult in deepSearchResults)
                {
                    Console.WriteLine(deepSearchResult.FinishedSqFt);
                }

                UpdatedPropertyDetailsResponse updatedPropertyDetails = await csillow.GetUpdatedPropertyDetailsAsync(property.ZpId);
                Console.WriteLine(updatedPropertyDetails.PageViewCount.CurrentMonth);

                Properties comps = await csillow.GetCompsAsync(property.ZpId, 5);
                Console.WriteLine(comps.Comps[0].Address.Street);

                Properties deepComps = await csillow.GetDeepCompsAsync(property.ZpId, 5);
                Console.WriteLine(deepComps.Comps[0].Address.Street);
            }
        }

        async Task RunCsedfinAsync(string redfinRssUrl)
        {
            Csedfin csedfin = new Csedfin();
            string foo = await csedfin.GetRssResults(redfinRssUrl);
        }
    }
}
