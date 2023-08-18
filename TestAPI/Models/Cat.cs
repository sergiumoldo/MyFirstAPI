using TestAPI.Enums;

namespace TestAPI.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EyeColors EyeColor { get; set; }
        public Owner Owner { get; set; }

        public Cat(int id, string name, EyeColors eyeColor, Owner owner)
        {
            Id = id;
            Name = name;
            EyeColor = eyeColor;
            Owner = owner;
        }
    }


}
//add Owner class type for the Cat

