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
    [System.Xml.Serialization.XmlTypeAttribute("Amount", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Amount
    {
        [System.Xml.Serialization.XmlAttributeAttribute("currency")]
        public Currency Currency
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public int Value
        {
            get;
            set;
        }
    }
}
