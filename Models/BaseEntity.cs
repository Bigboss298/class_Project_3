namespace CLH.Models
{
    public class BaseEntity
    {
        public string Id{get; set;} = Guid.NewGuid().ToString().Substring(0, 3);
        public string IsDeleted{get; set;} = false.ToString();
        public string DateCreated{get; set;} = DateTime.Now.ToString();
    }
}