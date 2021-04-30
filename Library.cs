﻿using System;
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
        public List<Book_Item> libraryBookList = new List<Book_Item>();
        /* List of all accounts in library
         * List of all created accounts in library
         */
        public List<Account> accounts = new List<Account>();

        /////////////
        // Catalog //

        public Catalog libraryCatalog = new Catalog();

        public void DisplayListOfBooksInCatlog()
        {
            Console.WriteLine();
            Console.WriteLine("Wszystkie ksiazki w katalogu:");
            foreach(var item in libraryCatalog.bookItemCatalog)
            {
                Console.WriteLine($"Title: {item.Value.title}, ISBN: {item.Value.title}, Barcode: {item.Value.barcode}, RFID tag: {item.Value.tag}");
            }
            Console.WriteLine();
        }

        /////////////

        ///////////////
        // BookItems //

        /* Adds new book to library (not catalog)
         * Like a library bought a new book which is availble from now
         */
        public void AddNewBookToLibrary(string _isbn, string _barcode, string _tag, string _title, bool _isReferenceOnly, Language _lang, int _numberOfPages, Format _format)
        {
            Book_Item newBook = new Book_Item();

            newBook.ISBN = _isbn;
            newBook.barcode = _barcode;
            newBook.tag = _tag;
            newBook.title = _title;
            newBook.isReferenceOnly = _isReferenceOnly;
            newBook.lang = _lang;
            newBook.numberOfPages = _numberOfPages;
            newBook.format = _format;

            // Add book to library list
            libraryBookList.Add(newBook);
        }
        
        /* Display all of the books in library
         */ 
        public void DisplayListOfBooksInLibrary()
        {
            Console.WriteLine();
            Console.WriteLine("Wszystkie ksiazki w bibliotece:");
            foreach(var item in libraryBookList)
            {
                Console.WriteLine($"Title: {item.title}, ISBN: {item.ISBN}, Barcode: {item.barcode}, RFID tag: {item.tag}");
            }
            Console.WriteLine();
        }

        ///////////////

        //////////////
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
