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
    public class ArtistController : ControllerBase
    {
        private readonly IMozikaSupervisor _MozikaSupervisor;

        public ArtistController(IMozikaSupervisor MozikaSupervisor)
        {
            _MozikaSupervisor = MozikaSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<ArtistApiModel>))]
        public ActionResult<List<ArtistApiModel>> Get()
        {
            try
            {
                return new ObjectResult(_MozikaSupervisor.GetAllArtist());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(ArtistApiModel))]
        public ActionResult<ArtistApiModel> Get(int id)
        {
            try
            {
                var artist = _MozikaSupervisor.GetArtistById(id);
                if ( artist == null)
                {
                    return NotFound();
                }

                return Ok(artist);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<ArtistApiModel> Post([FromBody] ArtistApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, _MozikaSupervisor.AddArtist(input));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<ArtistApiModel> Put(int id, [FromBody] ArtistApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (_MozikaSupervisor.GetArtistById(id) == null)
                {
                    return NotFound();
                }

                // var errors = JsonConvert.SerializeObject(ModelState.Values
                //     .SelectMany(state => state.Errors)
                //     .Select(error => error.ErrorMessage));
                // Debug.WriteLine(errors);

                if (_MozikaSupervisor.UpdateArtist(input))
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
                if (_MozikaSupervisor.GetAlbumById(id) == null)
                {
                    return NotFound();
                }

                if (_MozikaSupervisor.DeleteAlbum(id))
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
    }
}