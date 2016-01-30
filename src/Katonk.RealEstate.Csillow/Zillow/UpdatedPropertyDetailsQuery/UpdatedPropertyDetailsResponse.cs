using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.UpdatedPropertyDetailsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("updatedPropertyDetailsResponse", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
    public partial class UpdatedPropertyDetailsResponse
    {
        [System.Xml.Serialization.XmlElementAttribute("zpid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ZpId
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("pageViewCount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PageViewCount PageViewCount
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

        [System.Xml.Serialization.XmlElementAttribute("listing", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Listing Listing
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("price", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Price
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

        [System.Xml.Serialization.XmlElementAttribute("images", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Images Images
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("editedFacts", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EditedFacts EditedFacts
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("homeDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HomeDescription
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("whatOwnerLoves", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WhatOwnerLoves
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("neighborhood", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Neighborhood
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("schoolDistrict", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SchoolDistrict
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("elementarySchool", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ElementarySchool
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("middleSchool", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MiddleSchool
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("highSchool", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HighSchool
        {
            get;
            set;
        }
    }
}
