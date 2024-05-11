namespace Searchfy.API
{
    public class Configuration
    {
        public Elasticsearch Elasticsearch { get; set; }
    }

    public class Elasticsearch
    {
        public string BaseURL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FingerPrint { get; set; }
    }
}
