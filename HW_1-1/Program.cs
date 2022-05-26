using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Создать класс Book. 
Создать классы Title, Author и Content, каждый из которых должен содержать
одно строковое поле и метод void Show().

Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
содержание. */
namespace HW_1_1
{
    class Book
    {        
        public void ShowBook()
        {
            
            Title title = new Title();
            title.ShowTitle(title);


            
            Author author = new Author();
            author.ShowAuthor(author);

            
            Content content = new Content();
            content.ShowContent();
        }
    }
    class Title
    {
        public string _title;
        public void ShowTitle(Title titleIn)
        {
            Console.ResetColor();
            Title title = new Title();
            Console.WriteLine("=> Title:     ");
            _title = Console.ReadLine();
            title._title = _title;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Title:     " + title._title);
            Console.WriteLine();
        }
    }    
    class Author
    {
        public string _author;        
        public void ShowAuthor(Author authorIn)
        {
            Console.ResetColor();
            Author author = new Author();
            Console.WriteLine("=> Author:     ");
            _author = Console.ReadLine();
            author._author = _author;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Author:      " + author._author);
            Console.WriteLine();
        }
    }
    class Content
    {
        public string _content;
        public void ShowContent()
        {
            Console.ResetColor();
            Content content = new Content();
            Console.WriteLine("=> Content:     ");
            _content = Console.ReadLine();
            content._content = _content;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Content:     " + content._content);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {    
            Book book = new Book();
            book.ShowBook();                       

            Console.ReadLine();
        }
    }
}
