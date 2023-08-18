namespace TestAPI.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Owner(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
