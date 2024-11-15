using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.Models;
using CordiSimpleNet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CordiSimpleNet.Controllers.v1.reservations
{
    [ApiController]
    [Route("api/v1/reservations/[controller]")]
    [Tags("Reservation")]
    public class ReservationsGetController : ReservationsControllers
    {
        public ReservationsGetController(IReservationRepository _reservationRepository) : base(_reservationRepository)
        {
        }

        [HttpGet("Reservation")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetAll(){
            var  reservation = await reservationRepository.GetAll();
            if( reservation == null){
                return NotFound("No tienes reservasiones disponible");
            }else{
                return Ok(reservation);
            }
        }

        [HttpGet("Reservation/{id}")]
        public async Task<ActionResult<Reservation>> GetId([FromRoute] int id){
            var reservation = await reservationRepository.GetId(id);
            if( reservation == null){
                return NotFound($"No se encontró la reservación con el id: {id}");
            }else{
                return Ok(reservation);
            }
        }
    }
}