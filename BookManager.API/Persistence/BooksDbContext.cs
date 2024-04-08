using BaseLibraryData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorLivros.API.Persistence
{
    public class BooksDbContext
    {
        public List<Book> Books { get; set; }

        public BooksDbContext()
        {
            Books = new List<Book>()
                    {
                        new Book(1,"Rosas Azuis","Jose","1234", 2015, Gender.Romance, false),
                        new Book(2,"Rosas Pretas","Jose","1234", 2016, Gender.Romance, false),
                        new Book(3,"Mesa Amarela","Pedro","25487", 2010, Gender.Drama, false),
                        new Book(4,"AspNet Core 2","Joao","6548", 2017, Gender.Academic, false)
                    };
        }
    }
}
