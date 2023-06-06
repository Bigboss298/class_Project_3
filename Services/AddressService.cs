using CLH.Models;
using CLH.Repository;

namespace CLH.Services
{
     public class AddressService
     {
          public static AddressRepository _addressRepository;

          public AddressService(AddressRepository addressRepository)
          {
               _addressRepository = addressRepository;
          }
          public Address Create(int number, string street, string city, string state)
          {
               Address address = new Address
               {
                    Number = number,
                    Street = street,
                    City = city,
                    State = state
               };
             var result =   _addressRepository.Create(address);
             System.Console.WriteLine(result);
             return address;


          }

          public void Get(string id)
          {
               Address asd = _addressRepository.Get(id);
               System.Console.WriteLine($"{asd.Street}, {asd.State}");
          }

          public void GetAll()
          {
               var addresses = _addressRepository.GetAll();
               foreach (var item in addresses)
               {
                    System.Console.WriteLine($"{item.Street}, {item.State}");
               }
          }

     }
}