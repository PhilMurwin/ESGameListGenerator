using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace ESGameListGenerator.Models.GameDBAPI
{
    [XmlRoot( ElementName = "Platform" )]
    public class Platform
    {
        [XmlElement( ElementName = "id" )]
        public string Id { get; set; }
        [XmlElement( ElementName = "name" )]
        public string Name { get; set; }
        [XmlElement( ElementName = "alias" )]
        public string Alias { get; set; }
    }

    [XmlRoot( ElementName = "Platforms" )]
    public class Platforms
    {
        [XmlElement( ElementName = "Platform" )]
        public List<Platform> Platform { get; set; }
    }

    [XmlRoot( ElementName = "Data" )]
    public class PlatformData
    {
        [XmlElement( ElementName = "basePlatformUrl" )]
        public string BasePlatformUrl { get; set; }
        [XmlElement( ElementName = "Platforms" )]
        public Platforms Platforms { get; set; }
    }
}
