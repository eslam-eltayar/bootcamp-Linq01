using Linq01;
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

        var result = ProductsList.Select(p => new { Id = p.ProductID, Price = p.UnitPrice * .8m });


        foreach (var item in result)
        {
            Console.WriteLine(item);
        }



    }
}