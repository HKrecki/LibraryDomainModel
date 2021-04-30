using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomainModel
{
    public class Account
    {
        public int number;
        DateTime opened;
        AccountState state;
        public History history;

        public Account(Library _library)
        {
            SetAccountNumber(_library.accounts.Count() + 1);
            SetOpenedDate(DateTime.Now);
            ChangeState(AccountState.Active);

            _library.AddAccountToLibrarySystem(this);
        }

        // Reserve 
        public void Reserve(Library _library, string _bookName)
        {
            Console.WriteLine("Z funkcji reserve");

            string keyOfRightBookInCatalog = "none";

            bool isBookAvailable = false;

            // Find given book in library catalog
            foreach (var item in _library.libraryCatalog.bookItemCatalog)
            {
                if (item.Value.name == _bookName) // Found title in catalog
                {
                    // Check if book is available to reserve = is borrowed and not reserved already
                    if (item.Value.isReserved == false && item.Value.isBorrowed == true)
                    {
                        keyOfRightBookInCatalog = item.Key;
                        isBookAvailable = true;
                    }
                }
            }

            if (isBookAvailable) // book is available
            {
                var aux = _library.libraryCatalog.bookItemCatalog[keyOfRightBookInCatalog];

                aux.isReserved = true;

                Console.WriteLine($"Uzytkownik {this.number} zarezerowal ksiazke: {aux.title}, ISBN: {aux.ISBN}");
            }
            else
            {
                Console.WriteLine("Ksiazka jest niedostepna");
            }
        }

        // Borrow
        public void Borrow(Library _library, string _bookName, int _timeInDays)
        {
            Console.WriteLine("Z funkcji borrow");
            // _library.DisplayListOfBooksInCatlog();
            // _library.DisplayListOfBooksInLibrary();

            string keyOfRightBookInCatalog = "none";

            bool isBookAvailable = false;

            // Find given book in library catalog
            foreach (var item in _library.libraryCatalog.bookItemCatalog)
            {
                if (item.Value.name == _bookName) // Found title in catalog
                {
                    // Check if book is available (not referenceOnly, not borrowed or reserved)
                    if (item.Value.isReferenceOnly == false && (item.Value.dueDate < DateTime.Now && item.Value.isOverdue == false) && item.Value.isBorrowed == false)
                    {
                        keyOfRightBookInCatalog = item.Key;
                        isBookAvailable = true;   
                    }
                }
            }

            if (isBookAvailable) // book is available
            {
                var aux = _library.libraryCatalog.bookItemCatalog[keyOfRightBookInCatalog];

                aux.borrowed = DateTime.Now;
                aux.loanPeriod = _timeInDays;
                aux.dueDate = DateTime.Now.AddDays(_timeInDays);
                aux.isOverdue = false;
                aux.isBorrowed = true;

                Console.WriteLine($"Uzytkownik {this.number} wyprzyczyl ksiazke: {aux.title}, ISBN: {aux.ISBN}");
            }
            else
            {
                Console.WriteLine("Ksiazka jest niedostepna");
            }

        }

        // Access
        public void SetOpenedDate(DateTime _newOpenedDate)
        {
            opened = _newOpenedDate;
        }
        public void ChangeState(AccountState _newState)
        {
            state = _newState;
        }
        public void SetAccountNumber(int _newNumber)
        {
            number = _newNumber;
        }


        public struct History
        {
            List<Book_Item> bookItemsHistoryList;

            public void AddBookToHistory(Book_Item book)
            {
                bookItemsHistoryList.Add(book);
            }
        }
    }
}
