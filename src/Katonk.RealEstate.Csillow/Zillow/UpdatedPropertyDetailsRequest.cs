using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("request", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
    public partial class UpdatedPropertyDetailsRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "zpid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ZpId
        {
            get;
            set;
        }
    }
}
