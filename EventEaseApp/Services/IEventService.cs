using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public interface IEventService
    {
        Task<List<EventModel>> GetEventsAsync();
        Task AddEventAsync(EventModel newEvent);
        Task DeleteEventAsync(int eventId);
    }
}