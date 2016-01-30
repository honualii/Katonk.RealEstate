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
    [System.Xml.Serialization.XmlTypeAttribute("ZestimateValuationRange", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class ZestimateValuationRange
    {
        [System.Xml.Serialization.XmlElementAttribute("low", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Amount Low
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("high", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Amount High
        {
            get;
            set;
        }
    }
}
