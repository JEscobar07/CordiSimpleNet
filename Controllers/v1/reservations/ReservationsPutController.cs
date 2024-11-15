using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.DTOS;
using CordiSimpleNet.Models;
using CordiSimpleNet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CordiSimpleNet.Controllers.v1.reservations
{
    [ApiController]
    [Route("api/v1/reservations/[controller]")]
    [Tags("Reservation")]
    public class ReservationsPutController : ReservationsControllers
    {
        public ReservationsPutController(IReservationRepository _reservationRepository) : base(_reservationRepository)
        {
        }

        [HttpPut("Reservation/{id}")]
        public async Task<ActionResult<Reservation>> PutReservation([FromBody] ReservationUpdateDTO reservation, [FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }else{
                var reservationFound = await reservationRepository.GetId(id);
                if (reservationFound == null)
                {
                    return NotFound("No reservation found for the given id");
                }else{
                    reservationFound.Status = reservation.Status;
                    reservationFound.User_id = reservation.User_id;
                    reservationFound.Event_id = reservation.Event_id;
                    await reservationRepository.Update(id, reservationFound);
                    return Ok(reservationFound);
                }
            }
        }
    }
}