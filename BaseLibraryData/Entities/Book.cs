using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibraryData.Entities
{
    public class Book
    {
        public Book(int id, string title, string author, string iSBN, int yearPublication, Gender gender, bool IsDeleted)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
            Gender = gender;
            IsDeleted = false;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int YearPublication { get; private set; }
        public Gender Gender { get; private set; }
        public bool IsDeleted { get; private set; }

        public override string ToString()
        {
            return string.Format("Title: {0} \nAuthor: {1} \nGender: {2} \nYear of publication: {3} " +
                "\n-----------------------------------------------------------------------", Title, Author, Gender, YearPublication);
        }

        public void Delete()
        {
            IsDeleted = true;
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
