

public interface IRoom
{
    void CalculatePrice(int nights,Room room);
    void CheckIn(string guestName, Room room);
    void CheckOut(Room room);
}