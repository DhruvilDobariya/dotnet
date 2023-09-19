using MySql.Data.MySqlClient;
using System.Data;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace NullOrEmptyColumnRemoveLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<NullAndEmpty>();
            //NullAndEmpty nullAndEmpty = new NullAndEmpty();
            //nullAndEmpty.FirstApproachDetermineWithHashSetWithMax();
        }
    }

    [MemoryDiagnoser]
    public class NullAndEmpty
    {
        private readonly string _connectionString = "Server=localhost; Database=JoinLearn; User=Admin; Password=gs@123;";
        //private readonly string _connectionString = "Server=localhost; Database=JoinLearn; User=root; Password=Admin;";

        [Benchmark]
        public void FirstAppraoch()
        {
            string query = "SELECT * FROM student LIMIT 10000";
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
                            int count = 0;

                            while (reader.Read())
                            {
                                //object columnValue = reader[columnName];
                                //Console.WriteLine(reader);

                                //if (!reader.IsDBNull(reader.GetOrdinal(columnName)) && !string.IsNullOrWhiteSpace(columnValue.ToString()))
                                count++;
                                if (!reader[columnName].Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(reader[columnName].ToString()))
                                {
                                    isColumnEmptyOrNull = false;
                                    break;
                                }
                                if(count == 5)
                                {
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
                            //reader.Close();
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
        public void FirstApproachSwap()
        {
            string query = "SELECT * FROM student LIMIT 10000";
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataTable schemaTable = reader.GetSchemaTable();
                int columnCount = 0;
                if (schemaTable != null)
                {
                    columnCount = schemaTable.Rows.Count;
                    //BitArray bits = new BitArray(columnCount);
                    bool[] bits = new bool[columnCount]; 
                    //bits.SetAll(true);
                    Array.Fill(bits, true);

                    //DataRow schemaRow = schemaTable.;
                    while (reader.Read())
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            DataRow schemaRow = schemaTable.Rows[i];
                            string columnName = schemaRow["ColumnName"].ToString();

                            if (!bits[i])
                            {
                                continue;
                            }
                            if (!reader[columnName].Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(reader[columnName].ToString()))
                            {
                                //bits.Set(i, false);
                                bits[i] = false;
                            }
                        }
                    }
                    for (int i = 0; i < columnCount; i++)
                    {
                        if (!bits[i])
                        {
                            Console.WriteLine($"Column '{schemaTable.Rows[i]["ColumnName"]}' is not empty or NULL.");
                        }
                        //else
                        //{
                        //    Console.WriteLine($"Column '{schemaTable.Rows[i]["ColumnName"]}' is empty or contains NULL values.");
                        //}
                    }
                }
            }


        }

        [Benchmark]
        public void FirstApproachDetermine()
        {
            string query = "SELECT * FROM student LIMIT 1";
            List<string> neededColumns = new List<string>();
            List<string> unusedColumn = new List<string>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataTable schemaTable = reader.GetSchemaTable();
                if (schemaTable != null)
                {
                    int columnCount = schemaTable.Rows.Count;

                    while (reader.Read())
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            DataRow schemaRow = schemaTable.Rows[i];
                            string columnName = schemaRow["ColumnName"].ToString();

                            if (!reader[columnName].Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(reader[columnName].ToString()))
                            {
                                neededColumns.Add(columnName);
                            }
                            else
                            {
                                unusedColumn.Add(columnName);
                            }
                        }
                    }

                }
                reader.Close();
                query = $"Select {string.Join(',', unusedColumn)} FROM Student LIMIT 10000";
                unusedColumn.Clear();
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();

                schemaTable = reader.GetSchemaTable();
                if (schemaTable != null)
                {
                    int columnCount = schemaTable.Rows.Count;

                    while (reader.Read())
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            DataRow schemaRow = schemaTable.Rows[i];
                            string columnName = schemaRow["ColumnName"].ToString();

                            if (!reader[columnName].Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(reader[columnName].ToString()))
                            {
                                neededColumns.Add(columnName);
                            }
                        }
                    }


                }
                foreach (string columnName in neededColumns)
                {
                    Console.WriteLine($"Column '{columnName}' is not empty or NULL.");
                }
            }

        }

        [Benchmark]
        public void FirstApproachDetermineWithHashSet()
        {
            string query = "SELECT * FROM student LIMIT 1";
            HashSet<string> neededColumns = new HashSet<string>();
            HashSet<string> unusedColumn = new HashSet<string>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataTable schemaTable = reader.GetSchemaTable();
                if (schemaTable != null)
                {
                    int columnCount = schemaTable.Rows.Count;

                    while (reader.Read())
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            DataRow schemaRow = schemaTable.Rows[i];
                            string columnName = schemaRow["ColumnName"].ToString();

                            if (!reader[columnName].Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(reader[columnName].ToString()))
                            {
                                neededColumns.Add(columnName);
                            }
                            else
                            {
                                unusedColumn.Add(columnName);
                            }
                        }
                    }

                }
                reader.Close();
                query = $"Select {string.Join(',', unusedColumn)} FROM Student LIMIT 10000";
                unusedColumn.Clear();
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();

                schemaTable = reader.GetSchemaTable();
                if (schemaTable != null)
                {
                    int columnCount = schemaTable.Rows.Count;
                   

                    while (reader.Read())
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            DataRow schemaRow = schemaTable.Rows[i];
                            string columnName = schemaRow["ColumnName"].ToString();

                            if (!reader[columnName].Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(reader[columnName].ToString()))
                            {
                                neededColumns.Add(columnName);
                                schemaTable.Rows.Remove(schemaRow);
                                columnCount = schemaTable.Rows.Count;
                            }
                        }
                    }


                }
                foreach (string columnName in neededColumns)
                {
                    Console.WriteLine($"Column '{columnName}' is not empty or NULL.");
                }
            }

        }

        [Benchmark]
        public void FirstApproachDetermineWithHashSetWithMax()
        {
            string query = "SELECT * FROM student LIMIT 1";
            HashSet<string> neededColumns = new HashSet<string>();
            HashSet<string> unusedColumn = new HashSet<string>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataTable schemaTable = reader.GetSchemaTable();
                if (schemaTable != null)
                {
                    int columnCount = schemaTable.Rows.Count;

                    while (reader.Read())
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            DataRow schemaRow = schemaTable.Rows[i];
                            string columnName = schemaRow["ColumnName"].ToString();

                            if (!reader[columnName].Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(reader[columnName].ToString()))
                            {
                                neededColumns.Add(columnName);
                            }
                            else
                            {
                                unusedColumn.Add(columnName);
                            }
                        }
                    }

                }
                reader.Close();
                query = $"Select {string.Join(',', unusedColumn)} FROM Student LIMIT 10000";
                unusedColumn.Clear();
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();

                schemaTable = reader.GetSchemaTable();
                if (schemaTable != null)
                {
                    int columnCount = schemaTable.Rows.Count;


                    while (reader.Read())
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            DataRow schemaRow = schemaTable.Rows[i];
                            string columnName = schemaRow["ColumnName"].ToString();

                            if (!reader[columnName].Equals(DBNull.Value) && !string.IsNullOrWhiteSpace(reader[columnName].ToString()))
                            {
                                neededColumns.Add(columnName);
                                schemaTable.Rows.Remove(schemaRow);
                                columnCount = schemaTable.Rows.Count;
                            }
                        }
                    }


                }
                foreach (string columnName in neededColumns)
                {
                    Console.WriteLine($"Column '{columnName}' is not empty or NULL.");
                }
            }

        }

        [Benchmark]
        public void SecondApproach()
        {
            string query = "SELECT * FROM student LIMIT 10000";
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

                            foreach (DataRow row in dt.Rows)
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
            string query = "SELECT * FROM student LIMIT 10000";
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
            string query = "SELECT * FROM student LIMIT 10000";
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
            string query = "SELECT * FROM student LIMIT 10000";
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
            string query = "SELECT * FROM student LIMIT 10000";
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