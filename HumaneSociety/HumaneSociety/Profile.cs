using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Profile
    {
        string firstName;
        string lastName;
        int age;
        decimal incomePerYear;
        bool hasChildren;
        bool hasCriminalRecord;
        string description;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public decimal IncomePerYear
        {
            get { return incomePerYear; }
            set { incomePerYear = value; }
        }
        public bool HasChildren
        {
            get { return hasChildren; }
            set { hasChildren = value; }
        }
        public bool HasCriminalRecord
        {
            get { return hasCriminalRecord; }
            set { hasCriminalRecord = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Profile(string firstName, string lastName, int age, decimal incomePerYear, bool hasChildren, bool hasCriminalRecord, string description)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
            incomePerYear = IncomePerYear;
            hasChildren = HasChildren;
            hasCriminalRecord = HasCriminalRecord;
            description = Description;
        }
    }
}
