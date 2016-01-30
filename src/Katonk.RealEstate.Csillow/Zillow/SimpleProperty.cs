using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DetailedProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableProperty))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("SimpleProperty", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class SimpleProperty : Property
    {
        [System.Xml.Serialization.XmlElementAttribute("zestimate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Zestimate Zestimate
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("rentzestimate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Zestimate Rentzestimate
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("region", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public LocalRealEstateRegion[] LocalRealEstate
        {
            get;
            set;
        }
    }
}
