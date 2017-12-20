using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class User
    {
        object userClass;
        string userChoice;
        public object UserClass
        {
            get { return userClass; }
            set { userClass = value; }
        }
        public void AssignUserClass()
        {
            string userChoice = Console.ReadKey(true).KeyChar.ToString();
            try
            {
                if (userChoice == "1")
                {
                    UserClass = new Adopter(false);
                }
                else if (userChoice == "2")
                {
                    UserClass = new Employee();
                }
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            }
        }
    }
}
