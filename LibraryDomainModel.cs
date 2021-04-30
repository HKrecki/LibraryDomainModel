using System;


namespace LibraryDomainModel
{
    class LibraryDomainModel
    {
        static void Main(string[] args)
        {
            Library library1 = new Library();
            Librarian librarian1 = new Librarian();
            Patron kowalski = new Patron("Jan", "Kowalski", "Gliwice", "Bojkowska 1", "44-103");
            Patron nowak = new Patron("Kacper", "Nowak", "Gliwice", "Wrocławska 2", "44-103");

            // Add 5 books to library (not catalog)
            library1.AddNewBookToLibrary("123" ,"12345", "RFID12345", "Megatrends", false, Language.English, 300, Format.Paperback);
            library1.AddNewBookToLibrary("124" ,"12346", "RFID12346", "Megatrends", false, Language.English, 300, Format.Paperback);
            library1.AddNewBookToLibrary("125","12347", "RFID12347", "Clean Code", false, Language.English, 300, Format.PDF);
            library1.AddNewBookToLibrary("126","12348", "RFID12348", "Opus Magnum c++11", false, Language.French, 2000, Format.Paperback);
            library1.AddNewBookToLibrary("127","12349", "RFID12349", "A Brief History of Time", false, Language.English, 256, Format.Hardcover);

            // Display all of books in library list
            library1.DisplayListOfBooksInLibrary();
            library1.DisplayListOfBooksInCatlog();
            // library1.DisplayListOfBooksInCatlog();

            // Librarian adds 5 books to library catalog
            // by barcode
            librarian1.AddBookToCatalogByBarcode(library1, "12345");
            librarian1.AddBookToCatalogByBarcode(library1, "12347");
            // by RFID
            librarian1.AddBookToCatalogByRFID(library1, "RFID12346");
            librarian1.AddBookToCatalogByRFID(library1, "RFID12348");
            librarian1.AddBookToCatalogByRFID(library1, "RFID12349");

            //Console.WriteLine($"{library1.libraryCatalog.bookItemCatalog["123"].name} a");


            // Display all of books in library list and in library catalog 
            //library1.DisplayListOfBooksInLibrary();
            //library1.DisplayListOfBooksInCatlog();


            //Create accounts in library1
            kowalski.CreateAccount(library1);
            nowak.CreateAccount(library1);


            //Display all accounts in library system
            library1.ShowIdsOfAllAccounts();

            library1.DisplayListOfBooksInCatlog();


            // Console.WriteLine(library1.libraryCatalog.bookItemCatalog["123"].name);
            // Console.WriteLine(library1.libraryCatalog.bookItemCatalog["123"].name);

            kowalski.Borrow(library1, "Megatrends", 14);
            kowalski.Borrow(library1, "Megatrends", 14);
            kowalski.Borrow(library1, "Megatrends", 14);
            nowak.Borrow(library1, "Megatrends", 30);
            nowak.Borrow(library1, "Clean Code", 30);

            library1.DisplayListOfBooksInCatlog();

            // library1.DisplayListOfBooksInCatlog();

            // librarian1.SearchBook(library1.libraryCatalog, "aaa");

            // kowalski.SearchBook(library1, "default");

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
