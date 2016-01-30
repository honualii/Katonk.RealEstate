using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DetailedProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableProperty))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Property", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Property
    {
        [System.Xml.Serialization.XmlElementAttribute("zpid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ZpId
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("links", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Links Links
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("address", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Address Address
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("FIPScounty", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Fipscounty
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("useCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UseCode
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("taxAssessmentYear")]
        public DateTime? TaxAssessmentYear
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("taxAssessment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal TaxAssessment
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("yearBuilt")]
        public DateTime? YearBuilt
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("lotSizeSqFt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal LotSizeSqFt
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("finishedSqFt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal FinishedSqFt
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("bathrooms", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Bathrooms
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("bedrooms", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Bedrooms
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("totalRooms", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal TotalRooms
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("lastSoldDate")]
        public DateTime? LastSoldDate
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("lastSoldPrice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Amount LastSoldPrice
        {
            get;
            set;
        }
    }
}
