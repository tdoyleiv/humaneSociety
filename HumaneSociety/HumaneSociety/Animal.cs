using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public abstract class Animal
    {
        bool isAdopted;
        bool isFed;
        bool hasMedicine;
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
