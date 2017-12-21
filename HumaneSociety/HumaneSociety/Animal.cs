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
        string temperment;
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
        public string Temperment
        {
            get { return temperment; }
            set { temperment = value; }
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
