using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
                else throw new Exception("Ошибка открытия подключения!");
            }
            else throw new Exception("Ошибка подключения!");
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
        public static int Insert(string table_view, string[] columns, object[] values)
        {
            if (con == null || con.State != ConnectionState.Open)
                throw new Exception("Соединение не установлено");


            NpgsqlCommand com = con.CreateCommand();
            com.Connection = con;

            string columnsStr = string.Join(", ", columns);
            string valuesStr = string.Join(", ", columns.Select((_, i) => "@" + i));

            com.CommandText = $"INSERT INTO public.\"{table_view}\" ({columnsStr}) VALUES ({valuesStr}) RETURNING id";

            for (int i = 0; i < values.Length; i++)
            {
                com.Parameters.AddWithValue("@" + i, values[i] ?? DBNull.Value);
            }

            object result = com.ExecuteScalar();
            return Convert.ToInt32(result);

        }
        public static void Delete(string table_view, string id_name, int id)
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    NpgsqlCommand com = con.CreateCommand();
                    com.CommandText = $"DELETE FROM public.\"{table_view}\" WHERE \"{id_name}\" = @id";
                    com.Parameters.AddWithValue("@id", id);

                    com.ExecuteNonQuery();
                }
                else throw new Exception("Ошибка открытия подключения!");
            }
            else throw new Exception("Ошибка подключения!");
        }
        public static void Update(string table_view, string id_name, int id, string[] columns, object[] values)
        {
            if (con == null || con.State != ConnectionState.Open)
                throw new Exception("Соединение не установлено или закрыто");

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = con;

                string setClause = string.Join(", ", columns.Select((col, i) => $"\"{col}\" = @value{i}"));
                cmd.CommandText = $"UPDATE public.\"{table_view}\" SET {setClause} WHERE \"{id_name}\" = @id";

                for (int i = 0; i < values.Length; i++)
                {
                    cmd.Parameters.AddWithValue($"@value{i}", values[i] ?? DBNull.Value);
                }
                    cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
            }
        }
        public static Doctor GetDoctorById(int doctorId)
        {
            if (con == null || con.State != ConnectionState.Open)
            {
                MessageBox.Show("Соединение с БД не установлено.");
                return null;
            }
            string query = "SELECT * FROM doctor WHERE id = @id";

            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", doctorId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Doctor(reader["surname"].ToString(), reader["name"].ToString(), reader["patronymic"].ToString(), reader["gender"].ToString(), Convert.ToInt32(reader["age"]))
                        { Id = doctorId };
                    }
                }
            }
            return null;
        }
        public static bool AddMeeting(int patientId, int doctorId, DateTime start, DateTime end)
        {

            string query = @" INSERT INTO appointment (patient_id, doctor_id, start_time, end_time) VALUES (@patient_id, @doctor_id, @start_time, @end_time)";

            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@patient_id", patientId);
                cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                cmd.Parameters.AddWithValue("@start_time", start); 
                cmd.Parameters.AddWithValue("@end_time", end);

                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при назначении встречи: " + ex.Message);
                    return false;
                }
            }
        }
        public static List<List<string>> Select_all(string table_view)
        {
            List<List<string>> list = new List<List<string>>();
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    NpgsqlCommand com = con.CreateCommand();
                    com.CommandText = "Select * from public." + table_view;
                    NpgsqlDataReader dt = com.ExecuteReader(CommandBehavior.Default);
                    bool add_names = false;
                    while (dt.Read())
                    {
                        try
                        {
                            if (!add_names)
                            {
                                List<string> list_names = new List<string>();
                                for (int i = 0; i < dt.FieldCount; i++)
                                {
                                    list_names.Add(dt.GetName(i));
                                }
                                list.Add(list_names);
                                add_names = true;
                            }
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
                else throw new Exception("Не удалось установить соединение!");
            }
            else throw new Exception("Не подключено!");
            return list;
        }
        public static void ExportToExcel(string name)
        {
            List<List<string>> table = DBWorkSQL.Select_all(name);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = name,
                Filter = "Excel Files (*.xls)|*.xls",
                DefaultExt = "xls"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                {
                    foreach (string column in table[0])
                    {
                        writer.Write(column + "\t");
                    }
                    writer.WriteLine();

                    for (int i = 1; i < table.Count; i++)
                    {
                        foreach (string value in table[i])
                        {
                            writer.Write(value + "\t");
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Данные экспортированы в excel успешны.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }
        public static void ExportToHTML(string name)
        {
            List<List<string>> table = DBWorkSQL.Select_all(name);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = name,
                Filter = "HTML Files (*.html)|*.html",
                DefaultExt = "html"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine("<html>");
                    writer.WriteLine("<head>");
                    writer.WriteLine("<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\">");
                    writer.WriteLine("<title>" + name + "</title>");
                    writer.WriteLine("</head>");
                    writer.WriteLine("<body>");
                    writer.WriteLine("<table border=\"1\" align=\"center\">");

                    // Заголовки таблицы
                    writer.WriteLine("<tr>");
                    foreach (string column in table[0])
                    {
                        writer.WriteLine("<th>" + column + "</th>");
                    }
                    writer.WriteLine("</tr>");
                    // Строки данных
                    for (int i = 1; i < table.Count; i++)
                    {
                        writer.WriteLine("<tr>");
                        foreach (string value in table[i])
                        {
                            writer.WriteLine("<td>" + value + "</td>");
                        }
                        writer.WriteLine("</tr>");
                    }

                    writer.WriteLine("</table>");
                    writer.WriteLine("</body>");
                    writer.WriteLine("</html>");
                }

                MessageBox.Show("Data exported to HTML successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }
    }
}
