using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.CompsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("request", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/Comps.xsd")]
    public partial class CompsRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "zpid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ZpId
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "count", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Count
        {
            get;
            set;
        }
    }
}
