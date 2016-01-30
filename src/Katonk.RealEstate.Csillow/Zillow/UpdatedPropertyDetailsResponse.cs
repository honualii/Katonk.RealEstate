using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("updatedPropertyDetailsResponse", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
    public partial class UpdatedPropertyDetailsResponse
    {
        [System.Xml.Serialization.XmlElementAttribute("zpid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ZpId
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("pageViewCount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PageViewCount PageViewCount
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("address", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Address Address
        {
            get;
            set;
        }
    }
}
