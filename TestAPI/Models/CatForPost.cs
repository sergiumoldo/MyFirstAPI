using TestAPI.Enums;

namespace TestAPI.Models
{
    public class CatForPost
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public EyeColors EyeColors { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
    }
}
