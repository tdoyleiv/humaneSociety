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
        bool running = true;
        string provider;
        string connectionString;
        string userInput;
        DbProviderFactory factory;
        UI userInterface;

        //constructor
        public HumaneSociety()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
            userInterface = new UI();
        }

        //member methods
        public void RunProgram()
        {

            //while (running)
            //{
            //    StartScreen();
            //    switch (userInput)
            //    {
            //        case "1":
            //            EmployeeScreen();
            //            break;

            //        case "2":
            //            AdopterScreen();
            //            break;

            //        case "3":
            //            running = false;
            //            break;
            //    }
            //}

            //StartScreen();
            //userInterface.HomeScreen();
            InsertAnimalData();
            ReadAnimalData();
        }

        public void StartScreen()
        {
            userInterface.HomeScreen();
            userInput = userInterface.GetUserStringInput();
        }

        public void EmployeeScreen()
        {
            Console.WriteLine("What would you like to do?:");
            Console.WriteLine("[1] Add New Animal");
            Console.WriteLine("[2] Update Animal Status");
            userInput = userInterface.GetUserStringInput();
        }

        public void AdopterScreen()
        {
            Console.WriteLine("What would you like to do?:");
            Console.WriteLine("[1] Search For Animal");
            Console.WriteLine("[2] Create Profile");
            userInput = userInterface.GetUserStringInput();
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

                command.CommandText = "INSERT INTO AnimalList (AnimalCategory, Name, Type, AgeYRS, Gender, WeightLBS, PrimaryColor, Temperament, AdoptionStatus, Price) VALUES ('Cat', 'Admiral Whiskers', 'Scottish Fold', 10, 'Male', 6, 'Blue', 'Intelligent', 'Unadopted', 100)";
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

                command.CommandText = "Select * From AnimalList";
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    //Console.WriteLine("Animal ID \t | Animal Type" );
                    while (dataReader.Read())
                    {
                        Console.WriteLine(String.Format("{0} \t | {1} \t| {2} \t | {3} \t | {4} \t | {5} \t | {6} \t | {7}", 
                            dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4], dataReader[5], dataReader[6], dataReader[7]));                        
                        //Console.WriteLine($"{dataReader["AnimalID"]} " + $"{dataReader["AnimalType"]} " + $"{dataReader["FirstName"]} " 
                        //    + $"{dataReader["Price"]} " + $"{dataReader["ShotsStatus"]} " + $"{dataReader["AdoptionStatus"]} "
                        //     + $"{dataReader["WeeklyFoodconsumption"]} ");
                    }
                }

            }
        }




    }
}
