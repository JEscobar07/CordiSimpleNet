using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.Data;
using CordiSimpleNet.Models;
using CordiSimpleNet.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleNet.Services
{
    public class EventServices : IEventRepository
    {

        private readonly AppDbContext context;


        public EventServices(AppDbContext _context)
        {
            context = _context;
        }

        public async Task Add(Event ev)
        {
            await context.AddAsync(ev);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var eventFound = await context.Events.FindAsync(id);
            if (eventFound != null)
            {
                context.Events.Remove(eventFound);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            return await context.Events.ToListAsync();
        }

        public async Task<Event> GetId(int id)
        {
            return await context.Events.FindAsync(id);
        }

        public async Task<Event> Update(int id, Event ev)
        {
            var eventFound = await context.Events.FindAsync(id);
            if (eventFound != null)
            {
                eventFound.Name = ev.Name;
                eventFound.Description = ev.Description;
                eventFound.Date_start = ev.Date_start;
                eventFound.Date_end = ev.Date_end;
                eventFound.Location = ev.Location;
                eventFound.Max_slots = ev.Max_slots;
                eventFound.Occupied_slots = ev.Occupied_slots;
                eventFound.Status = ev.Status;

                await context.SaveChangesAsync();
                return eventFound;
            }else{
                return eventFound;
            }

        }
    }
}