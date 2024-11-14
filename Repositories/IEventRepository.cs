using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.Models;

namespace CordiSimpleNet.Repositories
{
    public interface IEventRepository
    {
        public Task<IEnumerable<Event>> GetAll();

        public Task<Event> GetId(int id);

        public Task Add(Event ev);

        public Task<Event> Update(int id, Event ev);

        public Task<bool> Delete(int id);
    }
}