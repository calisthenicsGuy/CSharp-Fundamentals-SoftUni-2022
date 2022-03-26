using System;
using System.Linq;

namespace P02.Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string change)
        {
            this.Content = change;
        }

        public void ChangeAuthor(string change)
        {
            this.Author = change;
        }

        public void Rename(string change)
        {
            this.Title = change;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleInformation = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string title = articleInformation[0];
            string content = articleInformation[1];
            string author = articleInformation[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] changes = Console.ReadLine()
                .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string command = changes[0];
                string change = changes[1];

                if (command == "Edit")
                {
                    article.Edit(change);
                }

                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(change);
                }

                else if (command == "Rename")
                {
                    article.Rename(change);
                }
            }

            Console.WriteLine(article);
        }
    }
}
