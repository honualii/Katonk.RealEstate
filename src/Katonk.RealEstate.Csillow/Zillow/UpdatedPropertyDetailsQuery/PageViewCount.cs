using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.UpdatedPropertyDetailsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("pageViewCount", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
    public partial class PageViewCount
    {
        [System.Xml.Serialization.XmlElementAttribute("currentMonth", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int CurrentMonth
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("total", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Total
        {
            get;
            set;
        }
    }
}
