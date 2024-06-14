using AutoMapper;
using HotelReviewApp.DTO;
using HotelReviewApp.Interfaces;
using HotelReviewApp.Models;
using HotelReviewApp.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;


namespace HotelReviewApp.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class HotelController : Controller
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public HotelController(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<HotelDto>))]
        public IActionResult GetHotels()
        {
            var hotels = _mapper.Map<IEnumerable<HotelDto>>(_hotelRepository.GetHotels());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(hotels);
        }

        [HttpGet("{hotelId}")]
        [ProducesResponseType(200, Type = typeof(Hotel))]
        [ProducesResponseType(400)]
        public IActionResult GetHotel(int hotelId)
        {
            if (!_hotelRepository.HotelExists(hotelId))
                return NotFound();

            var hotel = _mapper.Map<HotelDto>(_hotelRepository.GetHotel(hotelId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(hotel);
        }

        [HttpGet("{hotelId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]
        public IActionResult GetHotelRating(int hotelId)
        {
            if (!_hotelRepository.HotelExists(hotelId))
                return NotFound();

            var rating = _hotelRepository.GetHotelRating(hotelId);

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(rating);
        }
    }
}
