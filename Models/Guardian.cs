namespace CLH.Models
{
    public class Guardian : BaseEntity
    {
        public string UserId{get; set;}
        public string GuardianNumber{get; set;}
        public List<Student> Students{get; set;}
    }
}