using CarWorkshop.Entities;

namespace CarWorkshop.Storage.InMemory
{
    public class InMemoryAppointmentStorage : InMemoryEntityStorage<Appointment>, IAppointmentStorage
    {
    }
}
