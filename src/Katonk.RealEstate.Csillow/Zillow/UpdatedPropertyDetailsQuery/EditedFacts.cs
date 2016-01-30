using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate.Zillow.UpdatedPropertyDetailsQuery
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("editedFacts", AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
    public partial class EditedFacts
    {
        [System.Xml.Serialization.XmlElementAttribute("useCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UseCode
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

        [System.Xml.Serialization.XmlElementAttribute("bathrooms", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Bathrooms
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

        [System.Xml.Serialization.XmlElementAttribute("lotSizeSqFt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal LotSizeSqFt
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("yearBuilt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int YearBuilt
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("yearUpdated", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int YearUpdated
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("numFloors", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int NumFloors
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("numRooms", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int NumRooms
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("basement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Basement
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("roof", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Roof
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("view", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string View
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("parkingType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ParkingType
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("coveredParkingSpaces", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int CoveredParkingSpaces
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("heatingSources", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HeatingSources
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("heatingSystem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HeatingSystem
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("coolingSystem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CoolingSystem
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("appliances", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Appliances
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("floorCovering", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FloorCovering
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("rooms", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Rooms
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("architecture", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Architecture
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("floorNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int FloorNumber
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("numUnits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int NumUnits
        {
            get;
            set;
        }
    }
}
