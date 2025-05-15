using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDepartment
{
    public class DBWorkSQL
    {
        private static NpgsqlConnection con;
        public static void OpenConnection()
        {
            string host = "localhost";
            string port = "5432";
            string databaseName = "Hospital";
            string user = "postgres";
            string password = "postpass";

            try
            {
                if (con != null)
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Dispose();
                }
                con = new NpgsqlConnection(
                    $"Server={host};Port={port};User Id={user};Password={password};Database={databaseName};"
                );

                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<List<string>> Select_n_k(string table_view, int n, int k)
        {
            List<List<string>> list = new List<List<string>>();
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    NpgsqlCommand com = con.CreateCommand();
                    com.CommandText = "SELECT * FROM public.\""
                        + table_view
                        + "\" LIMIT " + n.ToString()
                        + " OFFSET " + (n * k).ToString();
                    NpgsqlDataReader dt = com.ExecuteReader(CommandBehavior.Default);

                    List<string> list_names = new List<string>();
                    for (int i = 0; i < dt.FieldCount; i++)
                    {
                        list_names.Add(dt.GetName(i));
                    }
                    list.Add(list_names);

                    while (dt.Read())
                    {
                        try
                        {
                            List<string> inside_list = new List<string>();
                            for (int i = 0; i < dt.FieldCount; i++)
                            {
                                inside_list.Add(dt.GetValue(i).ToString());
                            }
                            list.Add(inside_list);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                    dt.Close();
                }
                else throw new Exception("Not Opened Connection!");
            }
            else throw new Exception("Not Connected!");
            return list;
        }
        public static int GetTotalRows(string table_view)
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                NpgsqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT COUNT(*) FROM public.\"" + table_view + "\"";
                return Convert.ToInt32(com.ExecuteScalar());
            }
            throw new Exception("Not Connected!");
        }
    }
}
