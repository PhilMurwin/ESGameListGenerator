using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace ESGameListGenerator.Models.GameDBAPI
{
    [XmlRoot( ElementName = "AlternateTitles" )]
    public class AlternateTitles
    {
        [XmlElement( ElementName = "title" )]
        public string Title { get; set; }
    }

    [XmlRoot( ElementName = "Genres" )]
    public class Genres
    {
        [XmlElement( ElementName = "genre" )]
        public string Genre { get; set; }
    }

    [XmlRoot( ElementName = "boxart" )]
    public class Boxart
    {
        [XmlAttribute( AttributeName = "side" )]
        public string Side { get; set; }
        [XmlAttribute( AttributeName = "width" )]
        public string Width { get; set; }
        [XmlAttribute( AttributeName = "height" )]
        public string Height { get; set; }
        [XmlAttribute( AttributeName = "thumb" )]
        public string Thumb { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot( ElementName = "clearlogo" )]
    public class Clearlogo
    {
        [XmlAttribute( AttributeName = "width" )]
        public string Width { get; set; }
        [XmlAttribute( AttributeName = "height" )]
        public string Height { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot( ElementName = "Images" )]
    public class Images
    {
        [XmlElement( ElementName = "boxart" )]
        public List<Boxart> Boxart { get; set; }
        [XmlElement( ElementName = "clearlogo" )]
        public Clearlogo Clearlogo { get; set; }
    }

    [XmlRoot( ElementName = "Game" )]
    public class Game
    {
        [XmlElement( ElementName = "id" )]
        public string Id { get; set; }
        [XmlElement( ElementName = "GameTitle" )]
        public string GameTitle { get; set; }
        [XmlElement( ElementName = "AlternateTitles" )]
        public AlternateTitles AlternateTitles { get; set; }
        [XmlElement( ElementName = "PlatformId" )]
        public string PlatformId { get; set; }
        [XmlElement( ElementName = "Platform" )]
        public string Platform { get; set; }
        [XmlElement( ElementName = "ReleaseDate" )]
        public string ReleaseDate { get; set; }
        [XmlElement( ElementName = "Overview" )]
        public string Overview { get; set; }
        [XmlElement( ElementName = "ESRB" )]
        public string ESRB { get; set; }
        [XmlElement( ElementName = "Genres" )]
        public Genres Genres { get; set; }
        [XmlElement( ElementName = "Players" )]
        public string Players { get; set; }
        [XmlElement( ElementName = "Co-op" )]
        public string Coop { get; set; }
        [XmlElement( ElementName = "Publisher" )]
        public string Publisher { get; set; }
        [XmlElement( ElementName = "Developer" )]
        public string Developer { get; set; }
        [XmlElement( ElementName = "Images" )]
        public Images Images { get; set; }
    }

    [XmlRoot( ElementName = "Data" )]
    public class GameData
    {
        [XmlElement( ElementName = "baseImgUrl" )]
        public string BaseImgUrl { get; set; }
        [XmlElement( ElementName = "Game" )]
        public List<Game> Game { get; set; }
    }
}
