using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.CompsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("properties", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/Comps.xsd")]
    public partial class Properties
    {
        [System.Xml.Serialization.XmlElementAttribute("principal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimpleProperty Principal
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlArrayAttribute("comparables", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("comp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public ComparableProperty[] Comps
        {
            get;
            set;
        }
    }
}
