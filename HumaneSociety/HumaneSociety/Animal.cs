using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public abstract class Animal
    {
        string name;
        string type;
        int age;
        string gender;
        double weight;
        string color;
        string temperament;
        bool isAdopted;
        bool isFed;
        bool hasMedicine;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Temperament
        {
            get { return temperament; }
            set { temperament = value; }
        }
        public bool IsAdopted
        {
            get { return isAdopted; }
            set { isAdopted = value; }
        }
        public bool IsFed
        {
            get { return isFed; }
            set { isFed = value; }
        }
        public bool HasMedicine
        {
            get { return hasMedicine; }
            set { hasMedicine = value; }
        }
        public virtual void Eat()
        {
            IsFed = true;
        }
        public virtual void TakeMedicine()
        {
            HasMedicine = true;
        }
    }
}
