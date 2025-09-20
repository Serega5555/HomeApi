using System.Threading.Tasks;
using HomeApi.Data.Models;
using HomeApi.Data.Queries;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа Room в базе 
    /// </summary>
    public interface IRoomRepository
    {
        Task<Room> GetRoomById(string id);
        Task<Room> GetRoomByName(string name);
        Task<Room> GetRoomByNameExceptId(string id, string name);
        Task AddRoom(Room room);
        Task UpdateRoom(Room room, UpdateRoomQuery query);
    }
}
