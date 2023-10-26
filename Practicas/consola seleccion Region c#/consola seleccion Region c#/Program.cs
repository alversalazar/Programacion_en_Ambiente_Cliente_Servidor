using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static DataSet ds = new DataSet();
    static SqlDataAdapter da = new SqlDataAdapter();
    static SqlConnection conexion;
    static string consulta;

    static void Main(string[] args)
    {
        string cadena = "Data Source=DESKTOP-KE2G5CS\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True";

        conexion = new SqlConnection(cadena);
        conexion.Open();

        consulta = "select * from Region order by RegionID";
        da = new SqlDataAdapter(consulta, conexion);
        da.Fill(ds, "Region");

        foreach (DataRow r in ds.Tables["Region"].Rows)
        {
            for (int c = 0; c < ds.Tables["Region"].Columns.Count; c++)
            {
                Console.Write(r.ItemArray[c].ToString() + " ");
            }
            Console.WriteLine();
        }

        conexion.Close();
    }
}











// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
