using Katonk.RealEstate.Zillow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Katonk.RealEstate
{
    public class Csillow
    {
        public Csillow(string zwsid)
        {
            if (String.IsNullOrWhiteSpace(zwsid))
            {
                throw new ArgumentNullException("zwsid");
            }

            this.ZwsId = zwsid;
        }

        protected string ZwsId
        {
            get;
            private set;
        }

        public async Task<SimpleProperty[]> GetSearchResultsAsync(string address, string cityStateZip, bool returnRentZestimate = false)
        {
            string urlFormat = "http://www.zillow.com/webservice/GetSearchResults.htm?zws-id={0}&address={1}&citystatezip={2}";
            string url = String.Format(urlFormat, this.ZwsId, address, cityStateZip);

            SearchResults results = await GetResultsAsync<SearchResults>(new Uri(url));

            return results.Response.Results;
        }

        protected async Task<T> GetResultsAsync<T>(Uri address) where T : Results
        {
            Task<T> task;
            using (WebClient client = new WebClient())
            {
                task = client.DownloadStringTaskAsync(address).ContinueWith(result =>
                {
                    T searchResults;
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    byte[] bytes = Encoding.UTF8.GetBytes(result.Result);
                    using (MemoryStream stream = new MemoryStream(bytes))
                    {
                        searchResults = serializer.Deserialize(stream) as T;
                    }

                    switch (searchResults.Message.Code)
                    {
                        case "0":
                            // Request successfully processed
                            break;
                        case "1":
                            throw new CsillowException("Service error-there was a server-side error while processing the request", "Check to see if your url is properly formed: delimiters, character cases, etc.");
                        case "2":
                            throw new CsillowException("The specified ZWSID parameter was invalid or not specified in the request", "Check if you have provided a ZWSID in your API call. If yes, check if the ZWSID is keyed in correctly. If it still doesn't work, contact Zillow to get help on fixing your ZWSID.");
                        case "3":
                            throw new CsillowException("Web services are currently unavailable", "The Zillow Web Service is currently not available. Please come back later and try again.");
                        case "4":
                            throw new CsillowException("The API call is currently unavailable", "The Zillow Web Service is currently not available. Please come back later and try again.");
                        case "500":
                            throw new CsillowException("Invalid or missing address parameter", "Check if the input address matches the format specified in the input parameters table. When inputting a city name, include the state too. A city name alone will not result in a valid address.");
                        case "501":
                            throw new CsillowException("Invalid or missing citystatezip parameter", "Check if the input address matches the format specified in the input parameters table. When inputting a city name, include the state too. A city name alone will not result in a valid address.");
                        case "502":
                            throw new CsillowException("No results found", "Sorry, the address you provided is not found in Zillow's property database.");
                        case "503":
                            throw new CsillowException("Failed to resolve city, state or ZIP code", "Please check to see if the city/state you entered is valid. If you provided a ZIP code, check to see if it is valid.");
                        case "504":
                            throw new CsillowException("No coverage for specified area", "The specified area is not covered by the Zillow property database. To see our property coverage tables, click here.");
                        case "505":
                            throw new CsillowException("Timeout", "Your request timed out. The server could be busy or unavailable. Try again later.");
                        case "506":
                            throw new CsillowException("Address string too long", "If address is valid, try using abbreviations.");
                        case "507":
                            throw new CsillowException("No exact match found.", "Verify that the given address is correct.");
                        default:
                            throw new CsillowException("Unknown message code.", "");
                    }

                    return searchResults;
                });
            }

            return await task;
        }
    }
}
