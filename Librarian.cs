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

        public void addBook(Catalog _catalog)
        {
            Book_Item newBook = new Book_Item();

            // insert ISBN and other params of book
            // TODO: implement cin
            newBook.ISBN = "AXAD";

            // from interface
            _catalog.AddBookItem(newBook);
        }
        // TODO:  public void addBook(Catalog _catalog, BookItem _newBook)


        public void searchBook(Catalog _catalog, string _ISBN)
        {
            _catalog.SearchByISBN(_ISBN);
        }
    }
}
