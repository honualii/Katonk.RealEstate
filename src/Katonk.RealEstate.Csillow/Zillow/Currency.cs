using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Currency", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public enum Currency
    {
        USD,
    }
}
