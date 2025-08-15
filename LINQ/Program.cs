using static LINQ.ListGenerators;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //} 
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductList.Where(p => p.UnitPrice > 3 && p.UnitsInStock > 0);
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //} 
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Select((N, V) => new { Name = N, Value = V })
            //                  .Where(x =>  x.Name.Length > x.Value)
            //                  .Select(x => x.Value);

            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //} 
            #endregion
            #endregion

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var Result = ProductList.First(x => x.UnitsInStock == 0);
            //Console.WriteLine(Result); 
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            //if (Result == null)
            //    Console.WriteLine(Result);
            //else
            //    Console.WriteLine("No Product Matching"); 
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(n => n > 5)
            //                    .Order()
            //                    .ElementAt(1);
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine(result); 
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var Result = CustomerList.Select(c => new { c.CustomerName, ordersCount = c.Orders.Count() });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.CustomerName}: {item.ordersCount} orders");
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var Result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        ProductCount = g.Count()
            //    });

            //foreach (var item in Result)
            //{
            //        Console.WriteLine($"{item.Category}: {item.ProductCount} products");
            //} 
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int total = Arr2.Sum();

            //Console.WriteLine($"Total of array numbers: {total}"); 
            #endregion

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            #region 5. Get the total number of characters of all words
            //int totalChars = words.Sum(w => w.Length);
            //Console.WriteLine($"[5] Total characters: {totalChars}");
            #endregion

            #region 6. Get the length of the shortest word
            //int shortestLength = words.Min(w => w.Length);
            //Console.WriteLine($"[6] Shortest word length: {shortestLength}");
            #endregion

            #region 7. Get the length of the longest word
            //int longestLength = words.Max(w => w.Length);
            //Console.WriteLine($"[7] Longest word length: {longestLength}");
            #endregion

            #region 8. Get the average length of the words
            //double avgLength = words.Average(w => w.Length);
            //Console.WriteLine($"[8] Average word length: {avgLength:F2}");
            #endregion

            #region 9. Get the total units in stock for each product category
            //var totalUnitsPerCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        TotalUnits = g.Sum(p => p.UnitsInStock)
            //    });

            //Console.WriteLine("[9] Total units in stock per category:");
            //foreach (var item in totalUnitsPerCategory)
            //    Console.WriteLine($"{item.Category}: {item.TotalUnits} units");
            #endregion

            #region 10. Get the cheapest price among each category's products
            //var cheapestPricePerCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        MinPrice = g.Min(p => p.UnitPrice)
            //    });

            //Console.WriteLine("[10] Cheapest price per category:");
            //foreach (var item in cheapestPricePerCategory)
            //    Console.WriteLine($"{item.Category}: {item.MinPrice}");
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var cheapestProductsPerCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g =>
            //    {
            //        var minPrice = g.Min(p => p.UnitPrice);
            //        return new
            //        {
            //            Category = g.Key,
            //            Products = g.Where(p => p.UnitPrice == minPrice)
            //        };
            //    });

            //Console.WriteLine("[11] Cheapest products per category:");
            //foreach (var item in cheapestProductsPerCategory)
            //{
            //    Console.WriteLine(item.Category);
            //    foreach (var p in item.Products)
            //        Console.WriteLine($"  {p.ProductName} - {p.UnitPrice}");
            //}
            #endregion

            #region 12. Get the most expensive price among each category's products
            //var maxPricePerCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        MaxPrice = g.Max(p => p.UnitPrice)
            //    });

            //Console.WriteLine("[12] Most expensive price per category:");
            //foreach (var item in maxPricePerCategory)
            //    Console.WriteLine($"{item.Category}: {item.MaxPrice}");
            #endregion

            #region 13. Get the products with the most expensive price in each category
            //var expensiveProductsPerCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g =>
            //    {
            //        var maxPrice = g.Max(p => p.UnitPrice);
            //        return new
            //        {
            //            Category = g.Key,
            //            Products = g.Where(p => p.UnitPrice == maxPrice)
            //        };
            //    });

            //Console.WriteLine("[13] Most expensive products per category:");
            //foreach (var item in expensiveProductsPerCategory)
            //{
            //    Console.WriteLine(item.Category);
            //    foreach (var p in item.Products)
            //        Console.WriteLine($"  {p.ProductName} - {p.UnitPrice}");
            //}
            #endregion

            #region 14. Get the average price of each category's products
            //var avgPricePerCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AvgPrice = g.Average(p => p.UnitPrice)
            //    });

            //Console.WriteLine("[14] Average price per category:");
            //foreach (var item in avgPricePerCategory)
            //    Console.WriteLine($"{item.Category}: {item.AvgPrice:F2}");
            #endregion
            #endregion

            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            //var uniqueCategories = ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names
            //var uniqueFirstLetters = ProductList.Select(p => p.ProductName[0])
            //    .Union(CustomerList.Select(c => c.CustomerName[0]))
            //    .Distinct();

            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names
            //var commonFirstLetters = ProductList.Select(p => p.ProductName[0])
            //    .Intersect(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names
            //var productOnlyLetters = ProductList.Select(p => p.ProductName[0])
            //    .Except(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var letter in productOnlyLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var lastThreeChars = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
            //    .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName));

            //foreach (var str in lastThreeChars)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion
            #endregion

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington
            //var first3OrdersInWashington = CustomerList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);

            //foreach (var order in first3OrdersInWashington)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion


            #region 2. Get all but the first 2 orders from customers in Washington
            //var skipFirst2OrdersInWashington = CustomerList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);

            //foreach (var order in skipFirst2OrdersInWashington)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion


            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array
            //int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var takeWhilePositionCheck = numbers1
            //    .TakeWhile((n, index) => n >= index);

            //foreach (var num in takeWhilePositionCheck)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion


            #region 4. Get the elements of the array starting from the first element divisible by 3
            //int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers2
            //    .SkipWhile(n => n % 3 != 0);

            //foreach (var num in Result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion


            #region 5. Get the elements of the array starting from the first element less than its position
            //int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers3
            //    .SkipWhile((n, i) => n >= i);

            //foreach (var num in Result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion


            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var words = File.ReadAllLines("dictionary_english.txt");

            //bool hasEi = words.Any(w => w.Contains("ei", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine($"Any word contains 'ei': {hasEi}");
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var categoriesWithOutOfStock = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));

            //foreach (var category in categoriesWithOutOfStock)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var p in category)
            //    {
            //        Console.WriteLine($"   {p.ProductName} - Stock: {p.UnitsInStock}");
            //    }
            //}
            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var categoriesAllInStock = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));

            //foreach (var category in categoriesAllInStock)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var p in category)
            //    {
            //        Console.WriteLine($"   {p.ProductName} - Stock: {p.UnitsInStock}");
            //    }
            //}
            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var numberGroups = from n in numbers
            //                   group n by n % 5 into g
            //                   select new { Remainder = g.Key, Numbers = g };

            //foreach (var group in numberGroups)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Remainder} when divided by 5:");
            //    foreach (var num in group.Numbers)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            #endregion


            #region 2. Uses group by to partition a list of words by their first letter
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var wordGroups = from w in words
            //                 group w by w[0] into g
            //                 select new { FirstLetter = g.Key, Words = g };

            //foreach (var group in wordGroups)
            //{
            //    Console.WriteLine($"Words starting with {group.FirstLetter}:");
            //    foreach (var word in group.Words)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            #endregion


            #region 3. Use Group By with a custom comparer that matches words with same characters together
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var anagramGroups = Arr.GroupBy(
            //    w => new string(w.OrderBy(c => c).ToArray())
            //);

            //foreach (var group in anagramGroups)
            //{
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("----");
            //}
            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var productNames = ProductList.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordCases = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});

            //foreach (var wc in wordCases)
            //{
            //    Console.WriteLine($"Uppercase: {wc.Upper}, Lowercase: {wc.Lower}");
            //}
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice renamed to Price.
            //var productInfo = ProductList.Select(p => new
            //{
            //    p.ProductName,
            //    Price = p.UnitPrice,
            //    p.Category
            //});

            //foreach (var item in productInfo)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.Price}, Category: {item.Category}");
            //}
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numberCheck = Arr.Select((num, index) => new
            //{
            //    Number = num,
            //    InPlace = (num == index)
            //});

            //foreach (var item in numberCheck)
            //{
            //    Console.WriteLine($"Number: {item.Number}, In-place? {item.InPlace}");
            //}
            #endregion

            #endregion

        }
    }
}
