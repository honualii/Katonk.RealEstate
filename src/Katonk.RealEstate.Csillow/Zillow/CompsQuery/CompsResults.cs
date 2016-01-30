using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.CompsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/Comps.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "comps", Namespace = "http://www.zillow.com/static/xsd/Comps.xsd", IsNullable = false)]
    public partial class CompsResults : Results
    {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "request", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CompsRequest Request
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "response", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CompsResponse Response
        {
            get;
            set;
        }
    }
}
