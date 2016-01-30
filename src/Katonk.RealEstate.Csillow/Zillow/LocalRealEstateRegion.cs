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
    [System.Xml.Serialization.XmlTypeAttribute("LocalRealEstateRegion", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class LocalRealEstateRegion
    {
        [System.Xml.Serialization.XmlElementAttribute("zindexValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ZindexValue
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("zindexOneYearChange", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal ZindexOneYearChange
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("links", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LocalRealEstateRegionLinks Links
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public int Id
        {
            get;
            set;
        }
    }
}
