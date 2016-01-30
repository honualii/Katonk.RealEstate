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
    [System.Xml.Serialization.XmlTypeAttribute("Links", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Links
    {
        [System.Xml.Serialization.XmlElementAttribute("homedetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HomeDetails
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("graphsanddata", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GraphsAndData
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("mapthishome", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MapThisHome
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("myestimator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MyEstimator
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("myzestimator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DeprecatedType MyZestimator
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("comparables", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Comparables
        {
            get;
            set;
        }
    }
}
