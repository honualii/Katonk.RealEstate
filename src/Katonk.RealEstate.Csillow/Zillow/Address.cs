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
    [System.Xml.Serialization.XmlTypeAttribute("Address", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Address
    {
        [System.Xml.Serialization.XmlElementAttribute("street", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Street
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("zipcode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZipCode
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("city", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string City
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("state", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string State
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("latitude", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Latitude
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("longitude", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Longitude
        {
            get;
            set;
        }
    }
}
