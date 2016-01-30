﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "updatedPropertyDetails", Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd", IsNullable = false)]
    public partial class UpdatedPropertyDetailsResults : Results
    {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "request", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UpdatedPropertyDetailsRequest Request
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "response", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UpdatedPropertyDetailsResponse Response
        {
            get;
            set;
        }
    }
}
