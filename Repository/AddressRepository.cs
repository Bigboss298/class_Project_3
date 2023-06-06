using CLH.Data;
using CLH.Models;
using MySqlConnector;

namespace CLH.Repository
{
     public class AddressRepository
     {
          public static DBContext _context;
          public AddressRepository(DBContext context)
          {
               _context = context;
               _context.CreateAddressTable();
          }

          

          public string Create(Address address)
          {
               using (var con = _context.Connection())
               {
                    con.Open();
                    var command = new MySqlCommand($"insert into address (Id, Number, Street, City, State, IsDeleted, DateCreated) values('{address.Id}', '{address.Number}', '{address.Street}', '{address.City}', '{address.State}', '{address.IsDeleted}', '{address.DateCreated}');", con);
                    var row = command.ExecuteNonQuery();
                    if (row != -1)
                    {
                         return "Address Created Successfully!!!";
                    }
                    else
                    {
                         return "Address not created";
                    }
               }

          }
          public Address Get(string id)
          {
               using (var con = _context.Connection())
               {
                    con.Open();
                    var command = new MySqlCommand($"select * from address where Id = @id;", con);
                    command.Parameters.AddWithValue("id", id);
                    var row = command.ExecuteReader();
                    Address address = new Address();
                    while (row.Read())
                    {
                         address.Id = Convert.ToString(row[0]);
                         address.Number = Convert.ToInt32(row[1]);
                         address.Street = Convert.ToString(row[2]);
                         address.City = Convert.ToString(row[3]);
                         address.State = Convert.ToString(row[4]);
                         address.IsDeleted = Convert.ToString(row[5]);
                         address.DateCreated = Convert.ToString(row[6]);
                    }
                    return address;

               }
          }

          public List<Address> GetAll()
          {
               try
               {
                    using (var con = _context.Connection())
                    {
                         con.Open();
                         var command = new MySqlCommand($"select * from address", con);
                         var row = command.ExecuteReader();
                         List<Address> addresses = new List<Address>();
                         while (row.Read())
                         {
                              Address address = new Address();

                              address.Id = Convert.ToString(row[0]);
                              address.Number = Convert.ToInt32(row[1]);
                              address.Street = Convert.ToString(row[2]);
                              address.City = Convert.ToString(row[3]);
                              address.State = Convert.ToString(row[4]);
                              address.IsDeleted = Convert.ToString(row[5]);
                              address.DateCreated = Convert.ToString(row[6]);

                              addresses.Add(address);
                         }
                         return addresses;
                    }
               }
               catch (System.Exception)
               {

                    return null;
               }
          }

          public string Update(string id, Address address)
          {
               using (var con = _context.Connection())
               {
                    var command = new MySqlCommand($"update Address set Street = {address.Street}, City = {address.City}, Number = {address.Number} where Id = {id}", con);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("address", address);
                    var row = command.ExecuteNonQuery();
                    if (row != -1)
                    {
                         return "Update Successfull!!!";
                    }
                    else
                    {
                         return "Update not Successfull";
                    }
               }
          }
     }
}