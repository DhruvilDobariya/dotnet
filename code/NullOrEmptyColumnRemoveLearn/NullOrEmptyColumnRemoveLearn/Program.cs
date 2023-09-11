using MySql.Data.MySqlClient;
using System.Data;

namespace NullOrEmptyColumnRemoveLearn
{
    public class Program
    {
        private readonly string _connectionString = "Server=localhost; Database=JoinLearn; User=Admin; Password=gs@123;";
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.SecondApproch();
        }

        public void FirstApproch()
        {
            string query = "SELECT * FROM student";
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    DataTable schemaTable = reader.GetSchemaTable();

                    if (schemaTable != null)
                    {
                        foreach (DataRow schemaRow in schemaTable.Rows)
                        {
                            string columnName = schemaRow["ColumnName"].ToString();
                            Type dataType = (Type)schemaRow["DataType"];

                            bool isColumnEmptyOrNull = true;

                            while (reader.Read())
                            {
                                object columnValue = reader[columnName];

                                //if (!reader.IsDBNull(reader.GetOrdinal(columnName)) && !string.IsNullOrWhiteSpace(columnValue.ToString()))
                                if (!columnValue.ToString().Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(columnValue.ToString()))
                                {
                                    isColumnEmptyOrNull = false;
                                    break;
                                }
                            }

                            if (isColumnEmptyOrNull)
                            {
                                Console.WriteLine($"Column '{columnName}' is empty or contains NULL values.");
                            }
                            else
                            {
                                Console.WriteLine($"Column '{columnName}' is not empty or NULL.");
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        public void SecondApproch()
        {
            string query = "SELECT * FROM student";
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    DataTable schemaTable = reader.GetSchemaTable();

                    var dt = new DataTable();
                    dt.Load(reader);

                    if (schemaTable != null)
                    {
                        //foreach (DataRow schemaRow in schemaTable.Rows)
                        //{
                        //    string columnName = schemaRow["ColumnName"].ToString();
                        //    Type dataType = (Type)schemaRow["DataType"];

                        //    bool isColumnEmptyOrNull = true;

                            //foreach (DataRow row in dt.Rows)
                            //{
                            //    //Console.WriteLine(row[columnName]);
                            //    object columnValue = row[columnName];

                            //    if (!columnValue.ToString().Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(columnValue.ToString()))
                            //    {
                            //        isColumnEmptyOrNull = false;
                            //        break;
                            //    }
                            //}

                            

                            foreach (DataColumn column in dt.Columns)
                            {
                                //column.Expression = $"{column} IS NOT NULL AND ${column} != ''";
                                //if (column.DataType != )
                                string filterExpression = $"{column.ColumnName} IS NULL OR {column.ColumnName} Like ''";
                                DataRow[] filteredRows = dt.Select(filterExpression);
                                Console.WriteLine(filteredRows.Length);
                            }

                            //if (isColumnEmptyOrNull)
                            //{
                            //    Console.WriteLine($"Column '{columnName}' is empty or contains NULL values.");
                            //}
                            //else
                            //{
                            //    Console.WriteLine($"Column '{columnName}' is not empty or NULL.");
                            //}

                        //}
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void ThirdApproch()
        {
            //string query = @"SELECT COLUMN_NAME
            //                    FROM INFORMATION_SCHEMA.COLUMNS
            //                    WHERE TABLE_NAME = 'student'
            //                    AND (
            //                        SELECT COUNT(*)
            //                        FROM student
            //                        WHERE COLUMN_NAME IS NOT NULL AND COLUMN_NAME != ''
            //                    ) = 0
            //                    ";

            string query = @"SELECT c.COLUMN_NAME
                                FROM INFORMATION_SCHEMA.COLUMNS c
                                LEFT JOIN (
                                    SELECT COLUMN_NAME
                                    FROM student
                                    WHERE COLUMN_NAME IS NOT NULL AND COLUMN_NAME != ''
                                ) s ON c.COLUMN_NAME = s.COLUMN_NAME
                                WHERE c.TABLE_NAME = 'student'
                                AND s.COLUMN_NAME IS NULL;
                                ";
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"Column '{reader[0]}' is not empty or NULL.");
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
