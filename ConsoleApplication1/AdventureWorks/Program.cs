using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace AdventureWorks
{
   
    class Program
    {
        

        static void Main(string[] args)
        {
            QueryAW();
            Console.ReadLine();


        }

        private static void QueryAW()
        {
            using (var dbContext = new Model1())
            {
               
                // wersja z zajęć 
                var allproducts = dbContext.Products;
                foreach (var product in allproducts.Where(p=>p.ProductReviews.Any()).Include(p=>p.ProductReviews))
                {
                    Console.WriteLine();
                    Console.WriteLine(product.Name);
                    foreach (var review in product.ProductReviews)
                    {
                        Console.WriteLine(review.Comments);
                    }
                }






                //var recenzja = from a in dbContext.ProductReviews
                //               join b in dbContext.Products on a.ProductID equals b.ProductID
                //               select new { ProductName = b.Name, Review = a.Comments};



                //foreach (var rec in recenzja)
                //{
                //    Console.WriteLine($"{rec.ProductName,-35} | {rec.Review}");
                //}




                //var sprzedaz = from a in dbContext.SalesOrderDetails
                //               join b in dbContext.Products on a.ProductID equals b.ProductID
                //               group a by b into saleProduct

                //               select saleProduct;


                //////foreach (var ab in sprzedaz)
                //////{
                //////    Console.WriteLine($"{ab.ProductName,-35} | {ab.Quantity,-15}");
                //////}



                //foreach (var ab in sprzedaz)
                //{
                //    Console.WriteLine($"Produkt: {ab.Key.ProductID,-5}  {ab.Key.Name,-35} | sprzedaż: {ab.Sum(s=>s.OrderQty)}");
                //}



                var sprzedazPerDate = from a in dbContext.SalesOrderDetails
                                      join b in dbContext.SalesOrderHeaders on a.SalesOrderID equals b.SalesOrderID
                                      orderby b.OrderDate ascending
                                      select new {OrderID = a.SalesOrderID, Date = b.OrderDate}
                                     ;

                               

                foreach (var ab in sprzedazPerDate)
                {
                    Console.WriteLine($"Produkt: {ab.OrderID,-5} | rok: {ab.Date,-35}");
                }








            }



        }
    }
}
