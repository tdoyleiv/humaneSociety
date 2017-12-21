using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Facility
    {
        Room room = new Room(0, false, null);
        Inventory inventory = new Inventory();
        internal Employee employee = new Employee();
        PatientList patientList = new PatientList();
        public Facility()
        {
            
        }
        public void AssignRoom()
        {
            try
            {
                if (room.IsOccupied == false)
                {
                    room.IsOccupied = true;
                }
                else if (room.IsOccupied == true)
                {

                }
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input", e));
            }
        }
    }
}
