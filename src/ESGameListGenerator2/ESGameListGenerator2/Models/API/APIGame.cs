namespace ESGameListGenerator2.Models.API
{
    public class APIGame
    {
        public int id { get; set; }
        public string game_title { get; set; }
        public string release_date {get;set;}
        public int platform { get; set; }
        public int players { get; set; }
        public string overview { get; set; }
        public string last_udpated { get; set; }
        public string rating { get; set; }
        public string coop { get; set; }
        public string youtube { get; set; }
        public string os { get; set; }
        public string processor { get; set; }
        public string ram { get; set; }
        public string hdd { get; set; }
        public string video { get; set; }
        public string sound { get; set; }
    }
}
