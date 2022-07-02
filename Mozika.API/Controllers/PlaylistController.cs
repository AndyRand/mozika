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
    public class PlaylistController : ControllerBase
    {
        private readonly IMozikaSupervisor _MozikaSupervisor;

        public PlaylistController(IMozikaSupervisor MozikaSupervisor)
        {
            _MozikaSupervisor = MozikaSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<PlaylistApiModel>))]
        public ActionResult<List<PlaylistApiModel>> Get()
        {
            try
            {
                return new ObjectResult(_MozikaSupervisor.GetAllPlaylist());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(PlaylistApiModel))]
        public ActionResult<PlaylistApiModel> Get(int id)
        {
            try
            {
                var playList = _MozikaSupervisor.GetPlaylistById(id);
                if ( playList == null)
                {
                    return NotFound();
                }

                return Ok(playList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<PlaylistApiModel> Post([FromBody] PlaylistApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, _MozikaSupervisor.AddPlaylist(input));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<PlaylistApiModel> Put(int id, [FromBody] PlaylistApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (_MozikaSupervisor.GetPlaylistById(id) == null)
                {
                    return NotFound();
                }

                // var errors = JsonConvert.SerializeObject(ModelState.Values
                //     .SelectMany(state => state.Errors)
                //     .Select(error => error.ErrorMessage));
                // Debug.WriteLine(errors);

                if (_MozikaSupervisor.UpdatePlaylist(input))
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
                if (_MozikaSupervisor.GetPlaylistById(id) == null)
                {
                    return NotFound();
                }

                if (_MozikaSupervisor.DeletePlaylist(id))
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
        
        [HttpGet("track/{id}")]
        [Produces(typeof(List<TrackApiModel>))]
        public ActionResult<TrackApiModel> GetByTrackId(int id)
        {
            try
            {
                return Ok(_MozikaSupervisor.GetPlaylistByTrackId(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}