using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("searchresultsRequest", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd")]
    public partial class SearchResultsRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "address", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Address
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "citystatezip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CityStateZip
        {
            get;
            set;
        }
    }
}
