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
    public class ReservationServices : IReservationRepository
    {
        private readonly AppDbContext context;

        public ReservationServices(AppDbContext _context)
        {
            context = _context;
        }

        public async Task Add(Reservation reservation)
        {
            await context.Reservations.AddAsync(reservation);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Reservation>> GetAll()
        {
            return await context.Reservations.ToListAsync();
        }

        public async Task<Reservation> GetId(int id)
        {
            return await context.Reservations.FindAsync(id);
        }

        public async Task<Reservation> Update(int id, Reservation reservation)
        {
            var reservationFound = await context.Reservations.FindAsync(id);
            if( reservationFound != null)
            {
                reservationFound.Status = reservation.Status;
                await context.SaveChangesAsync();
                return reservationFound;
            }else{
                return reservationFound;
            }
        }
    }
}