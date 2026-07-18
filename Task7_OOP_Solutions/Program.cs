using System.Security.AccessControl;

namespace Task7_OOP_Solutions
{

    public class Room
    {
        public int? roomNumber { get; set; }
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
        public string guestId { get; set; }
        public string guestName { get; set; }
        public int? roomNumber { get; set; }
        public string checkInDate { get; set; }
        public int totalNights { get; set; }

        public void displayGuest()
        {
            Console.WriteLine($"Guest ID: {guestId}");
            Console.WriteLine($"Guest Name: {guestName}");
            Console.WriteLine($"Room Number: {(roomNumber == null ? "Not Assigned" : roomNumber.ToString())}");
            Console.WriteLine($"Check-In Date: {checkInDate}");
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
                    case "2": RegisterNewGuest(guests); break;
                    case "3": BookRoomForGuest(rooms, guests); break;
                    case "4": ViewAllRooms(rooms); break;
                    case "5": ViewAllGuests(guests); break;
                    case "6": SearchAndFilterRooms(rooms); break;
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
            Console.WriteLine("GRAND SPARK HOTEL - MANAGEMENT SYSTEM");
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

        //-------------------------------- Easy ( Cases 1 - 5 ) --------------------------------------------
        //Case 01 - Add New Room
        static void AddNewRoom(List<Room> rooms)
        {
            Console.WriteLine(" --- Add New Room --- ");

            Console.Write("Room Number: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());

            while (roomNumber <= 0)
            {
                Console.Write("Error: Room Number Must Be Positive, Try Again.");
                roomNumber = Convert.ToInt32(Console.ReadLine());
            }

            //LINQ Any()
            if (rooms.Any(r => r.roomNumber == roomNumber))
            {
                Console.WriteLine($"Error: Room with {roomNumber} Already Exists. Returning to Main Menu...");
                return;
            }

            Console.Write("Room Type (Single / Double / Suite) :");
            string roomType = Console.ReadLine();

            Console.Write("Price Per Night: ");
            double price = Convert.ToDouble(Console.ReadLine());

            while (price <= 0)
            {
                Console.Write("Price must be positive. Try again: ");
                price = Convert.ToDouble(Console.ReadLine());
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


        //Case 02 - Register New Guest
        static void RegisterNewGuest(List<Guest> guests)
        {
            Console.WriteLine(" --- Add New Guest --- ");

            Console.Write("Guest Name: ");
            string enteredName = Console.ReadLine();

            Console.Write("Check-In Date: ");
            string enteredCheckIn = Console.ReadLine();

            Console.Write("Number of Nights: ");
            int nights = Convert.ToInt32(Console.ReadLine());

            while (nights <= 0)
            {
                Console.Write("Number of nights must be positive. Try again: ");
                nights = Convert.ToInt32(Console.ReadLine());
            }

            //Auto Generated ID - Did some research - if you entered a guest it will be moved to two dicemles - so 1 => G001
            string newGuestId = $"G{(guests.Count + 1):D3}";

            Guest newGuest = new Guest
            {
                guestId = newGuestId,
                guestName = enteredName,
                roomNumber = null,
                checkInDate = enteredCheckIn,
                totalNights = nights
            };

            guests.Add(newGuest);

            Console.WriteLine("Guest registered successfully!");
            Console.WriteLine($"  Guest ID: {newGuest.guestId}");
            Console.WriteLine($"  Guest Name: {newGuest.guestName}");
            Console.WriteLine($"  Check-In Date: {newGuest.checkInDate}");
            Console.WriteLine($"  Number of Nights: {newGuest.totalNights}");
            Console.WriteLine($"  Room Number: Not Assigned");
        }


        //Case 03 - Book a Room for a Guest
        static void BookRoomForGuest(List<Room> rooms, List<Guest> guests)
        {
            Console.WriteLine(" --- Book Room for Guest --- ");
            Console.Write("Guest ID: ");
            string guestId = Console.ReadLine();

            // LINQ FirstOrDefault - no manual loops
            Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);
            if (guest == null)
            {
                Console.WriteLine("Error: Guest not found.");
                return;
            }

            Console.Write("Room Number: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());


            Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine("Error: Room not found.");
                return;
            }

            if (!room.isAvailable)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }

            guest.roomNumber = room.roomNumber;
            room.isAvailable = false;

            double totalCost = Guest.calculateTotalCost(room.pricePerNight, guest.totalNights);

            Console.WriteLine("Booking confirmed!");
            Console.WriteLine($"  Guest Name: {guest.guestName}");
            Console.WriteLine($"  Room Number: {room.roomNumber}");
            Console.WriteLine($"  Room Type: {room.roomType}");
            Console.WriteLine($"  Price Per Night: {room.pricePerNight:C}");
            Console.WriteLine($"  Total Nights: {guest.totalNights}");
            Console.WriteLine($"  Total Cost: {totalCost:C}");
        }


        //Case 04 - View All Rooms
        static void ViewAllRooms(List<Room> rooms)
        {
            Console.WriteLine(" --- View All Rooms --- ");

            if (!rooms.Any())
            {
                Console.WriteLine("No rooms added yet.");
                return;
            }

            Console.WriteLine($"Total Rooms {rooms.Count}");
            Console.WriteLine("--------------------------------------");

            //LINQ - OrderBy
            var sortedRooms = rooms.OrderBy(r => r.roomNumber);

            foreach (var r in sortedRooms)
            {
                Console.WriteLine($"Room Number: {r.roomNumber}");
                Console.WriteLine($"Room Type: {r.roomType}");
                Console.WriteLine($"Price Per Night: {r.pricePerNight:C}");
                Console.WriteLine($"Availability: {(r.isAvailable ? "Available" : "Booked")}");
                Console.WriteLine("---------------------------------------");
            }
        }


        //Case 05 - View All Guests
        static void ViewAllGuests(List<Guest> guests)
        {
            Console.WriteLine(" --- View All Guests --- ");

            if (!guests.Any())
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            Console.WriteLine($"All Guests: {guests.Count()}");

            //LINQ - OrderBy
            var sortedGuests = guests.OrderBy(r => r.guestId);

            foreach (var g in sortedGuests)
            {
                Console.WriteLine($"Guest ID: {g.guestId}");
                Console.WriteLine($"Guest Name: {g.guestName}");
                Console.WriteLine($"Room Number: {g.roomNumber}");
                Console.WriteLine($"Check-in Date: {g.checkInDate}");
                Console.WriteLine($"Total Nights: {g.totalNights}");
                Console.WriteLine("---------------------------------------");
            }

        }


        //-------------------------------- Medium ( Cases 6 - 10 ) --------------------------------------------
        //Case 06 - Search & Filter Rooms
        //Case 06 - Search & Filter Rooms
        static void SearchAndFilterRooms(List<Room> rooms)
        {
            Console.WriteLine(" --- Search & Filter Rooms --- ");
            Console.WriteLine("1. Show all available rooms");
            Console.WriteLine("2. Filter by room type");
            Console.WriteLine("3. Filter by max price");
            Console.WriteLine("4. Room price statistics");
            Console.WriteLine("0. Back");
            Console.Write("Enter your choice: ");
            string subChoice = Console.ReadLine();

            switch (subChoice)
            {
                case "1":
                    //LINQ - Where + OrderBy
                    var availableRooms = rooms.Where(r => r.isAvailable).OrderBy(r => r.pricePerNight);

                    if (!availableRooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        return;
                    }

                    Console.WriteLine($"Available Rooms: {availableRooms.Count()}");
                    foreach (var r in availableRooms)
                    {
                        Console.WriteLine($"  Room Number: {r.roomNumber} | Type: {r.roomType} | Price: {r.pricePerNight:C}");
                    }
                    break;

                case "2":
                    Console.Write("Enter room type: ");
                    string typeFilter = Console.ReadLine();

                    //LINQ - Where
                    var typeRooms = rooms.Where(r => r.roomType.ToLower() == typeFilter.ToLower());

                    if (!typeRooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        return;
                    }

                    Console.WriteLine($"Rooms of type '{typeFilter}': {typeRooms.Count()}");
                    foreach (var r in typeRooms)
                    {
                        Console.WriteLine($"  Room Number: {r.roomNumber} | Price: {r.pricePerNight:C} | Availability: {(r.isAvailable ? "Available" : "Booked")}");
                    }
                    break;

                case "3":
                    Console.Write("Enter maximum price: ");
                    double maxPrice = Convert.ToDouble(Console.ReadLine());

                    //LINQ - Where + OrderBy
                    var affordableRooms = rooms.Where(r => r.isAvailable && r.pricePerNight <= maxPrice).OrderBy(r => r.pricePerNight);

                    if (!affordableRooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        return;
                    }

                    Console.WriteLine($"Available Rooms at or below {maxPrice:C}: {affordableRooms.Count()}");
                    foreach (var r in affordableRooms)
                    {
                        Console.WriteLine($"  Room Number: {r.roomNumber} | Type: {r.roomType} | Price: {r.pricePerNight:C}");
                    }
                    break;

                case "4":
                    if (!rooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        return;
                    }

                    //LINQ - Count, Average, Min, Max
                    int totalRooms = rooms.Count();
                    int availableCount = rooms.Count(r => r.isAvailable);
                    double avgPrice = rooms.Average(r => r.pricePerNight);
                    double minPrice = rooms.Min(r => r.pricePerNight);
                    double maxPriceStat = rooms.Max(r => r.pricePerNight);

                    Console.WriteLine("--- Room Price Statistics ---");
                    Console.WriteLine($"  Total Rooms: {totalRooms}");
                    Console.WriteLine($"  Available Rooms: {availableCount}");
                    Console.WriteLine($"  Average Price: {avgPrice:F2}");
                    Console.WriteLine($"  Cheapest Price: {minPrice:F2}");
                    Console.WriteLine($"  Most Expensive Price: {maxPriceStat:F2}");
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }


        

    }
}
