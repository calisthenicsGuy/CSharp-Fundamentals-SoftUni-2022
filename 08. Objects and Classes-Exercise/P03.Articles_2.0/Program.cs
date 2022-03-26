using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Articles_2._0
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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] articleInformation = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string title = articleInformation[0];
                string content = articleInformation[1];
                string author = articleInformation[2];

                Article newArticle = new Article(title, content, author);
                articles.Add(newArticle);
            }

            string text = Console.ReadLine();

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
