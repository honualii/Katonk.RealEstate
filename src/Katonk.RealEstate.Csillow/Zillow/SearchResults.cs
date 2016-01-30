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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "searchresults", Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd", IsNullable = false)]
    public partial class SearchResults : Results
    {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "request", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SearchResultsRequest Request
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "response", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SearchResultsResponse Response
        {
            get;
            set;
        }
    }
}
