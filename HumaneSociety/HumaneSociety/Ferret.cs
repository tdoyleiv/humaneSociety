using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Ferret : Animal
    {
        public Ferret(string name, string type, int age, string gender, double weight, string color, string temperament, bool isAdopted, bool hasMedicine)
        {
            name = Name;
            type = Type;
            age = Age;
            gender = Gender;
            weight = Weight;
            color = Color;
            temperament = Temperament;
            isAdopted = IsAdopted;
            hasMedicine = HasMedicine;
        }
    }
}
