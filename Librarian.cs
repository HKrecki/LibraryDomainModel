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

        //////////////////////////////////
        // Add existing book to cetalog //
        /* Adds existing book(in library) to catalog
         */
        public void AddBookToCatalog(Catalog _catalog, Book_Item _book)
        {
            _catalog.AddBookItem(_book);
        }

        public void AddBookToCatalogByBarcode(Library _library, string _barcode)
        {
            // Search book of given barocode in library collection
            // Check this book is not already in catalog
            // Add book to catalog if is in library and isn.t in catalog

            bool isAvailableInLibrary = false;
            bool isAlreadyInCatalog = false;
          
            int bookIndexInLibraryList = 0;

            // Check the book is in library book list:
            foreach(var item in _library.libraryBookList)
            {
                // If book is in library
                if (item.barcode == _barcode)
                {
                    isAvailableInLibrary = true;
                    bookIndexInLibraryList = _library.libraryBookList.IndexOf(item);
                }
            }

            // Check book is already in catalog
            foreach (var item in _library.libraryCatalog.bookItemCatalog)
            {
                // If book is already in catalog
                if (item.Value.barcode == _barcode)
                    isAlreadyInCatalog = true;
            }

            // If book is in library and is not already in catalog
            if(isAvailableInLibrary == true && isAlreadyInCatalog == false)
            {
                _library.libraryCatalog.AddBookItem(_library.libraryBookList[bookIndexInLibraryList]);

                Console.WriteLine($"Do katalogu dodano ksiazke o kodzie kreskowym: {_barcode}");
            }
            else if(isAvailableInLibrary == false && isAlreadyInCatalog == false)
            {
                Console.WriteLine("Nie mozna dodac ksiazki, nie ma tekiej w bazie biblioteki");
            }
            else
            {
                Console.WriteLine("Nie mozna ponownie dodac ksiazki, jest juz w katalogu");
            }
        }
        
        public void AddBookToCatalogByRFID(Library _library, string _tag)
        {
            bool isAvailableInLibrary = false;
            bool isAlreadyInCatalog = false;

            int bookIndexInLibraryList = 0;

            // Check the book is in library book list:
            foreach (var item in _library.libraryBookList)
            {
                // If book is in library
                if (item.tag == _tag)
                {
                    isAvailableInLibrary = true;
                    bookIndexInLibraryList = _library.libraryBookList.IndexOf(item);
                }
            }

            // Check book is already in catalog
            foreach (var item in _library.libraryCatalog.bookItemCatalog)
            {
                // If book is already in catalog
                if (item.Value.tag == _tag)
                    isAlreadyInCatalog = true;
            }

            // If book is in library and is not already in catalog
            if (isAvailableInLibrary == true && isAlreadyInCatalog == false)
            {
                _library.libraryCatalog.AddBookItem(_library.libraryBookList[bookIndexInLibraryList]);
                Console.WriteLine($"Do katalogu dodano ksiazke o RFID: {_tag}");
            }
            else if (isAvailableInLibrary == false && isAlreadyInCatalog == false)
            {
                Console.WriteLine("Nie mozna dodac ksiazki, nie ma tekiej w bazie biblioteki");
            }
            else
            {
                Console.WriteLine("Nie mozna ponownie dodac ksiazki, jest juz w katalogu");
            }
        
        }
        
        //////////////////////////////////

        public void SearchBookByRFID(Catalog _catalog, string _ISBN)
        {
            _catalog.SearchByISBN(_ISBN);
        }
    }
}
