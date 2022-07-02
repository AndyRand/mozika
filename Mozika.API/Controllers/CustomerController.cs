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
    public class CustomerController : ControllerBase
    {
        private readonly IMozikaSupervisor _MozikaSupervisor;

        public CustomerController(IMozikaSupervisor MozikaSupervisor)
        {
            _MozikaSupervisor = MozikaSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<CustomerApiModel>))]
        public ActionResult<List<CustomerApiModel>> Get()
        {
            try
            {
                return new ObjectResult(_MozikaSupervisor.GetAllCustomer());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(CustomerApiModel))]
        public ActionResult<CustomerApiModel> Get(int id)
        {
            try
            {
                var customer = _MozikaSupervisor.GetCustomerById(id);
                if ( customer == null)
                {
                    return NotFound();
                }

                return Ok(customer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("supportrep/{id}")]
        [Produces(typeof(List<CustomerApiModel>))]
        public ActionResult<CustomerApiModel> GetBySupportRepId(int id)
        {
            try
            {
                var rep = _MozikaSupervisor.GetEmployeeById(id);
                if ( rep == null)
                {
                    return NotFound();
                }

                return Ok(rep);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<CustomerApiModel> Post([FromBody] CustomerApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, _MozikaSupervisor.AddCustomer(input));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<CustomerApiModel> Put(int id, [FromBody] CustomerApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (_MozikaSupervisor.GetCustomerById(id) == null)
                {
                    return NotFound();
                }

                // var errors = JsonConvert.SerializeObject(ModelState.Values
                //     .SelectMany(state => state.Errors)
                //     .Select(error => error.ErrorMessage));
                // Debug.WriteLine(errors);

                if (_MozikaSupervisor.UpdateCustomer(input))
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
                if (_MozikaSupervisor.GetCustomerById(id) == null)
                {
                    return NotFound();
                }

                if (_MozikaSupervisor.DeleteCustomer(id))
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