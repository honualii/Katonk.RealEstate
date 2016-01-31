using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Katonk.RealEstate.Redfin
{
    [Serializable]
    [XmlType("channel", Namespace = "http://purl.org/rss/1.0/")]
    public class Channel
    {
        [XmlAttribute("about", Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
        public string About
        {
            get;
            set;
        }

        [XmlElement("title")]
        public string Title
        {
            get;
            set;
        }

        [XmlElement("link")]
        public string Link
        {
            get;
            set;
        }

        [XmlElement("description")]
        public string Description
        {
            get;
            set;
        }
    }
}
