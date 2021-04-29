using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    public class Author
    {
        public string name = "name";
        public string biography = "biography";
        public DateTime birthDate = new DateTime(2008, 6, 1, 7, 47, 0);

        public Author(string _name, string _biography, DateTime _birthDate)
        {
            name = _name;
            biography = _biography;
            birthDate = _birthDate;
        }


        public Book Wrote()
        {
            Book newBook = new Book();

            return newBook;
        }
    }
}
