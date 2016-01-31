using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Katonk.RealEstate.Redfin
{
    [XmlRoot("RDF", Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
    public class Rdf
    {
        [XmlElement("channel", Namespace = "http://purl.org/rss/1.0/")]
        public Channel Channel
        {
            get;
            set;
        }

        [XmlElement("item", Namespace = "http://purl.org/rss/1.0/")]
        public Item[] Items
        {
            get;
            set;
        }
    }
}
