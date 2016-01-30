using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.UpdatedPropertyDetailsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("images", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
    public partial class Images
    {
        [System.Xml.Serialization.XmlElementAttribute("count", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Count
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlArrayAttribute("image", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("url", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public string[] Links
        {
            get;
            set;
        }
    }
}
