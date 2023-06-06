using MySqlConnector;

namespace CLH.Data
{
     public class DBContext
     {
          public string connectionString = "Server = localhost; user = root; database = schoolApp; password = B!gb055";
          public MySqlConnection Connection()
          {
               return new MySqlConnection(connectionString);
          }

          public void CreateAddressTable()
          {

               using (var con = Connection())
               {
                    con.Open();
                    var command = new MySqlCommand("Create table if not exists Address(Id varchar(4), Number int, Street varchar(25), City varchar(25), State varchar(25), IsDeleted varchar(50), DateCreated varchar(150), primary key(Id));", con);
                    var row = command.ExecuteNonQuery();
                    if (row != -1)
                    {
                         System.Console.WriteLine("Table Created Successfully!!!");
                    }
                    else
                    {
                         System.Console.WriteLine("Table not created");
                    }
               }
          }

          
     }

}