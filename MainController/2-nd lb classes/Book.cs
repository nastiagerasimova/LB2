using System;

namespace MainController
{
    class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(Title title, Author author,Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
    class Title
    {
        public string Name { get; set; }

        public Title(string Name)
        {
            this.Name = Name;
        }
        public  void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Title: {Name}");
            Console.ResetColor();
        }
    }
    class Author
    {
        public string Name { get; set; }

        public Author(string Name)
        {
            this.Name = Name;
        }
        public  void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Author: {Name}");
            Console.ResetColor();
        }
    }
    class Content
    {
        public string Name { get; set; }

        public Content(string Name)
        {
            this.Name = Name;
        }
        public  void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Content: {Name}");
            Console.ResetColor();
        }
    }
}
