using Factory.Interfaces;


namespace Factory.Classes
{
    public class ProductFactory
    {
        public static IProduct createProduct (string productPricing){

            IProduct? product = null;

            if (productPricing == "cheap") {
                product = new CheapProduct ();
            }
            else if (productPricing == "expensive") {
                product = new ExpensiveProduct ();
            }
            else
            {
                product = new CheapProduct ();
            }

            return product;
        }
    }
}
