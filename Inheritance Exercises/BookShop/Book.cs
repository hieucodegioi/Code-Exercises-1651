using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    internal class Book
    {
        private string title;
        
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        private string author;
        public virtual string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        private decimal price;
        public virtual decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public Book(string author, string title, decimal price) 
        {
            if (author.Length > 1 && char.IsDigit(author[1]))
            {
                throw new ArgumentException("Author not valid!");
            }

            if (title.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;

        }
    }
}
