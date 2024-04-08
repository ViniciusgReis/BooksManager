using BaseLibraryData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.AppConsole.Entities
{
    public class Gerenciador
    {
        public void CreateBook(List<Book> books)
        {
            string idStr;
            int id;
            string title;
            string author;
            string isbn;
            string yearPublicationStr;
            int yearPublication;

            Console.Clear();
            while (true)
            {
                Console.WriteLine("Digite o Id: ");
                idStr = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(idStr) || !Int32.TryParse(idStr, out int n))
                {
                    Console.WriteLine("\n Número inválido!");
                    Console.WriteLine("");
                }
                else
                {
                    break;
                }

            }

            id = Int32.Parse(idStr);

            while (true)
            {
                Console.WriteLine("Digite o Titulo: ");
                title = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("\n Título vazio");
                    Console.WriteLine("");
                }
                else
                {
                    break;
                }
            }


            while (true)
            {
                Console.WriteLine("Digite o Autor: ");
                author = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("\n Nome do autor vazio");
                    Console.WriteLine("");
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Digite o ISBN");
                isbn = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("\n ISBN vazio");
                }
                else
                {
                    break;
                }
            }


            while (true)
            {
                Console.WriteLine("Digite o Ano de Publicação: ");
                yearPublicationStr = Console.ReadLine();
                int n;
                if (string.IsNullOrWhiteSpace(yearPublicationStr) || !Int32.TryParse(yearPublicationStr, out n))
                {
                    Console.WriteLine("\n Ano de publicação inválido!");
                    Console.WriteLine("");
                }
                else
                {
                    break;
                }
            }
            yearPublication = Int32.Parse(yearPublicationStr);

            Gender gender;
            while (true)
            {
                try
                {
                    Console.WriteLine("Digite o Genero: ");
                    var genderStr = Console.ReadLine();
                    gender = (Gender)Enum.Parse(typeof(Gender), genderStr);
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Genero digitado inválido, favor use um dos generos abaixo: ");
                    var listaGender = Enum.GetValues(typeof(Gender));
                    foreach (var genderItem in listaGender)
                    {
                        Console.WriteLine(genderItem);
                    }

                }
            }

            var book = new Book(id, title, author, isbn, yearPublication, gender, false);

            books.Add(book);
            Console.WriteLine("");
            Console.WriteLine("Livro adicionado à biblioteca!");
            Console.WriteLine("");

        }

        public void GetAllBooks(List<Book> allBooks)
        {
            Console.Clear();
            Console.WriteLine("----------------------Books-------------------");
            Console.WriteLine("");
            allBooks.ForEach(Console.WriteLine);
            Console.WriteLine("");
        }

        public void GetOneBook(List<Book> books, int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("O livro procurado nao existe, favor, digite um Id valido");
            }
            else
            {
                Console.WriteLine(book);
            }
        }

        public void DeleteBook(List<Book> books, int idBookDel)
        {
            var BookDel = books.SingleOrDefault(e => e.Id == idBookDel);
            books.Remove(BookDel);
            Console.WriteLine("Livro deletado!");
            Console.WriteLine("");
        }

        public User CreateUser()
        {
            string idStr;
            string name;
            string email;
            int id;

            Console.Clear();
            while (true)
            {
                Console.WriteLine("Digite o Id: ");
                idStr = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(idStr) || !Int32.TryParse(idStr, out int n))
                {
                    Console.WriteLine("\n Número inválido!");
                    Console.WriteLine("");
                }
                else
                {
                    id = Int32.Parse(idStr);
                    break;
                }

            }

            Console.WriteLine("Digite o nome do usuario: ");
            while (true)
            {
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Nome está vazio, digite um nome");
                    Console.WriteLine("");
                }
                else
                {

                    break;
                }
            }

            Console.WriteLine("Digite o Email do usuario: ");
            while (true)
            {
                email = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Email está vazio, digite um Email");
                    Console.WriteLine("");
                }
                else
                {

                    break;
                }
            }

            var user = new User(id, name, email, false);
            return user;
        }

        public void GetAllUsers(List<User> allUsers)
        {
            Console.Clear();
            Console.WriteLine("----------------------Users-------------------");
            Console.WriteLine("");
            allUsers.ForEach(Console.WriteLine);
            Console.WriteLine("");
        }

        public void GetOneUser(List<User> users, int id)
        {
            Console.Clear();
            var user = users.SingleOrDefault(b => b.Id == id);
            if (user == null)
            {
                Console.WriteLine("O usuario procurado nao existe");
            }
            else
            {
                Console.WriteLine(user);
            }
        }

        public void DeleteUser(List<User> users, int id)
        {
            Console.Clear();
            var user = users.SingleOrDefault(u => u.Id == id);
            if (user == null)
            {
                Console.WriteLine("Usuario nao existe");
            }
            else
            {
                users.Remove(user);
                Console.WriteLine("Usuario deletado!");
                Console.WriteLine("");
            }
        }

        public void AddUserToList(List<User> users, User user)
        {
            users.Add(user);
            Console.WriteLine("Usuario Adicionado!");
            Console.WriteLine("");
        }

        public void CreateLending(List<Book> books, List<User> users, List<Lending> lendings)
        {
            string idStr;
            int id;
            int idBook;
            int idUser;

            Console.Clear();
            while (true)
            {
                Console.WriteLine("Digite o Id: ");
                idStr = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(idStr) || !Int32.TryParse(idStr, out int n))
                {
                    Console.WriteLine("\n Número inválido!");
                    Console.WriteLine("");
                }
                else
                {
                    id = Int32.Parse(idStr);
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Digite o Id do usuario: ");
                idStr = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(idStr) || !Int32.TryParse(idStr, out int n))
                {
                    Console.WriteLine("\n Número inválido!");
                    Console.WriteLine("");
                }
                else
                {
                    idUser = Int32.Parse(idStr);
                    var user = users.SingleOrDefault(u => u.Id == id);
                    if (user == null)
                    {
                        Console.WriteLine("\n Usuario nao existe!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            while (true)
            {
                Console.WriteLine("Digite o Id do Livro: ");
                idStr = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(idStr) || !Int32.TryParse(idStr, out int n))
                {
                    Console.WriteLine("\n Número inválido!");
                    Console.WriteLine("");
                }
                else
                {
                    idBook = Int32.Parse(idStr);
                    var book = books.SingleOrDefault(b => b.Id == id && b.IsDeleted is false);
                    var bookLend = lendings.Any(l => l.IdBook == id);
                    if (book == null)
                    {
                        Console.WriteLine("\n Livro nao existe!");
                        Console.WriteLine("");
                    }
                    else if (bookLend)
                    {
                        Console.WriteLine("\n Livro ja esta emprestado! \nSelecione outro livro");
                    }
                    else
                    {
                        break;
                    }
                }

            }

            var lending = new Lending(id, idUser, idBook);
            lendings.Add(lending);
            Console.WriteLine("Emprestimo cadastrado!");
            Console.WriteLine("");
        }

        public void GetAllLendings(List<Lending> lendings, List<Book> books, List<User> users)
        {
            Console.Clear();
            if(!lendings.Any())
            {
                Console.WriteLine("Nenhum emprestimo efetuado");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Emprestimos efetuados");
                Console.WriteLine("");
                foreach (var lend in lendings)
                {
                    var book = books.SingleOrDefault(b => b.Id == lend.IdBook).Title;
                    var user = users.SingleOrDefault(u => u.Id == lend.IdUser).Name;
                    Console.WriteLine("Id: {0}", lend.Id);
                    Console.WriteLine("Book: {0}", book);
                    Console.WriteLine("user: {0}", user);
                    Console.WriteLine("Date Lending: {0}", lend.DateLending.ToShortDateString());
                    Console.WriteLine("Date Return: {0}", lend.DateReturn.ToShortDateString());
                }
            }
            
        }

        public void GetOneLending(List<Lending> lendings, List<Book> books, List<User> users, int id)
        {
            var lend = lendings.SingleOrDefault(l => l.Id == id);
            if(lend is null)
            {
                Console.WriteLine("O emprestimo buscado não existe no sistema");
            }
            else
            {
                var book = books.SingleOrDefault(b => b.Id == lend.IdBook).Title;
                var user = users.SingleOrDefault(u => u.Id == lend.IdUser).Name;
                Console.WriteLine("Id: {0}", lend.Id);
                Console.WriteLine("Book: {0}", book);
                Console.WriteLine("user: {0}", user);
                Console.WriteLine("Date Lending: {0}", lend.DateLending.ToShortDateString());
            }
            
        }

        public void DeleteLending(List<Lending> lendings, int id)
        {
            var lend = lendings.SingleOrDefault(l => l.Id == id);
            if(lend is null)
            {
                Console.WriteLine("O emprestimo buscado não existe");
                Console.WriteLine("");
            }
            else
            {
                lendings.Remove(lend);
                Console.WriteLine("Emprestimo cancelado");
                Console.WriteLine("");
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção abaixo");
            Console.WriteLine("1 - Menu Livros");
            Console.WriteLine("2 - Menu usuarios");
            Console.WriteLine("3 - Menu emprestimos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
        }
        public void ShowBookMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar livro");
            Console.WriteLine("2 - Consultar Todos os livros");
            Console.WriteLine("3 - Consultar um livro");
            Console.WriteLine("4 - Deletar um livro");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
        }

        public void ShowUserMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar Uusuario");
            Console.WriteLine("2 - Consultar Todos os usuarios");
            Console.WriteLine("3 - Consultar um usuario");
            Console.WriteLine("4 - Deletar um usuario");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
        }

        public void ShowLendingMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar Emprestimo");
            Console.WriteLine("2 - Consultar Todos os emprestimos");
            Console.WriteLine("3 - Consultar um emprestimo");
            Console.WriteLine("4 - Cancelar um emprestimo");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
