using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate
{

    [Serializable]
    public class CsillowException : Exception
    {
        public CsillowException()
        {
        }

        public CsillowException(string message, string resolution) : base(message)
        {
            this.Resolution = resolution;
        }

        public CsillowException(string message, string resolution, Exception inner) : base(message, inner)
        {
            this.Resolution = resolution;
        }

        protected CsillowException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public string Resolution
        {
            get;
            private set;
        }

        public static CsillowException FromCode(int code)
        {
            CsillowException exception;

            switch (code)
            {
                case 1:
                    exception = new CsillowException("Service error-there was a server-side error while processing the request", "Check to see if your url is properly formed: delimiters, character cases, etc.");
                    break;
                case 2:
                    exception = new CsillowException("The specified ZWSID parameter was invalid or not specified in the request", "Check if you have provided a ZWSID in your API call. If yes, check if the ZWSID is keyed in correctly. If it still doesn't work, contact Zillow to get help on fixing your ZWSID.");
                    break;
                case 3:
                    exception = new CsillowException("Web services are currently unavailable", "The Zillow Web Service is currently not available. Please come back later and try again.");
                    break;
                case 4:
                    exception = new CsillowException("The API call is currently unavailable", "The Zillow Web Service is currently not available. Please come back later and try again.");
                    break;
                case 500:
                    exception = new CsillowException("Invalid or missing address parameter", "Check if the input address matches the format specified in the input parameters table. When inputting a city name, include the state too. A city name alone will not result in a valid address.");
                    break;
                case 501:
                    exception = new CsillowException("Invalid or missing citystatezip parameter", "Check if the input address matches the format specified in the input parameters table. When inputting a city name, include the state too. A city name alone will not result in a valid address.");
                    break;
                case 502:
                    exception = new CsillowException("No results found", "Sorry, the address you provided is not found in Zillow's property database.");
                    break;
                case 503:
                    exception = new CsillowException("Failed to resolve city, state or ZIP code", "Please check to see if the city/state you entered is valid. If you provided a ZIP code, check to see if it is valid.");
                    break;
                case 504:
                    exception = new CsillowException("No coverage for specified area", "The specified area is not covered by the Zillow property database. To see our property coverage tables, click here.");
                    break;
                case 505:
                    exception = new CsillowException("Timeout", "Your request timed out. The server could be busy or unavailable. Try again later.");
                    break;
                case 506:
                    exception = new CsillowException("Address string too long", "If address is valid, try using abbreviations.");
                    break;
                case 507:
                    exception = new CsillowException("No exact match found.", "Verify that the given address is correct.");
                    break;
                default:
                    throw new CsillowException("Unknown message code.", "");
            }

            return exception;
        }
    }
}
