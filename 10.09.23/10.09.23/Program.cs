


#region Part3
/*
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Channels;


try
{

    IEnumerable<string> book = new[] { "Books", "Robert", "Maria"};
    BookList books = new BookList(book);
    
    IEnumerable<string> book2 = new[] { "Books", "Robert", "Marcus"};
    BookList books2 = new BookList(book2);

    Console.WriteLine(books == books2);
    Console.WriteLine(books != books2);

    
    
    
    books.Info();
    Console.WriteLine();
    books2.Info();

    books = books - " ";
    books.Info();


}
catch(CheckNameException ex)
{
    Console.WriteLine(ex);
}


class BookList
{
    public List<string> Books { get;  set; }

    private int _count;
    public BookList(IEnumerable<string> books)
    {
        Books = new List<string>(books);
    }
    
    public int Count
    {
        get => Books.Count();   
        set => _count = Books.Count; 
    }
    


    public int Size()
    {
        return Books.Count();
    }




    
    public string this[int index]
    {
        get
        {
            return Books[index];
        }
        set
        {
            Books[index] = value;
        }
    }

    public void Search(string nameSearch)
    {
        for (int i = 0; i < Books.Count; i++)
        {
            if (nameSearch == Books[i] || nameSearch == Books[i])
            {
                Console.WriteLine(Books[i]);
            }
        }
    }

    public void Info()
    {
        for (int i = 0; i < Books.Count; i++)
        {
            Console.WriteLine($"{i+1}.{Books[i]}");
        }
    }

   
    
    public static BookList operator + (BookList b, string book)
    {
        if (string.IsNullOrEmpty(book) || string.IsNullOrWhiteSpace(book))
            throw new CheckNameException("Error. Write book name!");
        b.Books.Add(book);
        return b;
    }

    public static BookList operator -(BookList b, string book)
    {
        if (string.IsNullOrEmpty(book) || string.IsNullOrWhiteSpace(book))
            throw new CheckNameException("Error. Write book name!");
        for (int i = 0; i < b.Count; i++)
        {
            if (b[i] == book)
                b.Books.Remove(book);
        }
           
        return b;

    }
    
    public static int operator == (BookList b1, BookList b2)
    {
        int count = 0;
        int j = 0;

        for (int i = 0; i < b1.Count; i++)
        {
            if (b1.Books[i] == b2.Books[j])
                count++;
            j++;
        }

        return count;
    }

    public static int operator != (BookList b1, BookList b2)
    {
        int count = 0;
        int j = 0;

        for (int i = 0; i < b1.Count; i++)
        {
            if (b1.Books[i] != b2.Books[j])
                count++;
            j++;
        }

        return count;
    }
}

class CheckNameException : Exception
{

    public string Message { get; private set; }

    public CheckNameException(string message) : base(message)
    {
        Message = message;
    }

    public override string ToString()
    {
        return $"Error message: {Message}";
    }
}
*/

#endregion

#region Part3(2 version) 


using System.Collections;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Channels;

try
{

    Book book = new Book("Война и мир", "Лев Толстой");
    Book book2 = new Book("Будущая книга по C#", "Эльвин Азимов special");
    Book book3 = new Book("Думай и Богатей", "Наполеон Хилл");

    Book indexBook = new("Index", "Index");

    IEnumerable<Book> b = new[] { book };

    BookList books = new BookList(b);
    books.Add(book2);
    books.Add(book3);
    books[3] = indexBook;


    Console.WriteLine(books);


}
catch (CheckNameException e)
{
    Console.WriteLine(e);
}

class Book
{

    private string _name;
    private string _author;


    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new CheckNameException("Empty!");
            _name = value;
        }
    }

    public string Author
    {
        get => _author;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new CheckNameException("Error empty!");
            _author = value;
        }
    }


    public Book(string name, string author)
    {
        Name = name;
        Author = author;
    }

    public override string ToString()
    {
        return $"Name: {Name}\n Author: {Author}\n";
    }
}


class BookList
{
    private List<Book> Books = new List<Book>();

    public BookList(IEnumerable<Book> book)
    {
        Books = new List<Book>(book);
    }

