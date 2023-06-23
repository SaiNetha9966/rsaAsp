namespace ReactApiRsa.Models
{
    public class FindShopper
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        public string Username { get; set;}
        public string Membername { get; set;}

        public int Membernumber { get; set;}

        public int Phonenumber { get; set; }

        public int Zipcode { get; set; }

        public string stores { get; set;}

        public  string Fromdate { get; set; }

        public string Todate { get; set; }

    }
}
