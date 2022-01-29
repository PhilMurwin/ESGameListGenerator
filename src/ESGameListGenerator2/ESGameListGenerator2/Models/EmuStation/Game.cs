using System.Xml.Serialization;

namespace ESGameListGenerator2.Models.EmuStation
{
    [XmlRoot(ElementName = "game")]
    [Serializable]
    public class Game
    {
        [XmlElement(ElementName = "path")]
        public string Path { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "desc")]
        public string Desc { get; set; }

        [XmlElement(ElementName = "image")]
        public string Image { get; set; }

        [XmlElement(ElementName = "rating")]
        public string Rating { get; set; }

        [XmlElement(ElementName = "releasedate")]
        public string Releasedate { get; set; }

        [XmlElement(ElementName = "developer")]
        public string Developer { get; set; }

        [XmlElement(ElementName = "publisher")]
        public string Publisher { get; set; }

        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }

        [XmlElement(ElementName = "players")]
        public string Players { get; set; }

        [XmlElement(ElementName = "playcount")]
        public string Playcount { get; set; }

        [XmlElement(ElementName = "lastplayed")]
        public string Lastplayed { get; set; }
    }
}
