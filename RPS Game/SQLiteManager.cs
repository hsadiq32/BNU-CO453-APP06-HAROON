using System;
using System.Data.SQLite;

namespace RPS_Game
/// <summary>
/// This class utilises SQLite database management for the console version of my app.
/// </summary>
/// <author>
/// Haroon Sadiq
/// </author>
{
    class SQLiteManager
    {
        // For user queries
        //Finds current directory using relative locations
        public string DirectoryFinder(string filename)
        {
            string parentDir = System.AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = @"App06\Database\" + filename;
            parentDir = parentDir.Remove(parentDir.Length - 24, 24);
            return parentDir + relativePath;
        }
        // Executes SQLite commands requiring no output (e.g. create, delete, change)
        public void ExecuteNonQuery(string queryString, string filename)
        {
            // Creates a SQLite connection to the database file
            using (var connection = new SQLiteConnection("Data Source=" + DirectoryFinder(filename) + ";Version=3;"))
            {
                // Executes SQL command once connected
                using (var command = new SQLiteCommand(queryString, connection))
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        // Executes SQLite commands requiring an output (e.g. read/find, read all)
        public string ExecuteQuery(string queryString, string filename)
        {
            string data = null;
            using (var connection = new SQLiteConnection("Data Source=" + DirectoryFinder(filename) + ";Version=3;"))
            {
                using (var command = new SQLiteCommand(queryString, connection))
                {
                    command.Connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (queryString.Contains("WHERE") || queryString.Contains("max") || queryString.Contains("min") || queryString.Contains("count") || queryString.Contains("avg"))
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    data = reader[0].ToString();
                                }
                                catch (InvalidOperationException)
                                {

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(syntaxGen.SyntaxFiller1(" ┌────┬──────────────────────────────┬─────┬─────┐"));
                            Console.WriteLine(syntaxGen.SyntaxFiller1(" │" + $@"{reader.GetName(0),-4}│{reader.GetName(1),-30}│{reader.GetName(2),5}│{reader.GetName(3),5}" + "│"));
                            Console.WriteLine(syntaxGen.SyntaxFiller1(" ├────┼──────────────────────────────┼─────┼─────┤"));
                            while (reader.Read())
                            {
                                try
                                {
                                    Console.WriteLine(syntaxGen.SyntaxFiller1(" │" + $@"{reader[0].ToString(),-4}│{reader[1].ToString(),-30}│{reader[2].ToString(),5}│{reader[3].ToString(),5}" + "│"));
                                }
                                catch (InvalidCastException e)
                                {
                                    Console.WriteLine(e);
                                }
                            }
                            Console.WriteLine(syntaxGen.SyntaxFiller1(" └────┴──────────────────────────────┴─────┴─────┘"));
                        }
                    }
                }
            }
            return data;
        }
        // Failsafe to create table if not made already
        public void InitialiseTable()
        {
            ExecuteNonQuery("CREATE TABLE IF NOT EXISTS ResultsLog (ID INTEGER PRIMARY KEY, UserChoice STRING NOT NULL, BotChoice STRING NOT NULL, Verdict STRING)", "DatabaseLog.csv");
            ExecuteNonQuery("CREATE TABLE IF NOT EXISTS UserData (ResultsLogID INTEGER, R INTEGER DEFAULT 0, P INTEGER DEFAULT 0, S INTEGER DEFAULT 0, FOREIGN KEY(ResultsLogID) REFERENCES ResultsLog(ID))", "DatabaseLog.csv");

        }
        // Inserts data into database tables
        public void InsertDB(string table, string columns, string columnData)
        {
            ExecuteNonQuery("INSERT INTO " + table + " (" + columns + ") VALUES (" + columnData + ")", "DatabaseLog.csv");
        }
        // Outputs all of the database tables content
        public void ReadAllDB(string table)
        {
            ExecuteQuery("SELECT * FROM " + table, "DatabaseLog.csv");
        }
        // Outputs a single data cell with conditionals to locate the correct data
        public string ReadDB(string table, string targetColumn, string where)
        {
            return ExecuteQuery("SELECT " + targetColumn + " FROM " + table + " WHERE " + where, "DatabaseLog.csv");
        }
        // Finds max value in a given column
        public string ReadMaxValDB(string table, string targetColumn)
        {
            return ExecuteQuery("SELECT max(" + targetColumn + "), * FROM " + table, "DatabaseLog.csv");
        }
        // Finds min value in a given column
        public string ReadMinValDB(string table, string targetColumn)
        {
            return ExecuteQuery("SELECT min(" + targetColumn + "), * FROM " + table, "DatabaseLog.csv");
        }
        // Counts the amount of data in a specific column which can be a good indicator for blank tables (no data)
        public string CountColumnDB(string table, string targetColumn, string where)
        {
            return where.Equals("none")
                ? ExecuteQuery("SELECT count(" + targetColumn + "), * FROM " + table + " WHERE ", "DatabaseLog.csv")
                : ExecuteQuery("SELECT count(" + targetColumn + "), * FROM " + table + " WHERE " + where, "DatabaseLog.csv");
        }
        // Gets average amount using columns data
        public string ColumnAverageDB(string table, string targetColumn, string where)
        {
            return where.Equals("none")
                ? ExecuteQuery("SELECT avg(" + targetColumn + ") FROM " + table, "DatabaseLog.csv")
                : ExecuteQuery("SELECT avg(" + targetColumn + "), * FROM " + table + " WHERE " + where, "DatabaseLog.csv");
        }
        // Appends any data already stored
        public void UpdateDB(string table, string targetColumn, string where)
        {
            ExecuteNonQuery("UPDATE " + table + " SET " + targetColumn + " WHERE " + where, "DatabaseLog.csv");
        }
        // Deletes rows using conditionals to locate the row
        public void DeleteRowDB(string table, string where)
        {
            ExecuteNonQuery("DELETE FROM " + table + " WHERE " + where, "DatabaseLog.csv");
        }
        // Returns max value of a column
        public string ReadMaxValGradeDB(string table, string targetColumn, string where)
        {
            return ExecuteQuery("SELECT max(" + targetColumn + "), * FROM " + table + " WHERE " + where, "GradeData.db");
        }
        // Gets grade data (e.g. A,B,C,D,F)
        public string ReadGradeDB(string table, string targetColumn, string where)
        {
            return ExecuteQuery("SELECT " + targetColumn + " FROM " + table + " WHERE " + where, "GradeData.db");
        }
    }
    class SQLiteManager
    {
        // For user queries
        //Finds current directory using relative locations
        public string DirectoryFinder(string filename)
        {
            string parentDir = System.AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = @"App06\Database\" + filename;
            parentDir = parentDir.Remove(parentDir.Length - 24, 24);
            return parentDir + relativePath;
        }
        // Executes SQLite commands requiring no output (e.g. create, delete, change)
        public void ExecuteNonQuery(string queryString, string filename)
        {
            // Creates a SQLite connection to the database file
            using (var connection = new SQLiteConnection("Data Source=" + DirectoryFinder(filename) + ";Version=3;"))
            {
                // Executes SQL command once connected
                using (var command = new SQLiteCommand(queryString, connection))
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        // Executes SQLite commands requiring an output (e.g. read/find, read all)
        public string ExecuteQuery(string queryString, string filename)
        {
            string data = null;
            using (var connection = new SQLiteConnection("Data Source=" + DirectoryFinder(filename) + ";Version=3;"))
            {
                using (var command = new SQLiteCommand(queryString, connection))
                {
                    command.Connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (queryString.Contains("WHERE") || queryString.Contains("max") || queryString.Contains("min") || queryString.Contains("count") || queryString.Contains("avg"))
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    data = reader[0].ToString();
                                }
                                catch (InvalidOperationException)
                                {

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(syntaxGen.SyntaxFiller1(" ┌────┬──────────────────────────────┬─────┬─────┐"));
                            Console.WriteLine(syntaxGen.SyntaxFiller1(" │" + $@"{reader.GetName(0),-4}│{reader.GetName(1),-30}│{reader.GetName(2),5}│{reader.GetName(3),5}" + "│"));
                            Console.WriteLine(syntaxGen.SyntaxFiller1(" ├────┼──────────────────────────────┼─────┼─────┤"));
                            while (reader.Read())
                            {
                                try
                                {
                                    Console.WriteLine(syntaxGen.SyntaxFiller1(" │" + $@"{reader[0].ToString(),-4}│{reader[1].ToString(),-30}│{reader[2].ToString(),5}│{reader[3].ToString(),5}" + "│"));
                                }
                                catch (InvalidCastException e)
                                {
                                    Console.WriteLine(e);
                                }
                            }
                            Console.WriteLine(syntaxGen.SyntaxFiller1(" └────┴──────────────────────────────┴─────┴─────┘"));
                        }
                    }
                }
            }
            return data;
        }
        // Failsafe to create table if not made already
        public void InitialiseTable()
        {
            ExecuteNonQuery("CREATE TABLE IF NOT EXISTS ResultsLog (ID INTEGER PRIMARY KEY, UserChoice STRING NOT NULL, BotChoice STRING NOT NULL, Verdict STRING)", "DatabaseLog.csv");
            ExecuteNonQuery("CREATE TABLE IF NOT EXISTS UserData (ResultsLogID INTEGER, R INTEGER DEFAULT 0, P INTEGER DEFAULT 0, S INTEGER DEFAULT 0, FOREIGN KEY(ResultsLogID) REFERENCES ResultsLog(ID))", "DatabaseLog.csv");

        }
        // Inserts data into database tables
        public void InsertDB(string table, string columns, string columnData)
        {
            ExecuteNonQuery("INSERT INTO " + table + " (" + columns + ") VALUES (" + columnData + ")", "DatabaseLog.csv");
        }
        // Outputs all of the database tables content
        public void ReadAllDB(string table)
        {
            ExecuteQuery("SELECT * FROM " + table, "DatabaseLog.csv");
        }
        // Outputs a single data cell with conditionals to locate the correct data
        public string ReadDB(string table, string targetColumn, string where)
        {
            return ExecuteQuery("SELECT " + targetColumn + " FROM " + table + " WHERE " + where, "DatabaseLog.csv");
        }
        // Finds max value in a given column
        public string ReadMaxValDB(string table, string targetColumn)
        {
            return ExecuteQuery("SELECT max(" + targetColumn + "), * FROM " + table, "DatabaseLog.csv");
        }
        // Finds min value in a given column
        public string ReadMinValDB(string table, string targetColumn)
        {
            return ExecuteQuery("SELECT min(" + targetColumn + "), * FROM " + table, "DatabaseLog.csv");
        }
        // Counts the amount of data in a specific column which can be a good indicator for blank tables (no data)
        public string CountColumnDB(string table, string targetColumn, string where)
        {
            return where.Equals("none")
                ? ExecuteQuery("SELECT count(" + targetColumn + "), * FROM " + table + " WHERE ", "DatabaseLog.csv")
                : ExecuteQuery("SELECT count(" + targetColumn + "), * FROM " + table + " WHERE " + where, "DatabaseLog.csv");
        }
        // Gets average amount using columns data
        public string ColumnAverageDB(string table, string targetColumn, string where)
        {
            return where.Equals("none")
                ? ExecuteQuery("SELECT avg(" + targetColumn + ") FROM " + table, "DatabaseLog.csv")
                : ExecuteQuery("SELECT avg(" + targetColumn + "), * FROM " + table + " WHERE " + where, "DatabaseLog.csv");
        }
        // Appends any data already stored
        public void UpdateDB(string table, string targetColumn, string where)
        {
            ExecuteNonQuery("UPDATE " + table + " SET " + targetColumn + " WHERE " + where, "DatabaseLog.csv");
        }
        // Deletes rows using conditionals to locate the row
        public void DeleteRowDB(string table, string where)
        {
            ExecuteNonQuery("DELETE FROM " + table + " WHERE " + where, "DatabaseLog.csv");
        }
        // Returns max value of a column
        public string ReadMaxValGradeDB(string table, string targetColumn, string where)
        {
            return ExecuteQuery("SELECT max(" + targetColumn + "), * FROM " + table + " WHERE " + where, "GradeData.db");
        }
        // Gets grade data (e.g. A,B,C,D,F)
        public string ReadGradeDB(string table, string targetColumn, string where)
        {
            return ExecuteQuery("SELECT " + targetColumn + " FROM " + table + " WHERE " + where, "GradeData.db");
        }
    }
}
