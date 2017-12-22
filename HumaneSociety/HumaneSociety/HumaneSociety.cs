﻿using System;
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
        bool isEmployee = true;
        bool isAdopter = true;
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
            while (running)
            {
                StartScreen();
                switch (userInput)
                {
                    case "1":
                        EmployeeScreen();
                        break;

                    case "2":
                        AdopterScreen();
                        break;

                    case "3":
                        running = false;
                        break;
                }
            }


            Console.WriteLine("Exiting the program, good day!");

            //InsertAnimalData();
            //ReadAnimalData();
        }

        public void StartScreen()
        {
            Console.Clear();
            userInterface.HomeScreen();
            userInput = userInterface.GetUserStringInput();
        }

        public void AdopterScreen()
        {
            Console.Clear();
            isAdopter = true;
            while (isAdopter)
            {
                Console.Clear();
                DisplayAdopterMenu();
                userInput = userInterface.GetUserStringInput();
                switch (userInput)
                {
                    case "1":
                        AdopterScreenSearchForAnimal();
                        break;

                    case "2":
                        AdopterScreenCreateProfile();                      
                        break;

                    case "3":
                        isAdopter = false;
                        break;
                }
            }          
        }

        public void DisplayAdopterMenu()
        {
            Console.WriteLine("What would you like to do?:");
            Console.WriteLine("[1] Search For Animal");
            Console.WriteLine("[2] Create Profile\n\n");
            Console.WriteLine("[3] EXIT");
        }

        public void AdopterScreenCreateProfile()
        {

        }

        public void AdopterScreenSearchForAnimal()
        {
            
        }

        public void EmployeeScreen()
        {
            Console.Clear();
            isEmployee = true;
            while (isEmployee)
            {
                Console.Clear();
                DisplayEmployeeMenu();
                userInput = userInterface.GetUserStringInput();
                switch (userInput)
                {
                    case "1":
                        EmployeeScreenAddNewAnimal();
                        break;

                    case "2":
                        EmployeeScreenUpdateAnimalStatus();
                        break;

                    case "3":
                        EmployeeScreenDisplayAnimalDatabase();
                        Console.WriteLine("Press Anything To Continue");
                        Console.ReadKey();
                        break;

                    case "4":
                        EmployeeScreenImportCSV();
                        break;

                    case "5":
                        isEmployee = false;
                        break;
                }
            }
        }

        public void DisplayEmployeeMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?:");
            Console.WriteLine("[1] Add New Animal");
            Console.WriteLine("[2] Update Animal Status");
            Console.WriteLine("[3] Display Animal Database");
            Console.WriteLine("[4] Import CSV\n\n");
            Console.WriteLine("[5] EXIT");
        }

        public void EmployeeScreenImportCSV()
        {

        }

        public void EmployeeScreenDisplayAnimalDatabase()
        {
            ReadAnimalData();
        }

        public void EmployeeScreenUpdateAnimalStatus()
        {

        }

        public void EmployeeScreenAddNewAnimal()
        {
            string animalCategory;
            string name;
            string type;
            int ageYears;
            string gender;
            decimal weightLBS;
            string color;
            string temperament;
            string adoptionStatus;
            decimal price;

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

                //code starts here
                Console.WriteLine("What is the animal's category?");
                animalCategory = userInterface.GetUserStringInput();
                Console.WriteLine("What is the animal's name?");
                name = userInterface.GetUserStringInput();
                Console.WriteLine("What is the animal's type?");
                type = userInterface.GetUserStringInput();
                Console.WriteLine("How old is the animal?");
                ageYears = GetIntInput();
                Console.WriteLine("What is the animal's gender?");
                gender = userInterface.GetUserStringInput();
                Console.WriteLine("What is the animal's weight?");
                weightLBS = GetDecimalInput();
                Console.WriteLine("What is the animal's color");
                color = userInterface.GetUserStringInput();
                Console.WriteLine("What is the animal's temperament?");
                temperament = userInterface.GetUserStringInput();
                Console.WriteLine("What is the animal's adoption status?");
                adoptionStatus = userInterface.GetUserStringInput();
                Console.WriteLine("What is the price range for this animal?");
                price = GetDecimalInput();



                //roomNumber = GetRoomNumberValue();

                //Console.WriteLine("What is the Animal's name?");
                //firstName = Console.ReadLine();


                //command.CommandText = "INSERT INTO Animal (AnimalType, RoomNumber, FirstName) VALUES ('dog', 101, 'bob')";
                command.CommandText = string.Format("INSERT INTO Animal (AnimalType, RoomNumber, FirstName) VALUES ('{0}', {1}, '{2}')", animalType, roomNumber, firstName);

                command.ExecuteNonQuery();
                //code ends here

            }
        }

        public decimal GetDecimalInput()
        {
            decimal userInputDecimal;

            try
            {
                userInputDecimal = System.Convert.ToDecimal(userInterface.GetUserStringInput());
                if (userInputDecimal <= 0)
                {
                    GetDecimalInput();
                }
            }
            catch (Exception e)
            {
                userInputDecimal = GetDecimalInput();
            }

            return userInputDecimal;
        }

        public int GetIntInput()
        {
            int userInputInt;

            try
            {
                userInputInt = Convert.ToInt32(userInterface.GetUserStringInput());
                if (userInputInt <= 0)
                {
                    userInputInt = GetIntInput();
                }
            }
            catch (Exception e)
            {
                userInputInt = GetIntInput();
            }

            return userInputInt;
        }



        //[ TEST CODE BELOW to see if DATA Table is connected and able to configure ]
        //public void InsertAnimalData()
        //{
        //    //GetAnimalData();
        //    using (DbConnection connection = factory.CreateConnection())
        //    {
        //        if (connection == null)
        //        {
        //            Console.WriteLine("Connection Error");
        //            return;
        //        }

        //        connection.ConnectionString = connectionString;
        //        connection.Open();

        //        //to pass queries to the database
        //        DbCommand command = factory.CreateCommand();

        //        if (command == null)
        //        {
        //            Console.WriteLine("command error");
        //            return;
        //        }

        //        command.Connection = connection;

        //        command.CommandText = ("INSERT INTO AnimalList (AnimalCategory, Name, Type, AgeYRS, Gender, WeightLBS, PrimaryColor, Temperament, AdoptionStatus, Price) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", );
        //        command.ExecuteNonQuery();

        //    }
        //}

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
                        Console.WriteLine(String.Format("{0} \t | {1} \t| {2} \t | {3} \t | {4} \t | {5} \t | {6} \t | {7} \t {8} | \t {9}", 
                            dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4], dataReader[5], dataReader[6], dataReader[7], dataReader[8], dataReader[9]));                        
                        //Console.WriteLine($"{dataReader["AnimalID"]} " + $"{dataReader["AnimalType"]} " + $"{dataReader["FirstName"]} " 
                        //    + $"{dataReader["Price"]} " + $"{dataReader["ShotsStatus"]} " + $"{dataReader["AdoptionStatus"]} "
                        //     + $"{dataReader["WeeklyFoodconsumption"]} ");
                    }
                }

            }
        }




    }
}
