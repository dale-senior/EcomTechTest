namespace EcomTechTest.Entities
{
    public class User
    {
        public User(string name) { 
            this.Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }

    }
}
