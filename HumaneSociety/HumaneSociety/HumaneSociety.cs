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

                //command.CommandText = "INSERT INTO Animals (AnimalCategory, Name, Type, AgeYRS, Gender, WeightLBS, Gender, WeightLBS, Primary, Temperament, AdoptionStatus, Price) VALUES ('Cat', 'Admiral Whiskers', 'Scottish Fold', 10, 'Male', 6, 'Blue', 'Intelligent', 'Unadopted', 100)";
                command.CommandText = "INSERT INTO Animals (AnimalCategory, Name, Age) VALUES ('Cat', 'FuckBoy', 2)";
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
                    Console.WriteLine("Command Error");
                    return;
                }

                command.Connection = connection;

                command.CommandText = "Select * From Animals";
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["AnimalID"]} " + $"{dataReader["AnimalCategory"]} " + $"{dataReader["Name"]} " + $"{dataReader["Age"]} ");
                    }
                }

            }
        }




    }
}
