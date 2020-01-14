using Microsoft.Data.SqlClient;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SqlConnection con = new SqlConnection("Server=DESKTOP-6N9LEI7\\SQLEXPRESS;Database=pszero;User Id=dotnetdevel;Password =kki2020;Trusted_Connection=True;MultipleActiveResultSets=true;");
            con.Open();
            con.Close();
            //Scaffold-DbContext "Data Source =DESKTOP-6N9LEI7\\SQLEXPRESS; Initial Catalog = pszero; User ID = dotnetdevel; Password=kki2020;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir pszero
            //Server=DESKTOP-6N9LEI7\\SQLEXPRESS;Database=pszero;User Id=dotnetdevel;Password =kki2020;Trusted_Connection=True;MultipleActiveResultSets=true;

        }
    }
}
