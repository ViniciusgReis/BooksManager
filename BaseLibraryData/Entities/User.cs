using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibraryData.Entities
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
            return string.Format("Name: {0} \n Email: {1} ",Name,Email);
        }
    }
}
