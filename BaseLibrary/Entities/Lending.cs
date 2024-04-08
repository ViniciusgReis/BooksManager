using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.AppConsole.Entities
{
    public class Lending
    {
        public Lending(int id, int idUser, int idBook)
        {
            Id = id;
            IdUser = idUser;
            IdBook = idBook;
            DateLending = DateTime.Now;
        }

        public int Id { get; private set; }
        public int IdUser { get; private set; }
        public int IdBook { get; private set; }
        public DateTime DateLending { get; private set; }
        
    }
}
