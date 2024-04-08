namespace GerenciadorLivros.AppConsole.Entities
{
    public class User
    {
        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            IsDeleted = false;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool IsDeleted { get; private set; }

        public override string ToString()
        {
            return string.Format("Id: {0} \nName: {1} \nEmail: {2} " +
                "\n-------------------------------------", Id, Name, Email);
        }
    }
}
