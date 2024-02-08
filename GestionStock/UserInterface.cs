using System;

namespace GestionStock
{
    public class UserInterface
    {
        private readonly Stock _stock;

        public UserInterface()
        {
            _stock = new Stock();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the stock");
            var continueNavigate = true;
            int choice;
            while (continueNavigate)
            {
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    continueNavigate = false;
                }
                else if (choice == 1)
                {
                    SearchById();
                }
                else if (choice == 2)
                {
                    AddArticle();
                }
                else if (choice == 3)
                {
                    RemoveById();
                }
                else if (choice == 4)
                {
                    UpdateArticle();
                }
                else if (choice == 5)
                {
                    SearchByName();
                }
                else if (choice == 6)
                {
                    SearchInPriceRange();
                }
                else if (choice == 7)
                {
                    _stock.Display();
                    Console.WriteLine("");
                }
            }
        }

        public static double GetDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public static int GetInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string GetStr()
        {
            return Console.ReadLine();
        }

        public void AddArticle()
        {
            Console.WriteLine("Add an article");
            Console.WriteLine("Give an Id");
            var id = GetInt();
            Console.WriteLine("Give a Name");
            var name = GetStr();
            Console.WriteLine("Give a Price");
            var price = GetDouble();
            Console.WriteLine("Give a Quantity");
            var quantity = GetInt();

            _stock.Add(new Article(id, name, price, quantity));
        }

        public void RemoveById()
        {
            Console.WriteLine("Remove an article by Id");
            _stock.RemoveById(GetInt());
        }

        public void SearchById()
        {
            Console.WriteLine("Search an article by Id");
            Console.WriteLine(_stock.SearchById(GetInt()));
        }

        public void SearchByName()
        {
            Console.WriteLine("Search an article");
            Console.WriteLine(_stock.SearchByName(GetStr()));
        }

        public void UpdateArticle()
        {
            Console.WriteLine("Give the article's ID to update");
            var article = _stock.SearchById(GetInt());
            var isUpdate = true;
            int choice;
            while (isUpdate)
            {
                Console.WriteLine(article.ToString());
                Console.WriteLine(
                    "1 - Update Name"
                    + "2 - Update Price\n"
                    + "3 - Update Quantity\n"
                    + "4 - Finish Update\n");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4)
                {
                    isUpdate = false;
                }
                else if (choice == 1)
                {
                    Console.WriteLine("Give the new name");
                    article.Name = GetStr();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Give the new price");
                    article.Price = GetInt();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Give the new quantity");
                    article.Price = GetInt();
                }
            }

            Console.WriteLine(article.ToString());
        }

        public void SearchInPriceRange()
        {
            Console.WriteLine("Give the minimum price");
            var min = GetDouble();
            Console.WriteLine("Give the maximum price");
            var max = GetDouble();
            var range = _stock.SearchByPriceRange(min, max);
            foreach (var article in range)
                Console.WriteLine(article.ToString());
        }

        public void DisplayMenu()
        {
            Console.WriteLine(
                "1 - Search an article by id\n"
                + "2 - Add an article\n"
                + "3 - Remove an article by id\n"
                + "4 - Update an article by id\n"
                + "5 - Search an article by name\n"
                + "6 - Search an article by price range\n"
                + "7 - Display all articles\n"
                + "0 - Quit\n"
            );
        }
    }
}