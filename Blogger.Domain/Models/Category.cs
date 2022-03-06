namespace Blogger.Domain.Models
{
    public class Category : Entity
    {
        public Category()
        {

        }
        public Category(int id,string name,bool isActive)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }

        public string Name { get; set; }
    }
}
