internal class Program
{
    private static void Main(string[] args)
    {

        List<Category> categories = new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Bilgisiyar"},
            new Category{CategoryId=2, CategoryName="Telefon"},
        };
        List<Product> products = new List<Product>
        {
            new Product{productId=1, CategoryId=1,ProductName="Acer Laptop",
            QuantiyPerUnit ="32 GB Ram",UnitPrice=10000, UnitsInStock=5},
            new Product{productId=2, CategoryId=1,ProductName="Asus Laptop",
            QuantiyPerUnit ="16 GB Ram", UnitPrice=18000, UnitsInStock=3},
            new Product{productId=3, CategoryId=1,ProductName="HP Laptop",
            QuantiyPerUnit ="8 GB Ram",UnitPrice=18000, UnitsInStock=2},
            new Product{productId=4, CategoryId=1,ProductName="Samsung Telefon",
            QuantiyPerUnit ="4 GB Ram",UnitPrice=5000, UnitsInStock=15},
            new Product{productId=5, CategoryId=1,ProductName="Apple Telefon",
            QuantiyPerUnit ="4 GB Ram",UnitPrice=8000, UnitsInStock=0}
    };
        //Text(products);

        //GetProducts(products);

        //AnyText(products);
        //Lambda

        //FinText(products);

        //FindAllText(products);

        //AscDescText(products);

        //ClassicLinqText(products);

        var result = from p in products
                     join c in categories
                     on p.CategoryId equals c.CategoryId
                     where p.UnitPrice>5000
                     orderby p.UnitPrice descending 
                     select new ProductDto 
                     {
                         ProductId = p.productId,
                         CategoryName = c.CategoryName,
                         ProductName = p.ProductName,
                         UnitPrice = p.UnitPrice
                     };

                       foreach (var productDto in result)
        {
            Console.WriteLine("{0} --- {1}",productDto.ProductName, productDto.CategoryName);
        }
    }

    private static void ClassicLinqText(List<Product> products)
    {
        var result = from p in products
                     where p.UnitPrice > 6000
                     orderby p.UnitPrice descending, p.ProductName ascending
                     select new ProductDto
                     {
                         ProductId = p.productId,
                         ProductName = p.ProductName,
                         UnitPrice = p.UnitPrice,

                     };

        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }
    }

    private static void AscDescText(List<Product> products)
    {
        // Single line query
        var result = products.Where(p => p.ProductName.Contains("top"))
            .OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }
    }

    private static void FindAllText(List<Product> products)
    {
        var result = products.FindAll(p => p.ProductName.Contains("top"));
        Console.WriteLine(result);
    }

    private static void NewMethod(List<Product> products)
    {
        var result = products.Find(p => p.productId == 3);
        Console.WriteLine(result.ProductName);
    }

    private static void AnyText(List<Product> products)
    {
        var result = products.Find(p => p.productId == 15);
        Console.WriteLine(result.ProductName);
    }

    private static void Text(List<Product> products)
    {
        Console.WriteLine("Algoritmik----------------------");

        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
            {
                Console.WriteLine(product.ProductName);
            }

        }
        Console.WriteLine("Linq-----------------------");

        var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }
    }

    static List<Product> GetProducts(List<Product> products)
    {
        List<Product> filteredProducts = new List<Product>();
        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
            {
                filteredProducts.Add(product);
            }
        }
        return filteredProducts;
    }
    static List<Product> GetProductsLinq(List<Product> products)
    {
       return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
    }
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
class Product
{
    public int productId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantiyPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}
class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}



