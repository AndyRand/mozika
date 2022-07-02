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
    [ResponseCache(Duration = 604800)]
    public class GenreController : ControllerBase
    {
        private readonly IMozikaSupervisor _MozikaSupervisor;

        public GenreController(IMozikaSupervisor MozikaSupervisor)
        {
            _MozikaSupervisor = MozikaSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<GenreApiModel>))]
        public ActionResult<List<GenreApiModel>> Get()
        {
            try
            {
                return new ObjectResult(_MozikaSupervisor.GetAllGenre());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(GenreApiModel))]
        public ActionResult<GenreApiModel> Get(int id)
        {
            try
            {
                var genre = _MozikaSupervisor.GetGenreById(id);
                if ( genre == null)
                {
                    return NotFound();
                }

                return Ok(genre);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<GenreApiModel> Post([FromBody] GenreApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, _MozikaSupervisor.AddGenre(input));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<GenreApiModel> Put(int id, [FromBody] GenreApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (_MozikaSupervisor.GetGenreById(id) == null)
                {
                    return NotFound();
                }

                // var errors = JsonConvert.SerializeObject(ModelState.Values
                //     .SelectMany(state => state.Errors)
                //     .Select(error => error.ErrorMessage));
                // Debug.WriteLine(errors);

                if (_MozikaSupervisor.UpdateGenre(input))
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
                if (_MozikaSupervisor.GetGenreById(id) == null)
                {
                    return NotFound();
                }

                if (_MozikaSupervisor.DeleteGenre(id))
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