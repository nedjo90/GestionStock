using System;
using System.Collections.Generic;

namespace GestionStock
{
    public class Stock
    {
        private readonly List<Article> _stock;

        public Stock()
        {
            _stock = new List<Article>();
            _stock.Add(new Article(1, "shoes", 50.99, 10));
            _stock.Add(new Article(2, "pant", 70.50, 20));
            _stock.Add(new Article(3, "jacket", 100, 30));
            _stock.Add(new Article(3, "socket", 5, 40));
        }

        public void Add(Article nouvelleArticle)
        {
            if (!_stock.Contains(nouvelleArticle))
                _stock.Add(nouvelleArticle);
        }

        public Article SearchById(int reference)
        {
            foreach (var article in _stock)
                if (article.Id == reference)
                    return article;

            return null;
        }

        public Article SearchByName(string name)
        {
            foreach (var article in _stock)
                if (article.Name == name)
                    return article;

            return null;
        }

        public bool RemoveById(int reference)
        {
            foreach (var article in _stock)
                if (article.Id == reference)
                    return _stock.Remove(article);

            return false;
        }

        public void UpdatePriceById(int reference, double newPrice)
        {
            foreach (var article in _stock)
                if (article.Id == reference)
                {
                    article.Price = newPrice;
                    return;
                }
        }

        public void UpdateNameById(int reference, string newName)
        {
            foreach (var article in _stock)
                if (article.Id == reference)
                {
                    article.Name = newName;
                    return;
                }
        }

        public List<Article> SearchByPriceRange(double min, double max)
        {
            var listInRange = new List<Article>();
            foreach (var article in _stock)
                if (article.Price >= min && article.Price <= max)
                    listInRange.Add(article);

            return listInRange;
        }

        public void Display()
        {
            foreach (var article in _stock) Console.WriteLine(article.ToString());
        }
    }
}