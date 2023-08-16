using System;
using System.Globalization;

namespace exFixacaoherancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; protected set; }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            ManufactureDate = date;
        }

        protected override string PriceTag()
        {
            return
                $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToShortDateString()})";
        }

        public override string ToString()
        {
            return PriceTag();
        }
    }
}
