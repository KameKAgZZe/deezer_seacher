using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace prkt.Models
{
 
        [XmlRoot(ElementName = "CD")]
        public class CD
        {
            [XmlElement(ElementName = "TITLE")]
            public string TITLE { get; set; }
            [XmlElement(ElementName = "ARTIST")]
            public string ARTIST { get; set; }
            [XmlElement(ElementName = "COUNTRY")]
            public string COUNTRY { get; set; }
            [XmlElement(ElementName = "COMPANY")]
            public string COMPANY { get; set; }
            [XmlElement(ElementName = "PRICE")]
            public string PRICE { get; set; }
            [XmlElement(ElementName = "YEAR")]
            public string YEAR { get; set; }
        }

        [XmlRoot(ElementName = "CATALOG")]
        public class CATALOG
        {
            [XmlElement(ElementName = "CD")]
            public List<CD> CD { get; set; }
        }
   
}