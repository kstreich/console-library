using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to The Library!");
      Book id1 = new Book("To Kill a Mockingbird", "Harper Lee");
      Book id2 = new Book("Harry Potter and the Goblet of Fire", "JK Rowling");
      Book id3 = new Book("Pride and Prejudice", "Jane Austen");
      Book id4 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
      Book id5 = new Book("1984", "George Orwell");

      Library library = new Library("Public Library", "Boise");
      library.AddBook(id1);
      library.AddBook(id2);
      library.AddBook(id3);
      library.AddBook(id4);
      library.AddBook(id5);

      library.PrintBooks();

      Console.WriteLine("Select a number to check out a book");
      string selection = Console.ReadLine();
      library.CheckOut(selection);



    }
  }
}
