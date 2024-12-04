using System.Xml.Serialization;

namespace ClientIP.Response
{
    [XmlRoot("Response")]
    public class Response
    {
        public string State { get; set; }
        public int CheckSumZero { get; set; }
        public int CheckSumWeight { get; set; }

        [XmlElement("StaticData")]
        public StaticData StaticData { get; set; }
    }
}
