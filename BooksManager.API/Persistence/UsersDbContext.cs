using BaseLibraryData.Entities;
using System.Collections.Generic;

namespace GerenciadorLivros.API.Persistence
{
    public class UsersDbContext
    {
        public List<User> Users { get; set; }

        public UsersDbContext()
        {
            Users = new List<User>();
        }
    }
}
