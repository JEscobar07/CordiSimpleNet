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
    public class ReservationsPostController : ReservationsControllers
    {
        public ReservationsPostController(IReservationRepository _reservationRepository) : base(_reservationRepository)
        {
        }

        [HttpPost]
        public async Task<ActionResult<Reservation>> PostReservation([FromBody] ReservationDTO reservationDTO){

            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }else{

                var reservation = new Reservation{
                    Event_id = reservationDTO.Event_id,
                    User_id = reservationDTO.User_id,
                    Status = true
                };
                await reservationRepository.Add(reservation);
                return Ok("Reservation saved successfully");
            }
        }
    }
}