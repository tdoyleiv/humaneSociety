using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adopter
    {
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
    }
}
