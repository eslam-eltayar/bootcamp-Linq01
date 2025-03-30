using Linq01;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static Linq01.ListGenerator;
internal class Program
{
    private static void Main(string[] args)
    {

        #region Var - dynamic [Implicitly type local var]
        // Var - dynamic [Implicitly type local var]

        //int x = 10;
        //string name = "John";
        //bool isTrue = true;

        //var data = 22.5; // double
        // Must be initialized
        // Cannot be intialized with =>  null
        // cannot change after initialization (dataType)
        // compiler will detect the type [Compilation Time]


        //dynamic x = 10;
        //dynamic y = 20;
        //Console.WriteLine(x + y);

        // CLR will detect the type [at Runtime]
        // Not must intialized
        // can be intialized with =>  null
        // can change after initialization (dataType) 
        #endregion

        #region Extension Methods
        //Extension Methods

        // num = 123456
        // num => 654321

        //int x = 123456;

        //int y = x.ReverseNumber();

        //Console.WriteLine(y); 
        #endregion

        #region Anonymous Type
        // Anonymous Type

        //Employee employee01 = new Employee
        //{
        //    Id = 1,
        //    Name = "John",
        //    Age = 25,
        //    Salary = 5000
        //};

        ////Console.WriteLine($"Id : {employee01.Id} - Name: {employee01.Name} - Age : {employee01.Age}");

        //var e01 = new 
        //{
        //    Id = 10,
        //    FirstName = "Eslam",
        //    LastName = "Saeed",
        //    Age = 21,

        //};

        //Console.WriteLine(e01);
        //Console.WriteLine(e01.GetType().Name); 
        #endregion

        #region What's the LINQ
        // LINQ - Language Integrated Query

        // LINQ => stands for Language Integrated Query
        // LINQ => +40 Extension Methods
        // LINQ => Query Operators 
        // Sequence => inheret IEnumerable<T> interface - local -> Static Data L2Object , XML file L2Xml
        //                                              - Remote -> Database L2EF

        #endregion

        #region LINQ Syntax
        //1. Fluent Syntax


        // 1.1 Static Method

        //var oddNumbers = Enumerable.Where(Numbers, (n) => n % 2 == 1);

        // 1.2 Extension Method

        //var oddNumbers = Numbers.Where((n) => n % 2 == 1);

        // 2. Query Syntax

        //var oddNumbers = from N in Numbers
        //                 where N % 2 == 1
        //                 select N; 
        #endregion

        #region LINQ Execution ways
        // LINQ Execution ways 

        // 1. Deferred Execution

        //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //var evenNumbers = Numbers.Where(N => N % 2 == 0);

        //Numbers.Remove(10);

        //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

        // 2. Immediate Execution

        //var evenNumbers = Numbers.Where(N => N % 2 == 0);

        //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

        //foreach (var item in evenNumbers)
        //{
        //    Console.Write($"{item}, ");
        //} 
        #endregion

        #region Select - Select Many
        // Test on Data Setup

        //Console.WriteLine(ListGenerator.ProductsList[0]);

        //1. Where 

        // Ex01 => Get Elements Out Of Stock

        // Fluent Syntax

        //var result = ProductsList.Where(p => p.UnitsInStock == 0); // out of stock 

        // Query Syntax

        //result = from P in ProductsList
        //         where P.UnitsInStock == 0
        //         select P;

        // Ex02 => Get Elements In Stock And In Category Of Meat/Poultry 

        // 1. Fluent 

        //var result = ProductsList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry");

        // 2. Query

        //var result = from p in ProductsList
        //         where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
        //         select p;


        // Ex03 => Select Product Name

        // Fluent

        //var result = ProductsList.Select(p => p.ProductName); 

        // Query 

        //result = from p in ProductsList
        //         select p.ProductName;

        // Ex 04 => Select Customer Orders

        // 1. Fluent

        //var result = CustomersList
        //    .Where(c=>c.CustomerID == "212")
        //    .SelectMany(c => c.Orders);

        // 2. Query 

        //var result = from c in CustomersList
        //             from o in c.Orders
        //             select o.OrderDate;


        // Select as Anonymous Type

        //var result = ProductsList.Select(p => new { Id = p.ProductID, Price = p.UnitPrice * .8m });


        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion

        #region Ordering Operators [Asc - Dsc]

        /// Order By Asc

        //var result = ProductsList.Select(p => new { p.ProductName, p.UnitsInStock })
        //                         .OrderBy(p => p.UnitsInStock);

        /// Order By Dcs

        //var result = ProductsList.Select(p => new { p.ProductName, p.UnitsInStock })
        //                         .OrderByDescending(p => p.UnitsInStock);

        /// Order By Mulipule Columns

        //var result = ProductsList.OrderBy(p => p.UnitsInStock)
        //                         .ThenBy(p => p.UnitPrice);



        //var result = ProductsList.OrderBy(p => p.UnitsInStock)
        //                         .ThenByDescending(p => p.UnitPrice);


        //var result = ProductsList.OrderBy(p => p.UnitsInStock)
        //                         .OrderByDescending(p => p.UnitPrice).Take(4);

        /// Reverse Method ()

        //var result = ProductsList.OrderBy(p => p.UnitsInStock)
        //                        .OrderByDescending(p => p.UnitPrice).Take(4).Reverse();


        #endregion

        #region Elements Operator - Immediate Execution [Valid Only With Fluent Syntax]

        /// First - Last


        // var result = ProductsList.First();

        //var result = ProductsList.Last();

        //List<Product> products = new List<Product>(); // Empty list 

        /// FirstOrDefault - LastOrDefault

        //var result = products.FirstOrDefault();

        //if(result == null)
        //    Console.WriteLine("Null");
        //else
        //    Console.WriteLine(result);

        /// Element At

        //var result = ProductsList.ElementAt(1);

        /// ElementAtOrDefault

        //var result = ProductsList.ElementAtOrDefault(200);

        //if (result == null)
        //    Console.WriteLine("Null");
        //else
        //    Console.WriteLine(result);


        /// Single 
        /// 

        // List<Product> products = new List<Product>();

        //products.Add(ProductsList[0]);

        //var result = ProductsList.SingleOrDefault();
        // if Seqence is Empty => returns Null
        // if sequence contains just only one element => returns element 
        // if sequence contains more than one element 


        //if (result == null)
        //    Console.WriteLine("Null");
        //else
        //    Console.WriteLine(result);

        //Console.WriteLine(result);

        #endregion

        #region  Aggregate Operators  - Immediate Execution

        /// Count()

        //var result = ProductsList.Count();

        //var result = ProductsList.Count(p => p.UnitsInStock == 0);

        /// Max

        //var result = ProductsList.Max();

        //var result = ProductsList.Min();

        /// Sum

        //var result = ProductsList.Sum(p => p.UnitPrice);

        //var result = ProductsList.Average(p => p.UnitPrice);

        /// Aggregate

        //string[] names = { "Ahmed", "Ali", "Eslam", "Hassan" };

        //var result = names.Aggregate((string01, string02) => $"{string01} // {string02}");

        //Console.WriteLine(result);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion


        #region Casting [Conversion] Operators - Immediate Execution

        //List<Product> result = ProductsList.Where(p => p.UnitsInStock == 0).ToList(); // To List

        //Product[] result = ProductsList.Where(p => p.UnitsInStock == 0).ToArray(); // To Array

        //Dictionary<long, Product> result = ProductsList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);

        //Dictionary<long, string> result = ProductsList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID, p => p.ProductName);

        //HashSet<Product> result = ProductsList.Where(p => p.UnitsInStock == 0).ToHashSet(); // To HashSet


        /// OfType<>

        //ArrayList obj = new ArrayList()
        //{
        //    "Omar",
        //    "Eslam",
        //    "Hassan",
        //    1,
        //    2,
        //    3,
        //    'H',
        //    'V'
        //};

        //var result = obj.OfType<char>(); 


        #endregion


        #region Generation Operators - Deferred Execution

        // Valid with Fluent Syntax only 
        // The Only Way To Call Them is As Static Methods from Enumerable Class

        /// Range()

        //var result = Enumerable.Range(0, 100); // 0 .. 99

        /// Repeat()

        //var result = Enumerable.Repeat(1, 5);

        //var result = Enumerable.Repeat(ProductsList[0], 5);

        //var arrayProduct = Enumerable.Empty<Product>();

        //Product[] empty = [];

        // Both will Generate Empty Array of Product



        #endregion

        #region Set Operators [Union Family] - Deferred Execution

        //var sec01 = Enumerable.Range(0, 100);
        //var sec02 = Enumerable.Range(50, 149);

        //var result = sec01.Union(sec02); // WithOut Duplication 

        //var result = sec01.Concat(sec02); // With Duplication 

        //var result = sec01.Intersect(sec02); // Return Elements in 1st Sequence and Exist in 2nd Sequence 

        //var result = sec01.Except(sec02);
        //var result = sec02.Except(sec01);

        // var result = sec01.Concat(sec02); // With Duplication 

        // var uniqueResult = result.Distinct();

        //Console.WriteLine("\n--------------------------------Seq01------------------------------------------");


        //foreach (var item in sec01)
        //{
        //    Console.Write($"{item} ");
        //}

        //Console.WriteLine("\n---------------------------------Seq02-----------------------------------------");

        //foreach (var item in sec02)
        //{
        //    Console.Write($"{item} ");
        //}

        //Console.WriteLine("\n----------------------------------Result----------------------------------------");

        //foreach (var item in result)
        //{
        //    Console.Write($"{item} ");

        //}

        //Console.WriteLine("\n----------------------------------Unique Result----------------------------------------");

        //foreach (var item in uniqueResult)
        //{
        //    Console.Write($"{item} ");

        //}


        #endregion

        #region Quantifier Operator - Return boolean

        /// Any => If Sequence contains at least one Element Will Return True

        //var result = ProductsList.Any(p => p.UnitPrice == 0);

        /// All => If All Elements in Sequence Match Condition Will Return True 

        //var result = ProductsList.All(p => p.UnitsInStock >= 0);

        /// SequenceEqual => If Two Sequences are Equal Will Return True 

        //var sec01 = Enumerable.Range(0, 100);
        //var sec02 = Enumerable.Range(0, 101);

        //var result = sec01.SequenceEqual(sec02);

        //Console.WriteLine(result); // True or False 
        #endregion

        #region Zipping Operator - ZIP

        //string[] names = { "Omar", "Ahmed", "Zeyad", "Eslam" };
        //int[] numbers = { 1, 2, 3 };
        //char[] chars = { 'a', 'b' };

        ////var result = names.Zip(chars);

        ////var result = names.Zip(numbers,chars);

        //var result = names.Zip(numbers, (name, number) => new { Index = number, Name = name });

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Grouping Operators

        //Get Products Grouped by Category

        /// Query Synatx

        //var result = from p in ProductsList
        //             group p by p.Category;

        /// Fluent Syntax 

        // var result = ProductsList.GroupBy(p => p.Category);

        //Get Products in Stock Grouped by Category

        // Query Syntax

        //var result = from p in ProductsList
        //             where p.UnitsInStock > 0
        //             group p by p.Category;

        // Fluent Syntax

        //var result = ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);

        // Get Products in Stock Grouped by Category That Contains More Than 10 Product

        /// Query Syntax

        //var result = from p in ProductsList
        //             where p.UnitsInStock > 0
        //             group p by p.Category
        //             into Categories
        //             where Categories.Count() > 10
        //             select Categories;


        /// Fluent Syntax

        //var result = ProductsList.Where(p => p.UnitsInStock > 0)
        //                         .GroupBy(p => p.Category)
        //                         .Where(p => p.Count() > 10);


        // Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category

        /// Fluent Syntax

        //var result = ProductsList.Where(p => p.UnitsInStock > 0)
        //                         .GroupBy(p => p.Category)
        //                         .Where(p => p.Count() > 10)
        //                         .Select(x => new
        //                         {
        //                             CategoryName = x.Key,
        //                             ProductCount = x.Count(),
        //                         });


        /// Query Syntax

        //var result = from p in ProductsList
        //             where p.UnitsInStock > 0
        //             group p by p.Category
        //             into Categories
        //             where Categories.Count() > 10
        //             select new
        //             {
        //                 CategoryName = Categories.Key,
        //                 ProductCount = Categories.Count(),
        //             };


        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Partitioning Operators [Pagination Operators]
        /// Take => Take Number of Elements From First Only 

        //var result = ProductsList.Take(7);

        /// Skip => Skip Number of Elements From First And Get Rest Of Elements

        //var result = ProductsList.Where(p => p.UnitsInStock > 0).Skip(5);


        /// TakeLast => Take Number of Elements From Last Only

        // var result = ProductsList.TakeLast(7);

        //var result = ProductsList.SkipLast(7);

        /// TakeWhile => Take Elements Till Element That do not Match Condition

        // int[] numbers = { 5, 7, 9, 2, 8, 3, 0, 10, 25, 4 };

        //var result = numbers.TakeWhile(num => num % 2 == 1);

        /// SkipWhile => Skip Elements Till Element That do not Match Condition

        //var result = numbers.SkipWhile(num => num % 2 == 1);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}





        #endregion

        #region Let and Into [Valid With Query Syntax Only]

        /// into => Restart Query With Introducing A new Range 

        // List<string> names = new List<string> { "Omar", "Ali", "Eslam", "Aya", "Hassan" };

        // A , O , U , I , E

        //var result = from N in names
        //             select Regex.Replace(N, "[AOUIEaoiea]", string.Empty)
        //             into NonVowel
        //             where NonVowel.Length > 3
        //             select NonVowel;


        // let => Continue Query With Added A new Range

        //var result = from N in names
        //             let NonVowel = Regex.Replace(N, "[AOUIEaoiea]", string.Empty)
        //             where NonVowel.Length > 3
        //             select NonVowel; 


        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);   
        //}
        #endregion

        //foreach (var category in result)
        //{
        //    Console.WriteLine(category.Key);

        //    foreach (var product in category)
        //    {
        //        Console.WriteLine($"                        {product.ProductName}  -  {product.Category} -  {product.UnitsInStock}");
        //    }
        //}
    }
}