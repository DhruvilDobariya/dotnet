using MySql.Data.MySqlClient;
using System.Data;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Threading.Tasks;

namespace NullOrEmptyColumnRemoveLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<NullAndEmpty>();
            //NullAndEmpty nullAndEmpty = new NullAndEmpty();
            //nullAndEmpty.SeventhApproach();
        }
    }

    [MemoryDiagnoser]
    public class NullAndEmpty
    {
        // private readonly string _connectionString = "Server=localhost; Database=JoinLearn; User=Admin; Password=gs@123;";
        private readonly string _connectionString = "Server=localhost; Database=JoinLearn; User=root; Password=Admin;";

        [Benchmark]
        public void FirstAppraoch()
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
                                if (!columnValue.ToString().Equals(DBNull.Value) &&
                                    !string.IsNullOrWhiteSpace(columnValue.ToString()))
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

        [Benchmark]
        public void SecondApproach()
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
                        foreach (DataRow schemaRow in schemaTable.Rows)
                        {
                            string columnName = schemaRow["ColumnName"].ToString();
                            Type dataType = (Type)schemaRow["DataType"];

                            bool isColumnEmptyOrNull = true;

                            foreach(DataRow row in  dt.Rows)
                            {
                                object columnValue = row[columnName];
                                if (!columnValue.ToString().Equals(DBNull.Value) &&
                                    !string.IsNullOrWhiteSpace(columnValue.ToString()))
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

        public void ThirdApproach()
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
                        foreach (DataColumn column in dt.Columns)
                        {
                            bool isColumnEmptyOrNull = true;
                            // string filterExpression = $"{column.ColumnName} IS NULL OR {column.ColumnName} Like ''";
                            // string filterExpression = $"{column.ColumnName} IS NULL OR {column.ColumnName} <> ''";
                            // string filterExpression = $"[{column.ColumnName}] IS NULL OR [{column.ColumnName}] = ''";
                            string filterExpression;
                            if (column.DataType == typeof(string))
                            {
                                filterExpression = $"{column.ColumnName} IS NULL OR {column.ColumnName} = ''";
                            }
                            else
                            {
                                // Convert the non-string columns to strings and then check for NULL or empty
                                filterExpression = $"CONVERT([{column.ColumnName}], 'System.String') IS NULL OR CONVERT([{column.ColumnName}], 'System.String') = ''";
                            }

                            DataRow[] filteredRows = dt.Select(filterExpression);
                            // if (dt.Rows.Count == filteredRows.Length)
                            {
                                Console.WriteLine($"{column.ColumnName} {filteredRows.Length}");
                            }

                            if (isColumnEmptyOrNull)
                            {
                                Console.WriteLine($"Column '{column.ColumnName}' is empty or contains NULL values.");
                            }
                            else
                            {
                                Console.WriteLine($"Column '{column.ColumnName}' is not empty or NULL.");
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

        [Benchmark]
        public void ThirdApproachMax()
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
                        foreach (DataColumn column in dt.Columns)
                        {
                            bool isColumnEmptyOrNull = false;
                            string filterExpression;
                            if (column.DataType == typeof(string))
                            {
                                filterExpression = $"{column.ColumnName} IS NULL OR {column.ColumnName} = ''";
                            }
                            else
                            {
                                filterExpression = $"CONVERT([{column.ColumnName}], 'System.String') IS NULL OR CONVERT([{column.ColumnName}], 'System.String') = ''";
                            }

                            DataRow[] filteredRows = dt.Select(filterExpression);
                            if (dt.Rows.Count == filteredRows.Length)
                            {
                                isColumnEmptyOrNull = true;
                            }

                            if (isColumnEmptyOrNull)
                            {
                                Console.WriteLine($"Column '{column.ColumnName}' is empty or contains NULL values.");
                            }
                            else
                            {
                                Console.WriteLine($"Column '{column.ColumnName}' is not empty or NULL.");
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

        public void FourthApproach()
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

        [Benchmark]
        public void FifthApproach()
        {
            string query = "SELECT * FROM student";
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    var dt = new DataTable();
                    dt.Load(reader);

                    foreach (DataColumn column in dt.Columns)
                    {
                        bool isColumnEmptyOrNull = dt.AsEnumerable()
                            .All(row => row.IsNull(column) || string.IsNullOrWhiteSpace(row[column].ToString()));

                        if (isColumnEmptyOrNull)
                        {
                            Console.WriteLine($"Column '{column.ColumnName}' is empty or contains NULL values.");
                        }
                        else
                        {
                            Console.WriteLine($"Column '{column.ColumnName}' is not empty or NULL.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        [Benchmark]
        public void SixthApproach()
        {
            string query = "SELECT * FROM student";
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    var dt = new DataTable();
                    dt.Load(reader);

                    foreach (DataColumn column in dt.Columns)
                    {
                        bool isColumnEmptyOrNull = !dt.AsEnumerable()
                            .Any(row => !row.IsNull(column) && !string.IsNullOrWhiteSpace(row[column].ToString()));

                        if (isColumnEmptyOrNull)
                        {
                            Console.WriteLine($"Column '{column.ColumnName}' is empty or contains NULL values.");
                        }
                        else
                        {
                            Console.WriteLine($"Column '{column.ColumnName}' is not empty or NULL.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        [Benchmark]
        public void SeventhApproach()
        {
            string query = "SELECT * FROM student";
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    var dt = new DataTable();
                    dt.Load(reader);

                    Parallel.ForEach(dt.Columns.Cast<DataColumn>(), column =>
                    {
                        bool isColumnEmptyOrNull = dt.AsEnumerable()
                            .All(row => row.IsNull(column) || string.IsNullOrWhiteSpace(row[column].ToString()));

                        if (isColumnEmptyOrNull)
                        {
                            Console.WriteLine($"Column '{column.ColumnName}' is empty or contains NULL values.");
                        }
                        else
                        {
                            Console.WriteLine($"Column '{column.ColumnName}' is not empty or NULL.");
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}