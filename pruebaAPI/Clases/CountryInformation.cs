namespace pruebaAPI.Clases
{
    public class CountryInformation
    {
        public string name { get; set; }
        public string capital { get; set; }
        public string region { get; set; }
        public int population { get; set; }
        public string[] borders { get; set; }
        public Currency[] currencies { get; set; }
    }
    public class Currency
    {
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }
}