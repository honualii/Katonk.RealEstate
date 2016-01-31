using Katonk.RealEstate.Zillow;
using Katonk.RealEstate.Zillow.CompsQuery;
using Katonk.RealEstate.Zillow.SearchResultsQuery;
using Katonk.RealEstate.Zillow.UpdatedPropertyDetailsQuery;
using Katonk.RealEstate.Zillow.ZestimateQuery;
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

        #region Home Valuation API hhttp://www.zillow.com/howto/api/HomeValuationAPIOverview.htm

        public async Task<SimpleProperty[]> GetSearchResultsAsync(string address, string cityStateZip, bool includeRentZestimate = false)
        {
            string urlFormat = "http://www.zillow.com/webservice/GetSearchResults.htm?zws-id={0}&address={1}&citystatezip={2}&rentzestimate={3}";
            string url = String.Format(urlFormat, this.ZwsId, address, cityStateZip, includeRentZestimate);

            SearchResultsResults results = await GetResultsAsync<SearchResultsResults>(new Uri(url));

            return results.Response.Properties;
        }

        public async Task<DetailedProperty> GetZestimateAsync(int zpId)
        {
            string urlFormat = "http://www.zillow.com/webservice/GetZestimate.htm?zws-id={0}&zpid={1}";
            string url = String.Format(urlFormat, this.ZwsId, zpId);

            ZestimateResults results = await GetResultsAsync<ZestimateResults>(new Uri(url));

            return results.DetailedProperty;
        }

        public async Task<Properties> GetCompsAsync(int zpId, int count)
        {
            string urlFormat = "http://www.zillow.com/webservice/GetComps.htm?zws-id={0}&zpid={1}&count={2}";
            string url = String.Format(urlFormat, this.ZwsId, zpId, count);

            CompsResults results = await GetResultsAsync<CompsResults>(new Uri(url));

            return results.Response.Properties;
        }

        #endregion

        #region Property Details API http://www.zillow.com/howto/api/PropertyDetailsAPIOverview.htm

        public async Task<SimpleProperty[]> GetDeepSearchResultsAsync(string address, string cityStateZip, bool includeRentZestimate = false)
        {
            string urlFormat = "http://www.zillow.com/webservice/GetDeepSearchResults.htm?zws-id={0}&address={1}&citystatezip={2}&rentzestimate={3}";
            string url = String.Format(urlFormat, this.ZwsId, address, cityStateZip, includeRentZestimate);

            SearchResultsResults results = await GetResultsAsync<SearchResultsResults>(new Uri(url));

            return results.Response.Properties;
        }

        public async Task<Properties> GetDeepCompsAsync(int zpId, int count, bool includeRentZestimate = false)
        {
            string urlFormat = "http://www.zillow.com/webservice/GetDeepComps.htm?zws-id={0}&zpid={1}&count={2}&rentzestimate={3}";
            string url = String.Format(urlFormat, this.ZwsId, zpId, count, includeRentZestimate);

            CompsResults results = await GetResultsAsync<CompsResults>(new Uri(url));

            return results.Response.Properties;
        }

        public async Task<UpdatedPropertyDetailsResponse> GetUpdatedPropertyDetailsAsync(int zpId)
        {
            string urlFormat = "http://www.zillow.com/webservice/GetUpdatedPropertyDetails.htm?zws-id={0}&zpid={1}";
            string url = String.Format(urlFormat, this.ZwsId, zpId);

            UpdatedPropertyDetailsResults results = await GetResultsAsync<UpdatedPropertyDetailsResults>(new Uri(url));

            return results.Response;
        }

        #endregion

        protected async Task<T> GetResultsAsync<T>(Uri address) where T : Results
        {
            Task<T> task;
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type: application/x-www-form-urlencoded");
                client.Headers.Add("User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.56 Safari/536.5");
                client.Headers.Add("Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
                client.Headers.Add("Accept-Encoding: identity");
                client.Headers.Add("Accept-Language: en-US,en;q=0.8");
                client.Headers.Add("Accept-Charset: ISO-8859-1,utf-8;q=0.7,*;q=0.3");

                task = client.DownloadStringTaskAsync(address).ContinueWith(result =>
                {
                    T searchResults;
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    byte[] bytes = Encoding.UTF8.GetBytes(result.Result);
                    using (MemoryStream stream = new MemoryStream(bytes))
                    {
                        searchResults = serializer.Deserialize(stream) as T;
                    }

                    if (searchResults.Message.Code != 0)
                    {
                        throw CsillowException.FromCode(searchResults.Message.Code);
                    }

                    return searchResults;
                });
            }

            return await task;
        }
    }
}
