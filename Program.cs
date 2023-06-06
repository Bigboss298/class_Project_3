// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using CLH.Data;
using CLH.Repository;
using CLH.Services;



var number = 22;
var street = "Alogi";
var city = "Abk";
var state = "Ogun";

var id = "a78";

var db = new DBContext();
db.Connection();
AddressRepository addr = new AddressRepository(db);
//addr.CreateAddressTable();

AddressService add = new AddressService(addr);

add.Create(number,street,city, state);
add.GetAll();




