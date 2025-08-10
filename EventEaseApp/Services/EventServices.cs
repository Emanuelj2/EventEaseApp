using System;
using EventEaseApp.Data;
using EventEaseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EventEaseApp.Services
{
    public class EventService : IEventService
    {
        private readonly AppDbContext _context;

        public EventService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<EventModel>> GetEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task AddEventAsync(EventModel newEvent)
        {
            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEventAsync(int eventId)
        {
            var eventToRemove = await _context.Events.FindAsync(eventId);
            if (eventToRemove != null)
            {
                _context.Events.Remove(eventToRemove);
                await _context.SaveChangesAsync();
            }
        }
    }
}