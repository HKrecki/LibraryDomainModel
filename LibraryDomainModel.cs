using System;


namespace LibraryDomainModel
{
    class LibraryDomainModel
    {
        static void Main(string[] args)
        {
            Catalog catalog1 = new Catalog();
            Librarian librarian1 = new Librarian();

            librarian1.addBook(catalog1);
            // Console.WriteLine(catalog1.GetNumberOfBookitems()); // debug test

            librarian1.searchBook(catalog1, "AXAD");
            


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
