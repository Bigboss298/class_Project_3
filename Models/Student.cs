namespace CLH.Models
{
    public class Student : BaseEntity
    {
        public string RegistrationNumber{get; set;}
        public string UserId{get; set;}
        public string GuardianId{get; set;}
        public Guardian Guardian{get; set;}
        
       
    }
}