using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TranslatorService
{
    [Serializable]
    public class TranslatorObject // this is the object which will be saved to xml file
    {
        [Display(Name = "from")]
        [XmlAttribute]
        public string fromText { get; set; }

        [Display(Name = "to")]
        [XmlAttribute]
        public string toText { get; set; }

        [Display(Name = "timestamp")]
        [XmlAttribute]
        public DateTime timeStamp { get; set; }
    }
}
