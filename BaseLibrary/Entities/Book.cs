using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.AppConsole.Entities
{
    public class Book
    {
        public Book(int id, string title, string author, string isbn, int yearPublication, Gender gender)
        {
            Id = id;
            Title = title;
            Author = author;
            Isbn = isbn;
            YearPublication = yearPublication;
            Gender = gender;
            isDeleted = false;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Isbn { get; private set; }
        public int YearPublication { get; private set; }
        public Gender Gender { get; private set; }
        public bool isDeleted { get; private set; }

        public override string ToString()
        {
            return string.Format("Title: {0} \nAuthor: {1} \nISBN: {2} \nYear of publication: {3} \nGender: {4}" +
                "\n------------------------------------------", Title, Author, Isbn, YearPublication, Gender.ToString());
        }

        public void Delete()
        {
            isDeleted = true;
        }
    }

    public enum Gender
    {
        Biography = 1,
        Romance = 2,
        Academic = 3,
        SelfHelp = 4,
        Drama = 5
    }
}
