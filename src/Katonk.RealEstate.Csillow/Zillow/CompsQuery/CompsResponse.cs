using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.CompsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("response", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/Comps.xsd")]
    public partial class CompsResponse
    {
        [System.Xml.Serialization.XmlElementAttribute("properties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Properties Properties
        {
            get;
            set;
        }
    }
}
