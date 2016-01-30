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
    [System.Xml.Serialization.XmlTypeAttribute("searchresultsResponse", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd")]
    public partial class SearchResultsResponse
    {
        [System.Xml.Serialization.XmlArrayAttribute("results", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("result", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public SimpleProperty[] Properties
        {
            get;
            set;
        }
    }
}
