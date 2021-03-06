namespace DevInSales.Core.Entities
{
    public class User : Entity
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }

        public User(string email, string password, string name, DateTime birthDate)
        {
            Email = email;
            Password = password;
            Name = name;
            BirthDate = birthDate;
        }
        public User(int id, string email, string password, string name, DateTime birthDate)
        {
            Id = id;
            Email = email;
            Password = password;
            Name = name;
            BirthDate = birthDate;
        }   
    }
}