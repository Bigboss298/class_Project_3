namespace CLH.Models
{
    public class User : BaseEntity
    {
        public string Name{get; set;}
        public string Email{get; set;}
        public string Password{get; set;}
        public string AddressId{get; set;}
        public string PhoneNumber{get; set;}
        public Gender Gender{get; set;}
        public List<UserRole> UserRoles{get; set;}
        
    }
}