using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    public class Library
    {
        readonly string name;
        readonly Address address;


        /* List of all books in this library, not only this in catalogs
         * List of books which have library, no divide in catalogs. 
         * Library doesn't manage books by itself. Only librarian can add a new book 
         * or delete it
         */
        public List<Book_Item> book_Items = new List<Book_Item>();
        /* List of all accounts in library
         * List of all created accounts in library
         */
        public List<Account> accounts = new List<Account>();


        // Catalog //
        public Catalog libraryCatalog = new Catalog();

        /*
        /* Creates new catalog
         * Method creates catalog and add it's to library list of catalogs
         *
        public void CreateCatalog()
        {
            libraryCatalog = new Catalog();
        } 
        */

        // BookItems //
        /* Adds new book to library (not catalog)
         * Like a library bought a new book which is availble from now
         */
        public void AddNewBookToLibrary()
        {
            Book_Item newBook = new Book_Item();

            newBook.ISBN = "aaa"; // debug

            book_Items.Add(newBook);
        }

        // Accounts //
        /* Add account to system on request of patron
         */
        public void AddAccountToLibrarySystem(Account _account)
        {
            _account.number = 1; // Change to give account first free number

            accounts.Add(_account);
        }

        /* Print in console id's of all accounts
         */
        public void ShowIdsOfAllAccounts()
        {
            for (int i = 0; i < accounts.Count(); i++)
            {
                Console.WriteLine(accounts[i].number);
            }
        }


    }
}
