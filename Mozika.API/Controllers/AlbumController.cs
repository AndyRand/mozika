using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Mozika.Domain.Supervisor;
using Mozika.Domain.ApiModels;
using Microsoft.AspNetCore.Cors;
using System.Linq;

namespace Mozika.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IMozikaSupervisor _MozikaSupervisor;

        public AlbumController(IMozikaSupervisor MozikaSupervisor)
        {
            _MozikaSupervisor = MozikaSupervisor;
        }

        
        // GET api/values
        /// <summary>
        /// Get Album Value
        /// </summary>
        /// <remarks>This API will get the values.</remarks>
        [HttpGet]
        [Produces(typeof(List<AlbumApiModel>))]
        public ActionResult<List<AlbumApiModel>> Get()
        {
            try
            {
                return new ObjectResult(_MozikaSupervisor.GetAllAlbum());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(AlbumApiModel))]
        public ActionResult<AlbumApiModel> Get(int id)
        {
            try
            {
                var album = _MozikaSupervisor.GetAlbumById(id);
                if (album == null)
                {
                    return NotFound();
                }

                return Ok(album);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("artist/{id}")]
        [Produces(typeof(List<AlbumApiModel>))]
        public ActionResult<List<AlbumApiModel>> GetByArtistId(int id)
        {
            try
            {
                var artist = _MozikaSupervisor.GetArtistById(id);
                if ( artist == null)
                {
                    return NotFound();
                }

                return Ok(_MozikaSupervisor.GetAlbumByArtistId(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<AlbumApiModel> Post([FromBody] AlbumApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, _MozikaSupervisor.AddAlbum(input));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<AlbumApiModel> Put(int id, [FromBody] AlbumApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (_MozikaSupervisor.GetAlbumById(id) == null)
                {
                    return NotFound();
                }

                // var errors = JsonConvert.SerializeObject(ModelState.Values
                //     .SelectMany(state => state.Errors)
                //     .Select(error => error.ErrorMessage));
                // Debug.WriteLine(errors);

                if (_MozikaSupervisor.UpdateAlbum(input))
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

        [HttpGet("albumtitle/{title}")]
        [Produces(typeof(List<AlbumApiModel>))]
        public ActionResult<List<AlbumApiModel>> GetByTitle(string title)
        {
            try
            {

                return Ok(_MozikaSupervisor.GetAllAlbumByTitle(title));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("search/{libelle}")]
        [Produces(typeof(List<SearchApiModel>))]
        public ActionResult<List<SearchApiModel>> Search(string libelle)
        {
            try
            {
                IEnumerable<AlbumApiModel> album = _MozikaSupervisor.GetAllAlbumByTitle(libelle);
                IEnumerable<TrackApiModel> track = _MozikaSupervisor.GetAllTrackByName(libelle);
                IEnumerable<ArtistApiModel> artist = _MozikaSupervisor.GetAllArtistByName(libelle);
                List<SearchApiModel> retour = new List<SearchApiModel>();                          
                for (var i=0;i<album.Count();i++)
                {
                    AlbumApiModel tempAlbum = album.ToList().ElementAt(i);
                    retour.Add(new SearchApiModel
                    {
                        Id = tempAlbum.AlbumId,
                        Libelle = tempAlbum.Title,
                        Type = "Album"
                    });
                    if (i == 3) break;
                }
                for (var i = 0; i < artist.Count(); i++)
                {
                    ArtistApiModel tempArtist = artist.ToList().ElementAt(i);
                    retour.Add(new SearchApiModel
                    {
                        Id = tempArtist.ArtistId,
                        Libelle = tempArtist.Name,
                        Type = "Artist"
                    });
                    if (i == 3) break;
                }
                for (var i = 0; i < track.Count(); i++)
                {
                    TrackApiModel temptrack = track.ToList().ElementAt(i);
                    retour.Add(new SearchApiModel
                    {
                        Id = temptrack.TrackId,
                        Libelle = temptrack.Name,
                        Type = "Track"
                    });
                    if (i == 3) break;
                }
               

                return Ok(retour);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}