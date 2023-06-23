using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;


namespace ReactApiRsa.Models
{
    public class Methods
    {
        public Response  Shopper (FindShopper findShopper , SqlConnection connection)
        {
            Response response = new Response ();    
            SqlCommand cmd = new SqlCommand ("INSERT INTO FindShopper(Firstname,Lastname,Username,Membername,Membernumber,Phonenumber,Zipcode,stores,Fromdate,Todate) VALUES('"+findShopper.Firstname+ "','" + findShopper.Lastname+ "','" + findShopper.Username+ "' ,'" + findShopper.Membername + "' ,'" + findShopper.Membernumber + "','" + findShopper.Phonenumber + "','" + findShopper.Zipcode + "' ,'" + findShopper.stores + "' ,'" + findShopper.Fromdate + "' ,'" + findShopper.Todate + "')", connection);
            connection.Open ();
            int i = cmd.ExecuteNonQuery();
            connection.Close ();
            
            if(i > 0)
            {
                response.Statuscode = 200;
                response.StattusMessage = "Shopper Addded SuccesFully";
            }
            else
            {
                response.Statuscode = 100;
                response.StattusMessage = "Shopper Added Failure";

            }


            return response;

        }

        public Response GetStores(SqlConnection connection)
        {
            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StoresDropdown", connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            List<StoredData> dataStores = new List<StoredData>();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    StoredData strs= new StoredData();
                    strs.value = Convert.ToInt32(dt.Rows[i]["Value"]);
                    strs.label = Convert.ToString(dt.Rows[i]["Label"]);
                    dataStores.Add(strs);
                }
                if (dataStores.Count > 0)
                {
                    response.Statuscode = 200;
                    response.StattusMessage = "Stores Data Found";
                    response.storesdata = dataStores;
                }
                else
                {
                    response.Statuscode = 100;
                    response.StattusMessage = "No Stores Data Found";
                    response.storesdata = null;
                }
            }
            else
            {
                response.Statuscode = 100;
                response.StattusMessage = "No News Data Found";
                response = null;
            }


            return response;

        }
    }
}
