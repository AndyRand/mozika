using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Mozika.Domain.Supervisor;
using Mozika.Domain.ApiModels;
using Microsoft.AspNetCore.Cors;

namespace Mozika.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly IMozikaSupervisor _MozikaSupervisor;

        public TrackController(IMozikaSupervisor MozikaSupervisor)
        {
            _MozikaSupervisor = MozikaSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<TrackApiModel>))]
        public ActionResult<List<TrackApiModel>> Get()
        {
            try
            {
                return new ObjectResult(_MozikaSupervisor.GetAllTrack());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(TrackApiModel))]
        public ActionResult<TrackApiModel> Get(int id)
        {
            try
            {
                var track = _MozikaSupervisor.GetTrackById(id);
                if ( track == null)
                {
                    return NotFound();
                }

                return Ok(track);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("album/{id}")]
        [Produces(typeof(List<TrackApiModel>))]
        public ActionResult<TrackApiModel> GetByAlbumId(int id)
        {
            try
            {
                return Ok(_MozikaSupervisor.GetTrackByAlbumId(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("mediatype/{id}")]
        [Produces(typeof(List<TrackApiModel>))]
        public ActionResult<TrackApiModel> GetByMediaTypeId(int id)
        {
            try
            {
                return Ok(_MozikaSupervisor.GetTrackByMediaTypeId(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("genre/{id}")]
        [Produces(typeof(List<TrackApiModel>))]
        public ActionResult<TrackApiModel> GetByGenreId(int id)
        {
            try
            {
                return Ok(_MozikaSupervisor.GetTrackByGenreId(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<TrackApiModel> Post([FromBody] TrackApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, _MozikaSupervisor.AddTrack(input));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<TrackApiModel> Put(int id, [FromBody] TrackApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (_MozikaSupervisor.GetTrackById(id) == null)
                {
                    return NotFound();
                }

                // var errors = JsonConvert.SerializeObject(ModelState.Values
                //     .SelectMany(state => state.Errors)
                //     .Select(error => error.ErrorMessage));
                // Debug.WriteLine(errors);

                if (_MozikaSupervisor.UpdateTrack(input))
                {
                    return Ok(input);
                }

                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if (_MozikaSupervisor.GetTrackById(id) == null)
                {
                    return NotFound();
                }

                if (_MozikaSupervisor.DeleteTrack(id))
                {
                    return Ok();
                }

                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        
        [HttpGet("artist/{id}")]
        [Produces(typeof(List<TrackApiModel>))]
        public ActionResult<TrackApiModel> GetByArtistId(int id)
        {
            try
            {
                return Ok(_MozikaSupervisor.GetTrackByArtistId(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        
        [HttpGet("invoice/{id}")]
        [Produces(typeof(List<TrackApiModel>))]
        public ActionResult<TrackApiModel> GetByInvoiceId(int id)
        {
            try
            {
                return Ok(_MozikaSupervisor.GetTrackByInvoiceId(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}