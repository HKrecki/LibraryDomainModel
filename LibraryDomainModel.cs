using System;


namespace LibraryDomainModel
{
    class LibraryDomainModel
    {
        static void Main(string[] args)
        {
            // Utworzenie potrzebnych obiektow
            Library library1 = new Library();
            Librarian librarian1 = new Librarian();
            Patron student1 = new Patron("Jan", "Kowalski", "Gliwice", "Bojkowska 1", "44-103");
            Patron student2 = new Patron("Kacper", "Nowak", "Gliwice", "Wrocławska 2", "44-103");

            // Dodanie 5 ksiazek do zbioru biblioteki
            library1.AddNewBookToLibrary("123" ,"12345", "RFID12345", "Megatrends", false, Language.English, 300, Format.Paperback);
            library1.AddNewBookToLibrary("124" ,"12346", "RFID12346", "Megatrends", false, Language.English, 300, Format.Paperback);
            library1.AddNewBookToLibrary("125","12347", "RFID12347", "Clean Code", false, Language.English, 300, Format.PDF);
            library1.AddNewBookToLibrary("126","12348", "RFID12348", "Opus Magnum c++11", false, Language.French, 2000, Format.Paperback);
            library1.AddNewBookToLibrary("127","12349", "RFID12349", "A Brief History of Time", false, Language.English, 256, Format.Hardcover);

            // Wyswietlenie ksiazek ze zbioru biblioteki
            library1.DisplayListOfBooksInLibrary();

            // Wyswietlenie zawartosci katalogu biblioteki (przed dodaniem ksiazek)
            library1.DisplayListOfBooksInCatlog();

            // Dodanie przez bibliotekarza 5 ksiazek do katalogu
            // Z wykorzystaniem kodow kreskowych
            librarian1.AddBookToCatalogByBarcode(library1, "12345");
            librarian1.AddBookToCatalogByBarcode(library1, "12347");
            // Z wykorzystaniem identyfikatorow RFID
            librarian1.AddBookToCatalogByRFID(library1, "RFID12346");
            librarian1.AddBookToCatalogByRFID(library1, "RFID12348");
            librarian1.AddBookToCatalogByRFID(library1, "RFID12349");

            // Wyswietlenie zawartosci katalogu biblioteki (po dodaniu ksiazek)
            library1.DisplayListOfBooksInCatlog();

            // Utworzenie 2 kont w bibliotece
            student1.CreateAccount(library1);
            student2.CreateAccount(library1);

            // Wyswietlenie numerow zarejestrowanych kont
            library1.ShowIdsOfAllAccounts();

            // Udane wypozyczenie 2 ksiazek
            student1.Borrow(library1, "Megatrends", 14);
            student1.Borrow(library1, "Megatrends", 14);

            // Nieudane wypozyczenie ksiazki ze wzgledu na przekroczony limit (2 ksiazki)
            student1.Borrow(library1, "Clean Code", 20);

            // Udane zarezerwowanie 2 ksiazek
            student2.Reserve(library1, "Megatrends");
            student2.Reserve(library1, "Megatrends");

            // Nieudane zarezerwowanie dwoch ksiazek ze wzgledu na przekroczony limit (2 ksiazki)
            student2.Reserve(library1, "Clean Code");

            // Wyswietlenie zawartosci katalogu wraz z obecnym stanem ksiazek (podane termin konca obecnego wypozyczenia i czy ksiazka jest zaresrerowana)
            library1.DisplayListOfBooksInCatlog();
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
