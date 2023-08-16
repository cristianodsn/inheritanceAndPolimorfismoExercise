using System.Globalization;

namespace exFixacaoherancaPolimorfismo.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public  Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        protected virtual string PriceTag()
        {
            return
                $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public override string ToString()
        {
            return PriceTag().ToString();
        }
    }
}
