namespace Test
{
    public class LINQ
    {
        public static void Entry()
        {
            var products = new List<Product>() { new Product() { Name = "Apple", Price = 10 }, new Product() { Name = "Ball", Price = 20 }, new Product() { Name = "Chair", Price = 30 }, new Product() { Name = "Dumble", Price = 40 }, new Product() { Name = "Encyclopedia", Price = 50 }, new Product() { Name = "Fan", Price = 50 } };


            // LINQ Query Operators

            var cheaperProducts = from p in products
                                  where p.Price < 40
                                  orderby p.Name
                                  select p;


            // LINQ Extension Methods
            var cheapProducts = products.Where(prod => prod.Price < 40).OrderBy(prod => prod.Name);
            var cheapProductsNames = cheapProducts.Select(prod => prod.Name);

            foreach (var prod in cheapProducts)
                System.Console.WriteLine(prod.Name + " " + prod.Price);

            foreach (var prod in cheapProductsNames)
                System.Console.WriteLine(prod);

            
            // Single - To find exactly one object (can be used in place of where) - throws error if there are more than one matching object
            var productApple = products.Single(prod => prod.Name == "Apple");

            System.Console.WriteLine(productApple.Name);

            // SingleOrDefault - will return the default value if it doesn't find the matching object

            var productK = products.SingleOrDefault(prod => prod.Name == "K");

            System.Console.WriteLine(productK == null);


            // To get first matching object - (Also FirstOrDefault)
            var firstProduct = products.First();
            System.Console.WriteLine(firstProduct.Name);

            var firstProductWithPrice50 = products.First(prod => prod.Price == 50);
            System.Console.WriteLine(firstProductWithPrice50.Name);


            // To get last matching object - (Also LastOrDefault)
            var lastProduct = products.Last();
            System.Console.WriteLine(lastProduct.Name);

            var lastProductWithPrice50 = products.Last(prod => prod.Price == 50);
            System.Console.WriteLine(lastProductWithPrice50.Name);


            // For paginated data
            var pagedProducts = products.Skip(2).Take(3);

            foreach(var prod in pagedProducts)
                System.Console.WriteLine(prod.Name);

            
            
            var totalProducts = products.Count();

            System.Console.WriteLine(totalProducts);

            var highestPrice = products.Max(prod => prod.Price);

            var lowestPrice = products.Min(prod => prod.Price);

            var totalPrices = products.Sum(prod => prod.Price);

            var avgPrice = products.Average(prod => prod.Price);

            System.Console.WriteLine(highestPrice + " " + lowestPrice + " " + totalPrices + " " + avgPrice);

        }
    }
}