using System;

namespace HotelManager {
    class Program {
        List<int> freeRooms = new List<int> {1, 2, 3, 4, 5};
        List<int> usedRooms = new List<int>();

        void menu() {

        }

        void free_A_Room() {
            Console.WriteLine("Which Room Do You Want To Free?");
            int room = Convert.ToInt32(Console.ReadLine());

            foreach (int rooms in usedRooms) {
                if (rooms == room) {
                    usedRooms.Remove(rooms);
                    freeRooms.Add(rooms);
                    Console.WriteLine("Rooms Is Now Free");
                    menu();
                } 
            }

        } 

        static void Main(string[] args) {
            
        }
    }
}