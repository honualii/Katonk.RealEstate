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
    [System.Xml.Serialization.XmlTypeAttribute("LocalRealEstateRegionLinks", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class LocalRealEstateRegionLinks
    {
        [System.Xml.Serialization.XmlElementAttribute("overview", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Overview
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("forSaleByOwner", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ForSaleByOwner
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("forSale", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ForSale
        {
            get;
            set;
        }
    }
}
