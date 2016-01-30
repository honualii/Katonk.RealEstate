using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/Zestimate.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "zestimate", Namespace = "http://www.zillow.com/static/xsd/Zestimate.xsd", IsNullable = false)]
    public partial class ZestimateResults : Results
    {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "request", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ZestimateRequest Request
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "response", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DetailedProperty DetailedProperty
        {
            get;
            set;
        }
    }
}
