using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CordiSimpleNet.Controllers.v1.reservations
{
    [ApiController]
    [Route("api/v1/reservations/[controller]")]
    [Tags("Reservation")]
    public class ReservationsControllers : ControllerBase
    {
        public readonly IReservationRepository reservationRepository;

        public ReservationsControllers(IReservationRepository _reservationRepository){
            reservationRepository = _reservationRepository;
        }
    }
}