using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.UpdatedPropertyDetailsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("listing", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
    public partial class Listing
    {
        [System.Xml.Serialization.XmlElementAttribute("status", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Status
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Type
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("lastUpdatedDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DateTime? LastUpdatedDate
        {
            get;
            set;
        }
    }
}
