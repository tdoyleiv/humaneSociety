using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adopter
    {
        Profile profile = new Profile(null, null, 0, 0, false, false, null);
        bool hasPaid;
        public bool HasPaid
        {
            get { return hasPaid; }
            set { hasPaid = value; }
        }
        public Adopter(bool hasPaid)
        {
            this.hasPaid = HasPaid;
        }
        public void Pay()
        {
            HasPaid = true;
        }
        public void CreateProfile()
        {
            profile.FirstName = GetFirstName();
            profile.LastName = GetLastName();
            profile.Age = GetAge();
            profile.IncomePerYear = GetIncome();
            profile.HasChildren = DetermineChildren();
            profile.HasCriminalRecord = DetermineRecord();
            profile.Description = GetDescription();
        }
        string GetFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            try
            {
                return Console.ReadLine().ToString();
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            } 
        }
        string GetLastName()
        {
            Console.WriteLine("Pplease enter your last name.");
            try
            {
                return Console.ReadLine().ToString();
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            }
        }
        int GetAge()
        {
            Console.WriteLine("Please enter your age.");
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            }
        }
        decimal GetIncome()
        {
            Console.WriteLine("Please enter your yearly income.");
            try
            {
                return decimal.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            }
        }
       bool DetermineChildren()
        {
            Console.WriteLine("Does your household have children?");
            try
            {
                bool value = false;
                string answer = Console.ReadLine().ToString().ToLower();
                if (answer == "yes")
                {
                    value = true;
                }
                else if (answer == "no")
                {
                    value = false;
                }
                return value;
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            }
        }
        bool DetermineRecord()
        {
            Console.WriteLine("Do you have a criminal record?");
            try
            {
                bool value = false;
                string answer = Console.ReadLine().ToString().ToLower();
                if (answer == "yes")
                {
                    value = true;
                }
                else if (answer == "no")
                {
                    value = false;
                }
                return value;
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            }
        }
        string GetDescription()
        {
            Console.WriteLine("Please describe yourself in a few sentences.");
            try
            {
                return Console.ReadLine().ToString();
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            }
        }



    }
}
