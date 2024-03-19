using EFHotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHotelBooking.Services
{
    public class RoomServices
    {
        public Room AddRoom(Room room)
        {
            AcademyHotelContext context = new AcademyHotelContext();
            context.Rooms.Add(room);
            context.SaveChanges();

            return room;
        }

        public List<Room> GetAllRooms()
        {
            AcademyHotelContext context = new AcademyHotelContext();
            List<Room> rooms = context.Rooms.Where(x => x.IsDeleted == false).ToList();
            return rooms;
        }

        public void DeleteRoom(int id)
        {
            AcademyHotelContext context = new AcademyHotelContext();
            //once silinecek oda bulunur
            //Room room = context.Rooms.Find(id);
            Room room = context.Rooms.FirstOrDefault(x => x.Id == id);

            room.IsDeleted = true;
            context.SaveChanges();
        }

        public List<Room> GetRoomsByPriceRate(decimal minPrice, decimal maxPrice)
        {
            AcademyHotelContext context = new AcademyHotelContext();

            List<Room> rooms = context.Rooms.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList();

            return rooms;
        }

        public List<Room> GetRoomsByStatus(bool status)
        {
            AcademyHotelContext context = new AcademyHotelContext();

            List<Room> rooms = context.Rooms.Where(x => x.IsAvailable == status && x.IsDeleted == false).ToList();

            return rooms;

        }
    }
}
