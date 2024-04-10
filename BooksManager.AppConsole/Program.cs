using BaseLibraryData.Entities;
using GerenciadorLivros.AppConsole.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciadorLivros.AppConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new Manager();
            List<Book> books = new List<Book>()
            {
                new Book(1,"Rosas Azuis","Jose","1234", 2015, Gender.Romance, false),
                new Book(2,"Rosas Pretas","Jose","1234", 2016, Gender.Romance, false),
                new Book(3,"Mesa Amarela","Pedro","25487", 2010, Gender.Drama, false),
                new Book(4,"AspNet Core 2","Joao","6548", 2017, Gender.Academic, false)
            };
            List<User> users = new List<User>()
            {
                new User(1,"José Almeida", "Jose@bol.com"),
                new User(2,"João Pedro", "JPedro@gmail.com"),
                new User(3,"Bruno Almeida", "brunoalmeida123@yahoo.com.br"),
            };

            List<Lending> lendings = new List<Lending>();

            Console.WriteLine("--------------Gerenciador de Livros--------------");
            Console.WriteLine("");
            while (true)
            {
                gerenciador.ShowMenu();
                var op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        return;
                    case 1:
                        while (true)
                        {
                            gerenciador.ShowBookMenu();

                            var opBookBool = int.TryParse(Console.ReadLine(), out int opb);
                            while (!opBookBool && (opb < 0 || opb > 4))
                            {
                                Console.WriteLine("Voce digitou {0}, digite um numero valido entre 0 e 4", opb);
                                opBookBool = int.TryParse(Console.ReadLine(), out opb);
                            }
                            var opBook = opb;

                            switch (opBook)
                            {
                                case 0:
                                    break;
                                case 1:
                                    gerenciador.CreateBook(books);
                                    Continue();
                                    break;
                                case 2:
                                    gerenciador.GetAllBooks(books);
                                    Continue();
                                    break;
                                case 3:
                                    Console.WriteLine("Digite o Id do livro: ");
                                    var idBook = int.Parse(Console.ReadLine());
                                    gerenciador.GetOneBook(books, idBook);
                                    Continue();
                                    break;
                                case 4:
                                    Console.WriteLine("Digite o Id do livro: ");
                                    var idBookDel = int.Parse(Console.ReadLine());
                                    gerenciador.DeleteBook(books, idBookDel);
                                    Continue();
                                    break;
                                default:
                                    Console.WriteLine("");
                                    Console.WriteLine("Você digitou o número {0}, digite um número entre 0 e 4", opBook);
                                    break;
                            }
                            if (opBook == 0)
                            {
                                break;
                            }
                        }
                        break;

                    case 2:
                        while (true)
                        {
                            gerenciador.ShowUserMenu();
                            var opUserBool = int.TryParse(Console.ReadLine(), out int opb);
                            while (!opUserBool || opb < 0 || opb > 4)
                            {
                                Console.WriteLine("Voce digitou {0}, digite um numero valido entre 0 e 4", opb);
                                opUserBool = int.TryParse(Console.ReadLine(), out opb);
                            }
                            var opUser = opb;
                            switch (opUser)
                            {
                                case 0:
                                    break;
                                case 1:
                                    var user = gerenciador.CreateUser();
                                    gerenciador.AddUserToList(users, user);
                                    Continue();
                                    break;
                                case 2:
                                    gerenciador.GetAllUsers(users);
                                    Continue();
                                    break;
                                case 3:
                                    Console.WriteLine("Digite o Id do usuario: ");
                                    var idUser = int.Parse(Console.ReadLine());
                                    gerenciador.GetOneUser(users, idUser);
                                    Continue();
                                    break;
                                case 4:
                                    Console.WriteLine("Digite o Id do usuario: ");
                                    var idUserDel = int.Parse(Console.ReadLine());
                                    gerenciador.DeleteUser(users, idUserDel);
                                    Continue();
                                    break;
                                default:
                                    Console.WriteLine("");
                                    Console.WriteLine("Você digitou o número {0}, digite um número entre 0 e 4", opUser);
                                    break;
                            }
                            if (opUser == 0)
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            gerenciador.ShowLendingMenu();
                            var opLendBool = int.TryParse(Console.ReadLine(), out int opb);
                            while (!opLendBool || (opb < 0 || opb > 4))
                            {
                                Console.WriteLine("Voce digitou {0}, digite um numero valido entre 0 e 4", opb);
                                opLendBool = int.TryParse(Console.ReadLine(), out opb);
                            }
                            var opLending = opb;

                            switch (opLending)
                            {
                                case 0:
                                    break;
                                case 1:
                                    gerenciador.CreateLending(books, users, lendings);
                                    Continue();
                                    break;
                                case 2:
                                    gerenciador.GetAllLendings(lendings, books, users);
                                    Continue();
                                    break;
                                case 3:
                                    Console.WriteLine("Digite o Id do emprestimo: ");
                                    var idLend = int.Parse(Console.ReadLine());
                                    gerenciador.GetOneLending(lendings, books, users, idLend);
                                    Continue();
                                    break;
                                case 4:
                                    Console.WriteLine("Digite o Id do emprestimo: ");
                                    var idLendDel = int.Parse(Console.ReadLine());
                                    gerenciador.DeleteLending(lendings, idLendDel);
                                    Continue();
                                    break;
                                default:
                                    Console.WriteLine("");
                                    Console.WriteLine("Você digitou o número {0}, digite um número entre 0 e 3", opLending);
                                    break;
                            }
                            if (opLending == 0)
                            {
                                break;
                            }
                        }
                        break;
                }
            }
        }
        public static void Continue()
        {
            Console.WriteLine("Pressione enter para prosseguir");
            Console.ReadLine();
        }
    }

}
