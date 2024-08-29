using System.Data;
using System.Data.SqlClient;

namespace DataSetLinq

    {

    public class program
        {
        static void Main(string[] args)
            {
            // disconnected architecture 
            // need to make connection

            string stringselect = "select * from Categories;" + "select * from Products;";

            SqlConnection sq = new SqlConnection("Data Source=.\\sqlexpress;Database=Northwind;Integrated Security=true;TrustServerCertificate=true");
            SqlDataAdapter adapter = new SqlDataAdapter(stringselect,sq);
            // from those i need 2 tables categories and product(catid) Fk in products

            adapter.TableMappings.Add("Table", "Categories");

            adapter.TableMappings.Add("Table1","Products");

            // Relation b/w two tables 
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            DataRelation dr = ds.Relations.Add("FK_Categories_Products",
                              ds.Tables["Categories"].Columns["CategoryID"],
                              ds.Tables["Products"].Columns["CategoryID"]);

            DataTable Category = ds.Tables["Categories"];
            DataTable Product = ds.Tables["Products"];


            var query = from c in Category.AsEnumerable()
                        join p in Product.AsEnumerable()
                        on c.Field<int>("CategoryID") equals p.Field<int>("CategoryID")
                        select new
                            {
                            prodid = p.Field<int>("ProductId"),
                            pname = p.Field<string>("ProductName"),
                            catid = c.Field<int>("CategoryID"),
                            catname = c.Field<string>("CategoryName")
                            };


            foreach (var q in query)
                {
                Console.WriteLine("prodid = {0} , pname = {1} , catid = {2} , catname ={3}",
                   q.prodid, q.pname, q.catid, q.catname);
                }
            Console.ReadLine();



            }
        }
    }