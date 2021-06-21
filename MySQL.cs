using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp_Expert_System
{
    class MySQL
    {
        public static void WriteToDB(List<Human> List)
        {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3307;database = EXPERTSYSTEM;username=root;password=root;");

            connection.Open();
            foreach (var list in List)
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO humans (NAME, SURNAME, AGE, COMMENT, GENDER, PROFESSION) VALUES (@UN, @US, @UA, @UC, @UG, @UP)";
                    command.Parameters.Add("@UN", MySqlDbType.VarChar).Value = list.name;
                    command.Parameters.Add("@US", MySqlDbType.VarChar).Value = list.surname;
                    command.Parameters.Add("@UA", MySqlDbType.Int32).Value = list.age;
                    command.Parameters.Add("@UC", MySqlDbType.VarChar).Value = list.comment;
                    command.Parameters.Add("@UG", MySqlDbType.VarChar).Value = list.gender;
                    command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = list.profession;
                    command.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        MySqlConnection connection;
        protected MySQL(string Server, string Port, string Username, string Password, string DataBase)
        {
            this.connection = new MySqlConnection($"server={Server};port={Port};username={Username};password={Password};database ={DataBase}");
        }
        public void INSERTQuestion(List<string> List, string nameTable)
        {
            connection.Open();
            int i = 0;
            try
            {
                while (i < List.Count)
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = $"INSERT INTO {nameTable} (QUESTION, ANSWERONE, ANSWERTWO) VALUES (@name1, @name2, @name3)";
                        command.Parameters.Add("@name1", MySqlDbType.VarChar).Value = List[i + 0];
                        command.Parameters.Add("@name2", MySqlDbType.VarChar).Value = List[i + 1];
                        command.Parameters.Add("@name3", MySqlDbType.VarChar).Value = List[i + 2];
                        command.ExecuteNonQuery();
                    }
                    i = i + 3;
                }
                //int rowCount = command.ExecuteNonQuery();
                Console.WriteLine($"Number of rows inserted={i}");
            }
            finally
            {
                // connectionectionection will be closed by the 'using' block
                Console.WriteLine("Closing connectionection");
                connection.Close();
            }

        }

        public void INSERTHuman(List<Human> List, string nameTable)
        {
            connection.Open();
            int i = 0;
            try
            {
                //while (i < List.Count)
                //{
                //    using (var command = connection.CreateCommand())
                //    {
                //        command.CommandText = $"INSERT INTO {nameTable} (QUESTION, ANSWERONE, ANSWERTWO) VALUES (@name1, @name2, @name3)";
                //        command.Parameters.Add("@name1", MySqlDbType.VarChar).Value = List[i + 0];
                //        command.Parameters.Add("@name2", MySqlDbType.VarChar).Value = List[i + 1];
                //        command.Parameters.Add("@name3", MySqlDbType.VarChar).Value = List[i + 2];
                //        command.ExecuteNonQuery();
                //    }
                //    i = i + 3;
                //}

                foreach(var human in List)
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = $"INSERT INTO {nameTable} (NAME, SURNAME, AGE, COMMENT, GENDER) VALUES (@name1, @name2, @name3, @name4, @name5)";
                        command.Parameters.Add("@name1", MySqlDbType.VarChar).Value = human.name;
                        command.Parameters.Add("@name2", MySqlDbType.VarChar).Value = human.surname;
                        command.Parameters.Add("@name3", MySqlDbType.VarChar).Value = human.age;
                        command.Parameters.Add("@name4", MySqlDbType.VarChar).Value = human.comment;
                        command.Parameters.Add("@name5", MySqlDbType.VarChar).Value = human.gender;
                    }
                }
                //int rowCount = command.ExecuteNonQuery();
                Console.WriteLine(String.Format("Number of rows inserted={0}", i));
            }
            finally
            {
                Console.WriteLine("Closing connectionection");
                connection.Close();
            }
        }

        public void INSERTHumanSKILLS(List<Human> List, string nameTable)
        {
            connection.Open();
            //int i = 0;
            try
            {
                //while (i < List.Count)
                //{
                //    using (var command = connection.CreateCommand())
                //    {
                //        command.CommandText = $"INSERT INTO {nameTable} (QUESTION, ANSWERONE, ANSWERTWO) VALUES (@name1, @name2, @name3)";
                //        command.Parameters.Add("@name1", MySqlDbType.VarChar).Value = List[i + 0];
                //        command.Parameters.Add("@name2", MySqlDbType.VarChar).Value = List[i + 1];
                //        command.Parameters.Add("@name3", MySqlDbType.VarChar).Value = List[i + 2];
                //        command.ExecuteNonQuery();
                //    }
                //    i = i + 3;
                //}

                foreach (var human in List)
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = $"INSERT INTO {nameTable} (Poryadochnost, Knowledge, Improving, Communication, JobInteresting, Responsible) VALUES (@name5, @name6, @name7, @name8, @name9, @name10)";

                        command.Parameters.Add("@name5", MySqlDbType.VarChar).Value = human.poryadochnost;
                        command.Parameters.Add("@name6", MySqlDbType.VarChar).Value = human.knowledge;
                        command.Parameters.Add("@name7", MySqlDbType.VarChar).Value = human.improving;
                        command.Parameters.Add("@name8", MySqlDbType.VarChar).Value = human.communication;
                        command.Parameters.Add("@name9", MySqlDbType.VarChar).Value = human.jobInteresting;
                        command.Parameters.Add("@name10", MySqlDbType.VarChar).Value = human.responsible;
                    }
                }
                //int rowCount = command.ExecuteNonQuery();
                //Console.WriteLine(String.Format("Number of rows inserted={0}", i));
            }
            finally
            {
                Console.WriteLine("Closing connectionection");
                connection.Close();
            }
        }
    }
    
}
