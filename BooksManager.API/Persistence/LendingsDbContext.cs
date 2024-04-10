using BaseLibraryData.Entities;
using System.Collections.Generic;

namespace GerenciadorLivros.API.Persistence
{
    public class LendingsDbContext
    {
        public List<Lending> Lendings { get; private set; }

        public LendingsDbContext()
        {
            Lendings = new List<Lending>();
        }
    }
}
