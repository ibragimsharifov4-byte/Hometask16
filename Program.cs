


var room1 = new Room
{
    Id = 1,
    RoomNumber = "101",
    Capacity = 2,
    IsAvailable = true
};
var room2 = new Room
{
    Id = 2,
    RoomNumber = "102",
    Capacity = 3,
    IsAvailable = true
};

var roomService = new RoomService();
roomService.CalculatePrice(3, room1);
roomService.CheckIn("John Doe", room1);
roomService.CheckOut(room1);