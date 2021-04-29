using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    class Librarian
    {
        FullName name;
        Address address;
        string position;

        public Librarian()
        {
            name.firstName = "default";
            name.lastName = "default";

            address.city = "default";
            address.street = "default";
            address.postalCode = "default";

            position = "default";
        }

        /* Adds existing book(in library) to catalog
         */
        public void addBookToCatalog(Catalog _catalog, Book_Item _book)
        {
            _catalog.AddBookItem(_book);
        }

        public void SearchBook(Catalog _catalog, string _ISBN)
        {
            _catalog.SearchByISBN(_ISBN);
        }
    }
}
