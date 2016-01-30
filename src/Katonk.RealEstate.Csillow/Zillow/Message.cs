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
    [System.Xml.Serialization.XmlTypeAttribute("Message", Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Message
    {
        public Message()
        {
            this.LimitWarning = true;
        }

        [System.Xml.Serialization.XmlElementAttribute("text", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("code", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string Code
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("limit-warning", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool LimitWarning
        {
            get;
            set;
        }
    }
}
