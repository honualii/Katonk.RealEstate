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
    [System.Xml.Serialization.XmlTypeAttribute("Zestimate", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Zestimate
    {
        [System.Xml.Serialization.XmlElementAttribute("amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Amount Amount
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("last-updated", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LastUpdated
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("oneWeekChange", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AmountOptional OneWeekChange
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("valueChange", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AmountOptional ValueChange
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("valuationRange", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ZestimateValuationRange ValuationRange
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("percentile", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Percentile
        {
            get;
            set;
        }
    }
}
