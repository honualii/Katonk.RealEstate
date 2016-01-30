using Katonk.RealEstate.Zillow;
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
            program.RunAsync(args[0]).Wait();
        }

        async Task RunAsync(string zwsId)
        {
            Csillow csillow = new Csillow(zwsId);
            SimpleProperty[] properties = await csillow.GetSearchResultsAsync("2114 Bigelow Ave", "Seattle, WA");

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

                UpdatedPropertyDetailsResponse updatedPropertyDetails = await csillow.GetUpdatedPropertyDetails(property.ZpId);
                Console.WriteLine(updatedPropertyDetails.PageViewCount.CurrentMonth);
            }
        }
    }
}
