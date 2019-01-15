using System;
using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
    public string Name { get; private set; }

    public string Location { get; set; }

    public List<Book> CheckedOut { get; set; }

    public List<Book> AvailableBooks { get; set; }

    private List<Book> Books { get; set; }


    public Library(string name, string location)
    {
      Name = name;
      Location = location;
      Books = new List<Book>();
      CheckedOut = new List<Book>();

    }

    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        System.Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }

    public void AddBook(Book book)
    {
      Books.Add(book);
    }

    public void CheckOut(string selection)
    {
      Book selectedBook = ValUserSelection(selection, AvailableBooks);
      if (selectedBook == null)
      {
        Console.Clear();
        Console.WriteLine(@"Invalid Selection
                    ");
        return;
      }
    }

    private Book ValUserSelection(string selection, List<Book> bookList)
    {
      int bookIndex;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 0 || bookIndex > bookList.Count)
      {
        System.Console.Clear();
        System.Console.WriteLine("Please make a valid selection");
        return null;
      }
      return bookList[bookIndex - 1];
    }
  }
}