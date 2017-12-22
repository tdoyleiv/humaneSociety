using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{

    public class UI
    {
        //member variables


        public UI()
        {

        }

        //member methods
        public void HomeScreen()
        {
            Console.WriteLine("Who are you?");
            Console.WriteLine("[1] Employee");
            Console.WriteLine("[2] Adopter\n\n");
            Console.WriteLine("[3] EXIT");
        }

        public string GetUserStringInput()
        {
            return Console.ReadLine();
        }

    }
}
