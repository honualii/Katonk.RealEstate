using Katonk.RealEstate.Redfin;
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
    public class Csedfin
    {
        public async Task<string> GetRssResults(string address)
        {
            Rdf result = await GetResultsAsync<Rdf>(new Uri(address));

            return "foo";
        }

        protected async Task<T> GetResultsAsync<T>(Uri address) where T : class
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

                    return searchResults;
                });
            }

            return await task;
        }
    }
}
