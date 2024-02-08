namespace GestionStock
{
    public class Article
    {
        public Article(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            if (obj == null || GetType().Equals(obj.GetType()))
                return false;
            var compared = (Article)obj;
            if (compared.Name == Name && compared.Id == Id)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + Id;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Quantity: {Quantity}, Price: {Price}€";
        }
    }
}