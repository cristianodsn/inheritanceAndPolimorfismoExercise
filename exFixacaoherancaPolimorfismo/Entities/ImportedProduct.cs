using System.Globalization;

namespace exFixacaoherancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct(string name, double price, double custonFee) : base (name, price)
        {
            CustomsFee = custonFee;
        }

        protected sealed override string PriceTag()
        {
            double totalValue = Price + CustomsFee;
            return
               $"{Name} $ {totalValue.ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public override string ToString()
        {
            return PriceTag();
        }
    }
}
