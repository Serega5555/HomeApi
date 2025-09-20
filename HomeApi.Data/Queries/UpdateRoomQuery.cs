using HomeApi.Contracts.Models.Rooms;

namespace HomeApi.Data.Queries
{
    /// <summary>
    /// Класс для передачи дополнительных параметров при обновлении комнаты
    /// </summary>
    public class UpdateRoomQuery
    {
        public string NewName { get; }
        public int NewArea { get; }
        public bool NewGasConnected { get; }
        public int NewVoltage { get; }
        
        public UpdateRoomQuery(EditRoomRequest updateRoomQuery)
        {
            NewName = updateRoomQuery.NewName;
            NewArea = updateRoomQuery.NewArea;
            NewGasConnected = updateRoomQuery.NewGasConnected;
            NewVoltage = updateRoomQuery.NewVoltage;
        }
    }
}