    public void Add(Book book)
    {
        Books.Add(book);
    }

    public int Count()
    {
        return Books.Count();
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine("Books: ");
        foreach (var book in Books)
        {
            sb.AppendLine(book.ToString());
        }

        return sb.ToString();
    }

    public Book this[int index]
    {
        get => Books[index];
        set => Books[index] = value;
    }

    public static BookList operator +(BookList b, Book book)
    {
        string name = book.Name;
        string author = book.Author;

        b.Books.Add(book);
        return b;
    }

    public static BookList operator -(BookList b, Book book)
    {
        string name = book.Name;
        string author = book.Author;

        b.Books.Add(book);
        return b;
    }



}


class CheckNameException : Exception
{

    public string Message { get; private set; }

    public CheckNameException(string message) : base(message)
    {
        Message = message;
    }

    public override string ToString()
    {
        return $"Error message: {Message}";
    }
}



#endregion

#region Part1

/*

string name = Console.ReadLine();
int year = int.Parse(Console.ReadLine());
string number = Console.ReadLine();
string email = Console.ReadLine();
int staffCount = int.Parse(Console.ReadLine());

Journal journal = new Journal(name,year,number,email,staffCount);

Console.WriteLine(journal);

journal.StaffCount += 10;

Console.WriteLine(journal);



class Journal
{
    public string Name { get; set; }
    public int CreateYear { get; set; }
    public string Number { get; set; }
    public string Email { get; set; }
    public int StaffCount { get; set; }


    public static int operator +(Journal journal, int value)
    {
        return journal.StaffCount += value;
    }

    public static int operator -(Journal journal, int value)
    {
        return journal.StaffCount -= value;
    }

    public static bool operator ==(Journal j1, Journal j2)
    {
        return j1.StaffCount == j2.StaffCount;
    }
    
    public static bool operator !=(Journal j1, Journal j2)
    {
        return j1.StaffCount != j2.StaffCount;
    }

    public override bool Equals(object obj)
    {
        if (obj is Journal)
        {
            Journal j = obj as Journal;
            return j.StaffCount == StaffCount;
        }

        return false;
    }
    public Journal(string name, int createYear, string number, string email, int staffCount)
    {
        Name = name;
        CreateYear = createYear;
        Number = number;
        Email = email;
        StaffCount = staffCount;
    }
    

    public override string ToString()
    {
        return $"Journal name: {Name}\n" +
               $"Journal year: {CreateYear}\n" +
               $"Personal number: {Number}\n" +
               $"Email: {Email}\n" +
               $"Staff count: {StaffCount}\n";
    }
}



 */

#endregion

#region Part2

/*
using System.Threading.Channels;

string name = Console.ReadLine();
string address = Console.ReadLine();
string description =Console.ReadLine();
string number = Console.ReadLine();
string email = Console.ReadLine();
double area = double.Parse(Console.ReadLine());

Magazine magazine = new Magazine(name, address, description, number, email,area);


class Magazine
{
    public string Name { get; set; }
    public string Address{  get; set; }
    public string Description { get; set; }
    public string Number { get; set; }
    public string Email { get; set; }
    
    public double Area { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Magazine)
        {
            Magazine m = obj as Magazine;
            return m.Area == Area;
        }

        return false;
    }

    public static double operator +(Magazine m, double value)
    {
        return m.Area += value;
    }

    public static double operator -(Magazine m, double value)
    {
        return m.Area -= value;
    }

    public static bool operator ==(Magazine m1, Magazine m2)
    {
        return m1.Area == m2.Area;
    }
    
    public static bool operator !=(Magazine m1, Magazine m2)
    {
        return m1.Area != m2.Area;
    }
    
    public Magazine(string name, string address, string description, string number, string email, double area)
    {
        Name = name;
        Address = address;
        Description = description;
        Number = number;
        Email = email;
        Area = area;
    }
    

    public override string ToString()
    {
        return $"Magazine name: {Name}\n" +
               $"Magazine address: {Address}\n" +
               $"Magazine description: {Description}\n" +
               $"Magazine number: {Number}\n" +
               $"Email: {Email}\n";
    }
}
*/

#endregion











