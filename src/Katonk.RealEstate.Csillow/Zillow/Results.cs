using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchResults))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ZestimateResults))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdatedPropertyDetailsResults))]
    public partial class Results
    {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "message", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Message Message
        {
            get;
            set;
        }
    }
}
