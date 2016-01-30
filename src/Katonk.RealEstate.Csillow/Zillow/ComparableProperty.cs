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
    [System.Xml.Serialization.XmlTypeAttribute("ComparableProperty", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class ComparableProperty : SimpleProperty
    {
        [System.Xml.Serialization.XmlAttributeAttribute("score")]
        public decimal Score
        {
            get;
            set;
        }
    }
}
