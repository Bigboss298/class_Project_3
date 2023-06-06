namespace CLH.Models
{
    public class Address : BaseEntity
    {
        public int Number{get; set;}
        public string Street{get; set;}
        public string City{get; set;}
        public string State{get; set;}
    }
}