using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.Models;

namespace CordiSimpleNet.Repositories
{
    public interface IReservationRepository
    {
        public Task<IEnumerable<Reservation>> GetAll();

        public Task<Reservation> GetId(int id);

        public Task Add(Reservation reservation);

        public Task<Reservation> Update(int id, Reservation reservation);


    }
}