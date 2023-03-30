using System;

namespace HotelManager {
    class Program {
        List<int> freeRooms = new List<int> {1, 2, 3, 4, 5};
        List<int> usedRooms = new List<int>();

        void freeRoom() {
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

        void useRooms() {
            Console.WriteLine("Which Room Do You Want To Inform That is used?");
            int room = Convert.ToInt32(Console.ReadLine());

            foreach (var rooms in freeRooms) { 
                if (rooms == room) {
                    freeRooms.Remove(rooms);
                    usedRooms.Add(rooms);
                    Console.WriteLine("Rooms Is Now Used");
                    menu();
                } 
            }

        } 

        public void menu() {
            Console.WriteLine("Welcome To Hotel Manager!");
            Console.WriteLine("What Would YoU Like To Do?");
            Console.WriteLine("1. Inform Of A Used Room");
            Console.WriteLine("2. Infrom Of A Free Room");
            Console.WriteLine("3. See What Rooms Are Free And What Are Used");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1) {
                useRooms();
            } else if(choice == 2) {
                freeRoom();
            } else if (choice == 3) {
                foreach (var room in freeRooms) {
                    Console.WriteLine("Free Room: " + room);
                }
                foreach (var room in usedRooms) {
                    Console.WriteLine("Used Room: " + room);
                }
                menu();
            } else if(choice == 4) {
                return;
            }
        }


        static void Main(string[] args) {
            Program program = new Program();
            program.menu();
        }
    }
}