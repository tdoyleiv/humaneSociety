using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Room
    {
        private bool isOccupied;
        int roomNumber;
        object occupant;
        public bool IsOccupied
        {
            get { return isOccupied; }
            set { isOccupied = value; }
        }
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        public object Occupant
        {
            get { return occupant; }
            set { occupant = value; }
        }
        public Room(int roomNumber, bool isOccupied, object occupant)
        {
            roomNumber = RoomNumber;
            isOccupied = IsOccupied;
            occupant = Occupant;
        }
    }
}
