using System;


namespace LibraryDomainModel
{
    class LibraryDomainModel
    {
        static void Main(string[] args)
        {
            Library library1 = new Library();
            Librarian librarian1 = new Librarian();
            Patron kowalski1 = new Patron();

            kowalski1.CreateAccount(library1);

            library1.ShowIdsOfAllAccounts();
            
            library1.AddNewBookToLibrary();


            
            librarian1.addBookToCatalog(library1.libraryCatalog, library1.book_Items[0]);

            kowalski1.Reserve(library1, "default");


            librarian1.SearchBook(library1.libraryCatalog, "aaa");

            kowalski1.SearchBook(library1, "default");

            // library1.DeleteCatalog(library1.catalogs[0]);
        }


        
       
       
        
    }


    public struct Address
    {
        public string city;
        public string street;
        public string postalCode;
    }

    public struct FullName
    {
        public string firstName;
        public string lastName;
    }

    public enum Language
    {
        English,
        French,
        German,
        Spanish,
        Italian
    }

    public enum AccountState
    {
        Active,
        Fozen,
        Closed
    }

    public enum Format
    {
        Paperback,
        Hardcover,
        Audibook,
        Audio_CD,
        MP3_CD,
        PDF
    }
}
