using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;

namespace HumaneSociety
{
    class HumaneSociety
    {
        //member variables
        string provider;
        string connectionString;
        DbProviderFactory factory;

        //constructor
        public HumaneSociety()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        //member methods
        public void RunProgram()
        {
            InsertAnimalData();
            ReadAnimalData();
        }

        public void InsertAnimalData()
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    Console.WriteLine("Connection Error");
                    return;
                }

                connection.ConnectionString = connectionString;
                connection.Open();

                //to pass queries to the database
                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    Console.WriteLine("command error");
                    return;
                }

                command.Connection = connection;

                command.CommandText = "INSERT INTO Animal (AnimalType, RoomNumber, FirstName) VALUES ('cat', 10, 'Jubei')";
                command.ExecuteNonQuery();

            }
        }

        public void ReadAnimalData()
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    Console.WriteLine("Connection Error");
                    return;
                }

                connection.ConnectionString = connectionString;
                connection.Open();

                //to pass queries to the database
                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    Console.WriteLine("comman error");
                    return;
                }

                command.Connection = connection;

                command.CommandText = "Select * From Animal";
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["AnimalID"]} " + $"{dataReader["AnimalType"]} " + $"{dataReader["FirstName"]} ");
                    }
                }

            }
        }




    }
}
