﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Regions", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Regions
    {
        [System.Xml.Serialization.XmlElementAttribute("zipcode-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string ZipCodeId
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("city-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string CityId
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("county-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string CountyId
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("state-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string StateId
        {
            get;
            set;
        }
    }
}
