using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Cat : Animal
    {
        public Cat(string name, string type, int age, string gender, double weight, string color, string temperament, bool isAdopted, bool isFed, bool hasMedicine)
        {
            name = Name;
            type = Type;
            age = Age;
            gender = Gender;
            weight = Weight;
            color = Color;
            temperament = Temperament;
            isAdopted = IsAdopted;
            isFed = IsFed;
            hasMedicine = HasMedicine;
        }
    }
}
