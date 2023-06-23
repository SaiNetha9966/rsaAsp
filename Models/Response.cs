namespace ReactApiRsa.Models
{
    public class Response
    {
        public int Statuscode { get; set; }

        public string StattusMessage { get; set; }

        //public List<FindShopper>  findShoppers { get; set; }

        //public FindShopper FindShopper { get; set; }
         

        public List<StoredData> storesdata { get; set; }

        //public StoredData storesdata { get; set; }
    }
}
