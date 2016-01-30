using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.UpdatedPropertyDetailsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("links", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
    public partial class Links
    {
        [System.Xml.Serialization.XmlElementAttribute("homeDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HomeDetails
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("photoGallery", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PhotoGallery
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("homeInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HomeInfo
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("ownersEstimate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OwnersEstimate
        {
            get;
            set;
        }
    }
}
