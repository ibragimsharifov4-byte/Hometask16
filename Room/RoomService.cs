


public class RoomService : IRoom
{
    public void CalculatePrice(int nights, Room room)
    {
        int pricePerNight = 100;
        int totalPrice = nights * pricePerNight;
        Console.WriteLine($"Total price for {nights} nights in room {room.RoomNumber}: ${totalPrice}");
    }
    public void CheckIn(string guestName, Room room)
    {
        if (room.IsAvailable)
        {
            room.GuestName = guestName;
            room.IsAvailable = false;
            Console.WriteLine($"Guest {guestName} checked into room {room.RoomNumber}.");
        }
        else
        {
            Console.WriteLine($"Room {room.RoomNumber} is not available for check-in.");
        }
    }
    public void CheckOut(Room room)
    {
        if (!room.IsAvailable)
        {
            Console.WriteLine($"Guest {room.GuestName} checked out from room {room.RoomNumber}.");
            room.IsAvailable = true;
        }
        else
        {
            Console.WriteLine($"Room {room.RoomNumber} is already available for check-out.");
        }
    }
    
}