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
    [System.Xml.Serialization.XmlTypeAttribute("DetailedProperty", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class DetailedProperty : SimpleProperty
    {
        [System.Xml.Serialization.XmlElementAttribute("regions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Regions Regions
        {
            get;
            set;
        }
    }
}
