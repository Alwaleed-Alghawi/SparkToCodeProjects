namespace Task7_OOP_Solutions
{

    public class Room
    {
        public int roomNumber { get; set; }
        public string roomType { get; set; }
        public double pricePerNight { get; set; }
        public bool isAvailable { get; set; } = false;

        public void displayRoom()
        {
            Console.WriteLine($"Room Number: {roomNumber}");
            Console.WriteLine($"Room Type: {roomType}");
            Console.WriteLine($"Price Per Night: {pricePerNight}");
            Console.WriteLine($"Availability: {isAvailable}");
        }
    }

    public class Guest
    {
        public int guestId { get; set; }
        public string guestName { get; set; }
        public int roomNumber { get; set; }
        public DateTime checkInDate { get; set; }
        public int totalNights { get; set; }

        public void displayGuest()
        {
            Console.WriteLine($"Guest ID: {guestId}");
            Console.WriteLine($"Guest Name: {guestName}");
            Console.WriteLine($"Room Number: {roomNumber}");
            Console.WriteLine($"Check-In Date: {checkInDate.ToShortDateString()}");
            Console.WriteLine($"Total Nights: {totalNights}");
        }

        public static double calculateTotalCost(double pricePerNight, int totalNights)
        {
            double totalCost = pricePerNight * totalNights;
            return totalCost;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            PreloadRooms(rooms);

            bool running = true;
            while (running)
            {
                PrintMenu();
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": AddNewRoom(rooms); break;
                    //case "2": RegisterNewGuest(guests); break;
                    //case "3": BookRoomForGuest(rooms, guests); break;
                    //case "4": ViewAllRooms(rooms); break;
                    //case "5": ViewAllGuests(guests); break;
                    //case "6": SearchAndFilterRooms(rooms); break;
                    //case "7": GuestBookingStatistics(rooms, guests); break;
                    //case "8": UpdateRoomPrice(rooms); break;
                    //case "9": GuestLookupByName(guests); break;
                    //case "10": RoomTypeBreakdownReport(rooms); break;
                    //case "11": CheckOutGuest(rooms, guests); break;
                    //case "12": RemoveUnavailableRooms(rooms); break;
                    //case "13": ExtendGuestStay(guests); break;
                    //case "14": HighestRevenueBooking(rooms, guests); break;
                    //case "15": GuestPaginationViewer(guests); break;
                    case "0":
                        running = false;
                        Console.WriteLine("Thank you for using Grand Vista Hotel Management System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
            }
        }

        // ---------- Setup ----------

        static void PreloadRooms(List<Room> rooms)
        {
            rooms.Add(new Room { roomNumber = 101, roomType = "Single", pricePerNight = 60, isAvailable = true });
            rooms.Add(new Room { roomNumber = 102, roomType = "Single", pricePerNight = 65, isAvailable = true });
            rooms.Add(new Room { roomNumber = 201, roomType = "Double", pricePerNight = 95, isAvailable = true });
            rooms.Add(new Room { roomNumber = 202, roomType = "Double", pricePerNight = 100, isAvailable = true });
            rooms.Add(new Room { roomNumber = 301, roomType = "Suite", pricePerNight = 180, isAvailable = true });
            rooms.Add(new Room { roomNumber = 302, roomType = "Suite", pricePerNight = 220, isAvailable = true });
        }

        static void PrintMenu()
        {
            Console.WriteLine("===================================================================");
            Console.WriteLine("           GRAND VISTA HOTEL - MANAGEMENT SYSTEM");
            Console.WriteLine("===================================================================");
            Console.WriteLine(" 1. Add New Room");
            Console.WriteLine(" 2. Register New Guest");
            Console.WriteLine(" 3. Book a Room for a Guest");
            Console.WriteLine(" 4. View All Rooms");
            Console.WriteLine(" 5. View All Guests");
            Console.WriteLine(" 6. Search & Filter Rooms");
            Console.WriteLine(" 7. Guest & Booking Statistics");
            Console.WriteLine(" 8. Update Room Price");
            Console.WriteLine(" 9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("==================================================================");
            Console.Write("Enter your choice: ");
        }

        // ---------- Helpers for input ----------

        static int ReadPositiveInt(string prompt)
        {
            int value;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid number, try again: ");
            }
            return value;
        }

        static double ReadPositiveDouble(string prompt)
        {
            double value;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid number, try again: ");
            }
            return value;
        }

        static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static DateTime ReadDate(string prompt)
        {
            DateTime value;
            Console.Write(prompt + " (MM/DD/YYYY): ");
            while (!DateTime.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid date, try again (MM/DD/YYYY): ");
            }
            return value;
        }


        //-------------------------------- Easy ( Cases 1 - 5 ) --------------------------------------------
        //Case 01 - Add New Room
        static void AddNewRoom(List<Room> rooms)
        {
            Console.WriteLine(" --- Add New Room --- ");

            int roomNumber = ReadPositiveInt("Room Number: ");
            string roomType = ReadString("Room Type (Single/Double/Suite): ");
            double price = ReadPositiveDouble("Price Per Night: ");

            //LINQ Any()
            if (rooms.Any(r => r.roomNumber == roomNumber))
            {
                Console.WriteLine($"Error: Room with {roomNumber} Already Exists. Returning to Main Menu...");
                return;
            }

            //Adding the new room after checking for duplication
            Room newRoom = new Room
            {
                roomNumber = roomNumber,
                roomType = roomType,
                pricePerNight = price,
                isAvailable = true
            };
            rooms.Add(newRoom);

            Console.WriteLine("Room added successfully!");
            Console.WriteLine($"  Room Number: {newRoom.roomNumber}");
            Console.WriteLine($"  Room Type: {newRoom.roomType}");
            Console.WriteLine($"  Price Per Night: {newRoom.pricePerNight:C}");
            //Ternary opreation
            Console.WriteLine($"  Availability: {(newRoom.isAvailable ? "Available" : "Booked")}");
            Console.WriteLine($"  Total Rooms in System: {rooms.Count}");
        }
    }

}
