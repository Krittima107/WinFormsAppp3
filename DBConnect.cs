using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    internal class DBConnect
    {
        public static SqlConnection northwindConnection()
        {
            string connectionString = "Server=LAPTOP-OPD1OJ5F\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connectionString);

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
           
            con.Open();
            return con;
        }

        public static SqlConnection DBExampleConnection()
        {
            string connectionString = "Server=LAPTOP-OPD1OJ5F\\SQLEXPRESS;Database=TransactionLab;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connectionString);

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            return con;
        }

        public static SqlConnection Company_DB_Connect()
        {
            string connectionString = "Server=LAPTOP-OPD1OJ5F\\SQLEXPRESS;Database=Company_DB;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connectionString);

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            return con;
        }

        public static SqlConnection Beta_Academy_Connect()
        {
            string connectionString = "Server=LAPTOP-OPD1OJ5F\\SQLEXPRESS;Database=Beta_Academy;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connectionString);

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            return con;
        }


    }
}
