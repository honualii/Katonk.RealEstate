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
    [System.Xml.Serialization.XmlTypeAttribute("AmountOptional", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class AmountOptional
    {
        public AmountOptional()
        {
            this.Deprecated = true;
        }

        [System.Xml.Serialization.XmlAttributeAttribute("currency")]
        public Currency Currency
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlAttributeAttribute("duration")]
        public int Duration
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlAttributeAttribute("deprecated")]
        public bool Deprecated
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get;
            set;
        }
    }
}
